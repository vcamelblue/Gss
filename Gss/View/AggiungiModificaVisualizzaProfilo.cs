﻿using System;
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

        public AggiungiModificaVisualizzaProfilo(ResortController resortController, PeriodiProfiliController periodiProfiliController) 
		{
            this.resortController = resortController;
            this.periodiProfiliController = periodiProfiliController;
            inEditingMode = false;
            inViewMode = false;
            profilo = new ProfiloPrezziRisorse("");

            InitializeComponent();
            //aggiustare tabulazione per passare al prossimo controllo!
        }

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
                risorseDataGridView.Rows.Add("Bungalows - " + b.Codice);
            }
            foreach (Impianto i in resortController.GetImpianti().ListaImpianti)
            {
                risorseDataGridView.Rows.Add("Impianto - " + i.Codice);
            }
        }

        private void risorseDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            string codiceSelezionato = risorseDataGridView.SelectedRows[0].Cells[0].Value.ToString();
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

        private Risorsa IndividuaRisorsa(String codice)//cerca la risorsa selezionata
        {
            foreach (Bungalow b in resortController.GetBungalows().ListaBungalow)
            {
                if (codice.Contains(b.Codice))
                {
                    return b;
                    break;
                }
            }
            foreach (Impianto i in resortController.GetImpianti().ListaImpianti)
            {
                if (codice.Contains(i.Codice))
                {
                    return i;
                    break;
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
            }
            else
            {
                bungalowDataGridView.Rows.Clear();
                Bungalow bungalowSelezionato = (Bungalow)risorsa;
                bungalowDataGridView.Rows.Clear();
                string informazioniBungalow = infoBungalow(bungalowSelezionato);
                string informazioniCamere = "";
                foreach (Stanza s in bungalowSelezionato.Stanze)
                {
                    informazioniCamere += TipoCameraByPosti(s);
                }
                bungalowDataGridView.Rows.Add(bungalowSelezionato.Codice, bungalowSelezionato.GetNumeroStanze(), informazioniBungalow, bungalowSelezionato.PostiTotaliStandard(), bungalowSelezionato.PostiTotaliMax());
            }
            
        }

        // Mi dice come sono le stanze del bungalow
        private string infoBungalow(Bungalow bungalow)
        {
            string result = "";
            foreach (Stanza s in bungalow.Stanze)
            {
                if (s.Equals(bungalow.Stanze[bungalow.Stanze.Count - 1]))
                {
                    result += TipoCameraByPosti(s) + " ";
                }
                else
                {
                    result += TipoCameraByPosti(s) + " + ";
                }
            }
            return result;
        }

        //Mi dice come è una stanza (singola, doppia, tripla)
        private string TipoCameraByPosti(Stanza stanza)
        {
            return (stanza.NumeroPostiStandard == 1 ? "Singola" :
                    stanza.NumeroPostiStandard == 2 ? "Doppia" :
                    stanza.NumeroPostiStandard == 3 ? "Tripla" :
                    stanza.NumeroPostiStandard == 4 ? "Quadrupla" :
                    stanza.NumeroPostiStandard == 5 ? "Quintupla" : "Nupla");
        }

        private void prossimaRisorsaButton_Click(object sender, EventArgs e)
        {
            if (!inEditingMode && !inViewMode)
            {
                string nomeProfilo = nomeProfiloTextBox.Text;
                string codiceSelezionato = risorseDataGridView.SelectedRows[0].Cells[0].Value.ToString();
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
                string codiceSelezionato = risorseDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (IndividuaRisorsa(codiceSelezionato) is Impianto)
                {
                    Impianto impiantoSelezionato = (Impianto)IndividuaRisorsa(codiceSelezionato);
                    prezzoPerGiornataImpiantoTextBox.Text = periodiProfiliController.GetPrezzoRisorsaByProfilo(impiantoSelezionato, profilo).ToString();
                    prezzoPerAccessoImpiantoTextBox.Text = periodiProfiliController.GetPrezzoSpecificoRisorsaByProfilo(impiantoSelezionato, profilo, TipologiaPrezzo.PrezzoPerAccesso).ToString();
                    SpostatiNellaGriglia();
                }
                else
                {
                    Bungalow bungalowSelezionato = (Bungalow)IndividuaRisorsa(codiceSelezionato);
                    prezzoPerGironataPostStdTextBox.Text = periodiProfiliController.GetPrezzoRisorsaByProfilo(bungalowSelezionato, profilo).ToString();
                    prezzoPerPersonaExtraTextBox.Text = periodiProfiliController.GetPrezzoSpecificoRisorsaByProfilo(impiantoSelezionato, profilo, TipologiaPrezzo.PrezzoPerPersonaExtra).ToString();
                    SpostatiNellaGriglia();
                }
            }
            else if (inEditingMode)
            {

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
    }
}
