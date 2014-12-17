using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gss.Model;
using Gss.Controller;

namespace Gss.View 
{
    public partial class AggiungiModificaVisualizzaProfilo : Form 
	{
        private ResortController resortController;
        private PeriodiProfiliController periodiProfiliController;
        private bool inEditingMode;
        private bool inViewMode;
        private ProfiloPrezziRisorse profilo;
        private string nomeProfiloPrimaDelleModifiche;

        public AggiungiModificaVisualizzaProfilo(ResortController resortController, PeriodiProfiliController periodiProfiliController) 
		{

            //FIELDS
            this.resortController = resortController;
            this.periodiProfiliController = periodiProfiliController;
            inEditingMode = false;
            inViewMode = false;
            profilo = new ProfiloPrezziRisorse("");

            InitializeComponent();
            //aggiustare tabulazione per passare al prossimo controllo!
        }


        //COSTRUCTORS
        public AggiungiModificaVisualizzaProfilo(ResortController resortController, PeriodiProfiliController periodiProfiliController, ProfiloPrezziRisorse profilo, bool inViewMode)
        {
            this.resortController = resortController;
            this.periodiProfiliController = periodiProfiliController;
            this.inViewMode = inViewMode;
            if (inViewMode)
            {
                inEditingMode = false;
            }
            else
            {
                inEditingMode = true;
                nomeProfiloPrimaDelleModifiche = profilo.Nome;
            }
            this.profilo = profilo;

            InitializeComponent();
            //aggiustare tabulazione per passare al prossimo controllo!
        }

        private void AggiungiModificaVisualizzaProfilo_Load(object sender, EventArgs e)
        {
            RiempiGridRisorse();
            risorseDataGridView.Enabled = false;
            if (inEditingMode)
            {
                nomeProfiloTextBox.Text = profilo.Nome;
                salvaModificheRisorsaButton.Visible = true;
                this.Text = "Modifica Profilo";
            }
            if (inViewMode)
            {
                risorseDataGridView.Enabled = true;
                nomeProfiloTextBox.Text = profilo.Nome;
                nomeProfiloTextBox.Enabled = false;
                prezzoPerAccessoImpiantoTextBox.Enabled = false;
                prezzoPerGiornataImpiantoTextBox.Enabled = false;
                prezzoPerGironataPostStdTextBox.Enabled = false;
                prezzoPerPersonaExtraTextBox.Enabled = false;
                salvaButton.Visible = false;
                annullaButton.Visible = false;
                this.Text = "Visualizza Profilo";
            }
        }

        //Riempie la griglia a sinistra con tutte le risorse da prezzare del resort
        private void RiempiGridRisorse()
        {
            risorseDataGridView.Rows.Clear();
            foreach (Bungalow b in resortController.GetBungalows().ListaBungalow)
            {
                risorseDataGridView.Rows.Add("Bungalows - " + b.Codice,b.Codice);
            }
            foreach (Impianto i in resortController.GetImpianti().ListaImpianti)
            {
                risorseDataGridView.Rows.Add("Impianto - " + i.Codice,i.Codice);
            }
        }

        private void risorseDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            string codiceSelezionato = risorseDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            // Mostro la pagina adatta alla risorsa
            if (IndividuaRisorsa(codiceSelezionato) is Impianto)
            {
                RiempiGirdView(IndividuaRisorsa(codiceSelezionato));
                tabControlWithoutHeader.SelectedTab = impiantoTabPage;
                 
            }
            else if (IndividuaRisorsa(codiceSelezionato) is Bungalow)
            {
                RiempiGirdView(IndividuaRisorsa(codiceSelezionato));
                tabControlWithoutHeader.SelectedTab = bungalowTabPage;
            }
        }
        
        //cerca la risorsa selezionata
        private Risorsa IndividuaRisorsa(String codice)
        {
            foreach (Bungalow b in resortController.GetBungalows().ListaBungalow)
            {
                if (codice==b.Codice)
                {
                    return b;
                }
            }
            foreach (Impianto i in resortController.GetImpianti().ListaImpianti)
            {
                if (codice==i.Codice)
                {
                    return i;
                }
            }
            return null;
        }

        //Riempie la griglia apposita in base alla risorsa selezionata
        private void RiempiGirdView(Risorsa risorsa)
        {
            if (risorsa is Impianto)
            {
                impiantoDataGridView.Rows.Clear();
                Impianto impiantoSelezionato = (Impianto)risorsa;
                impiantoDataGridView.Rows.Add(impiantoSelezionato.Codice, impiantoSelezionato.Nome, impiantoSelezionato.Versante, impiantoSelezionato.GetPisteAlpine().Count, impiantoSelezionato.GetPisteFondo().Count, impiantoSelezionato.GetPisteSnowPark().Count);
                prezzoPerAccessoImpiantoTextBox.Text = profilo.GetPrezziRisorsa(impiantoSelezionato).GetPrezzoByTipologia(TipologiaPrezzo.PrezzoPerAccesso).Valore.ToString();
                prezzoPerGiornataImpiantoTextBox.Text = profilo.GetPrezziRisorsa(impiantoSelezionato).Prezzo.ToString();
            }
            else
            {
                bungalowDataGridView.Rows.Clear();
                Bungalow bungalowSelezionato = (Bungalow)risorsa;
                prezzoPerGironataPostStdTextBox.Text = profilo.GetPrezziRisorsa(bungalowSelezionato).Prezzo.ToString();
                prezzoPerPersonaExtraTextBox.Text = profilo.GetPrezziRisorsa(bungalowSelezionato).GetPrezzoByTipologia(TipologiaPrezzo.PrezzoPerPersonaExtra).Valore.ToString();
                bungalowDataGridView.Rows.Add(bungalowSelezionato.Codice, bungalowSelezionato.GetNumeroStanze(), bungalowSelezionato.ToStringStanze(), bungalowSelezionato.PostiTotaliStandard(), bungalowSelezionato.PostiTotaliMax());
            }
            
        }
        private void prossimaRisorsaButton_Click(object sender, EventArgs e)
        {
            if (risorseDataGridView.SelectedRows[0].Index == risorseDataGridView.Rows.Count - 2)
            {
                    prossimaRisorsaButton.Enabled = false;
            }

            if (!inEditingMode && !inViewMode)
            {
                string nomeProfilo = nomeProfiloTextBox.Text;
                string codiceSelezionato = risorseDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                if (IndividuaRisorsa(codiceSelezionato) is Impianto)
                {
                    Impianto impiantoSelezionato = (Impianto)IndividuaRisorsa(codiceSelezionato);
                    string prezzoPerGiornata = prezzoPerGiornataImpiantoTextBox.Text;
                    string prezzoPerAccesso = prezzoPerAccessoImpiantoTextBox.Text;
                    if ((prezzoPerGiornata != "") && (prezzoPerAccesso != ""))
                    {
                        try
                        {
                            double prezzoGiornata = double.Parse(prezzoPerGiornata);
                            double prezzoAccesso = double.Parse(prezzoPerAccesso);
                            PrezzoSpecifico prezzoSpecifico = new PrezzoSpecifico(TipologiaPrezzo.PrezzoPerAccesso, prezzoAccesso);   
                            PrezziRisorsa prezziRisorsa = new PrezziRisorsa(prezzoGiornata, new List<PrezzoSpecifico>());
                            prezziRisorsa.PrezziSpecifici.Add(prezzoSpecifico);
                            profilo.Add(impiantoSelezionato, prezziRisorsa);
                            SpostatiNellaGriglia();
                            prezzoPerGiornataImpiantoTextBox.Clear();
                            prezzoPerAccessoImpiantoTextBox.Clear();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Inserire dei prezzi validi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Completare tutti i campi per proseguire");
                    }
                }
                else if (IndividuaRisorsa(codiceSelezionato) is Bungalow)
                {
                    Bungalow bungalowSelezionato = (Bungalow)IndividuaRisorsa(codiceSelezionato);
                    string prezzoPerGiornata = prezzoPerGironataPostStdTextBox.Text;
                    string prezzoPerPersonaExtra = prezzoPerPersonaExtraTextBox.Text;
                    if ((prezzoPerGiornata != "") && (prezzoPerPersonaExtra != ""))
                    {
                        try
                        {
                            double prezzoGiornata = double.Parse(prezzoPerGiornata);
                            double prezzoExtra = double.Parse(prezzoPerPersonaExtra);
                            PrezzoSpecifico prezzoSpecifico = new PrezzoSpecifico(TipologiaPrezzo.PrezzoPerPersonaExtra, prezzoExtra );   
                            PrezziRisorsa prezziRisorsa = new PrezziRisorsa(prezzoGiornata, new List<PrezzoSpecifico>());
                            prezziRisorsa.PrezziSpecifici.Add(prezzoSpecifico);
                            profilo.Add(bungalowSelezionato, prezziRisorsa);
                            SpostatiNellaGriglia();
                            prezzoPerGironataPostStdTextBox.Clear();
                            prezzoPerPersonaExtraTextBox.Clear();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Inserire dei prezzi validi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Completare tutti i campi per proseguire");
                    }
                }
            }
            else if(inViewMode)
            {
                nomeProfiloTextBox.Text = profilo.Nome;
                string codiceSelezionato = risorseDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                if (IndividuaRisorsa(codiceSelezionato) is Impianto)
                {
                    Impianto impiantoSelezionato = (Impianto)IndividuaRisorsa(codiceSelezionato);
                    prezzoPerGiornataImpiantoTextBox.Text = periodiProfiliController.GetPrezzoRisorsaByProfilo(impiantoSelezionato, profilo.Nome).ToString();
                    prezzoPerAccessoImpiantoTextBox.Text = periodiProfiliController.GetPrezzoSpecificoRisorsaByProfilo(impiantoSelezionato, profilo.Nome, TipologiaPrezzo.PrezzoPerAccesso).ToString();
                    SpostatiNellaGriglia();
                }
                else
                {
                    Bungalow bungalowSelezionato = (Bungalow)IndividuaRisorsa(codiceSelezionato);
                    prezzoPerGironataPostStdTextBox.Text = periodiProfiliController.GetPrezzoRisorsaByProfilo(bungalowSelezionato, profilo.Nome).ToString();
                    prezzoPerPersonaExtraTextBox.Text = periodiProfiliController.GetPrezzoSpecificoRisorsaByProfilo(bungalowSelezionato, profilo.Nome, TipologiaPrezzo.PrezzoPerPersonaExtra).ToString();
                    SpostatiNellaGriglia();
                }
            }
            else if (inEditingMode || inViewMode)
            {
                nomeProfiloTextBox.Text = profilo.Nome;
                string codiceSelezionato = risorseDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                if (IndividuaRisorsa(codiceSelezionato) is Impianto)
                {
                    Impianto impiantoSelezionato = (Impianto)IndividuaRisorsa(codiceSelezionato);
                    prezzoPerGiornataImpiantoTextBox.Text = periodiProfiliController.GetPrezzoRisorsaByProfilo(impiantoSelezionato, profilo.Nome).ToString();
                    prezzoPerAccessoImpiantoTextBox.Text = periodiProfiliController.GetPrezzoSpecificoRisorsaByProfilo(impiantoSelezionato, profilo.Nome, TipologiaPrezzo.PrezzoPerAccesso).ToString();
                    SpostatiNellaGriglia();
                }
                else
                {
                    Bungalow bungalowSelezionato = (Bungalow)IndividuaRisorsa(codiceSelezionato);
                    prezzoPerGironataPostStdTextBox.Text = periodiProfiliController.GetPrezzoRisorsaByProfilo(bungalowSelezionato, profilo.Nome).ToString();
                    prezzoPerPersonaExtraTextBox.Text = periodiProfiliController.GetPrezzoSpecificoRisorsaByProfilo(bungalowSelezionato, profilo.Nome, TipologiaPrezzo.PrezzoPerPersonaExtra).ToString();
                    SpostatiNellaGriglia();
                }
            }
        }

        private void SpostatiNellaGriglia()
        {
            int indiceSelezionato = risorseDataGridView.SelectedRows[0].Index;
            indiceSelezionato++;
            if (indiceSelezionato < risorseDataGridView.Rows.Count)
            {
                risorseDataGridView.Rows[indiceSelezionato].Selected = true;
            }
            else
            {
                MessageBox.Show("Risorse Terminate");
            }
        }

        private void salvaButton_Click(object sender, EventArgs e)
        {
            if (!inEditingMode)
            {
                string nomeProfilo = nomeProfiloTextBox.Text;
                if (nomeProfilo != "")
                {
                    profilo.Nome = nomeProfilo;
                    try
                    {
                        periodiProfiliController.AddProfilo(profilo);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Inserire il nome del profilo");
                }
            }
            else
            {
                string nomeProfilo = nomeProfiloTextBox.Text;
                if (nomeProfilo != "")
                {
                    profilo.Nome = nomeProfilo;
                    try
                    {
                        periodiProfiliController.EditProfilo(profilo,nomeProfiloPrimaDelleModifiche);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Inserire il nome del profilo");
                }
            }
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvaModificheRisorsaButton_Click(object sender, EventArgs e)
        {
            string nomeProfilo = nomeProfiloTextBox.Text;
            string codiceSelezionato = risorseDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            if (IndividuaRisorsa(codiceSelezionato) is Impianto)
            {
                Impianto impiantoSelezionato = (Impianto)IndividuaRisorsa(codiceSelezionato);
                string prezzoPerGiornata = prezzoPerGiornataImpiantoTextBox.Text;
                string prezzoPerAccesso = prezzoPerAccessoImpiantoTextBox.Text;
                if ((prezzoPerGiornata != "") && (prezzoPerAccesso != ""))
                {
                    try
                    {
                        double prezzoGiornata = double.Parse(prezzoPerGiornata);
                        double prezzoAccesso = double.Parse(prezzoPerAccesso);
                        PrezzoSpecifico prezzoSpecifico = new PrezzoSpecifico(TipologiaPrezzo.PrezzoPerAccesso, prezzoAccesso);
                        PrezziRisorsa prezziRisorsa = new PrezziRisorsa(prezzoGiornata, new List<PrezzoSpecifico>());
                        prezziRisorsa.PrezziSpecifici.Add(prezzoSpecifico);
                        profilo.PrezziRisorse[impiantoSelezionato] = prezziRisorsa;
                        prezzoPerGiornataImpiantoTextBox.Clear();
                        prezzoPerAccessoImpiantoTextBox.Clear();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Inserire dei prezzi validi");
                    }
                }
                else
                {
                    MessageBox.Show("Completare tutti i campi");
                }
            }
            else if (IndividuaRisorsa(codiceSelezionato) is Bungalow)
            {
                Bungalow bungalowSelezionato = (Bungalow)IndividuaRisorsa(codiceSelezionato);
                string prezzoPerGiornata = prezzoPerGironataPostStdTextBox.Text;
                string prezzoPerPersonaExtra = prezzoPerPersonaExtraTextBox.Text;
                if ((prezzoPerGiornata != "") && (prezzoPerPersonaExtra != ""))
                {
                    try
                    {
                        double prezzoGiornata = double.Parse(prezzoPerGiornata);
                        double prezzoExtra = double.Parse(prezzoPerPersonaExtra);
                        PrezzoSpecifico prezzoSpecifico = new PrezzoSpecifico(TipologiaPrezzo.PrezzoPerPersonaExtra, prezzoExtra);
                        PrezziRisorsa prezziRisorsa = new PrezziRisorsa(prezzoGiornata, new List<PrezzoSpecifico>());
                        prezziRisorsa.PrezziSpecifici.Add(prezzoSpecifico);
                        profilo.PrezziRisorse[bungalowSelezionato] = prezziRisorsa;
                        prezzoPerGironataPostStdTextBox.Clear();
                        prezzoPerPersonaExtraTextBox.Clear();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Inserire dei prezzi validi");
                    }
                }
                else
                {
                    MessageBox.Show("Completare tutti i campi");
                }
            }
        }
    }
}
