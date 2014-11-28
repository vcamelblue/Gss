using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gss.Controller;
using Gss.Filtra;
using Gss.Model;

namespace Gss.View 
{
    public partial class AggiungiModificaSkipass : Form 
	{
        private PrenotazioniController prenotazioneController;
        private ResortController resortController;
        private SkiCard skicard;
        private SkiPass skipass;
        private bool inEditingMode;

        public AggiungiModificaSkipass(PrenotazioniController prenotazioneController, ResortController resortController,SkiCard skicard) 
		{
            this.prenotazioneController = prenotazioneController;
            this.resortController = resortController;
            this.skicard = skicard;
            this.skipass = null;
            inEditingMode = false;

            InitializeComponent();
        }

        public AggiungiModificaSkipass(PrenotazioniController prenotazioneController,ResortController resortController, SkiCard skicard, SkiPass skipass)
        {
            this.prenotazioneController = prenotazioneController;
            this.resortController = resortController;
            this.skicard = skicard;
            this.skipass = skipass;
            inEditingMode = true;

            InitializeComponent();

            this.Text = "Modifica SkiPass";
            AggiungiSkipassButton.Text = "Salva Modifiche";
        }

        private void AggiungiModificaSkipass_Load(object sender, EventArgs e)
        {
            RiempiImpiantiGrid(resortController.GetImpianti());

            RiempiComdoBoxForm();

            SetRangeDate();

            perNomeRadioButton.Checked = true;

            if (!inEditingMode)
            {
                codiceSkipassTextBox.Text = prenotazioneController.Gss.NumeroSkiPass.ToString();
                codiceSkipassTextBox.Enabled = false;
            }
            else
            {
                codiceSkipassTextBox.Text = skipass.Codice;
                codiceSkipassTextBox.Enabled = false;
                tipologiaSkipassComboBox.SelectedIndex = tipologiaSkipassComboBox.FindStringExact(GetTipologiaBySkipass(skipass));
                if (tipologiaSkipassComboBox.SelectedIndex == 0)
                {
                    SkiPassAGiornata skipassAGiornata = (SkiPassAGiornata)skipass;
                    skipassAGiornataDataInizioTimePicker.Value = skipassAGiornata.DataInizio;
                    skipassAGiornataDataFineTimePicker.Value = skipassAGiornata.DataFine;
                }
                else
                {
                    SkiPassAdAccesso skipassAdAccesso = (SkiPassAdAccesso)skipass;
                    skipassAdAccessoDataInizioTimePicker.Value = skipassAdAccesso.DataRilascio;
                }
            }
        }

        private void RiempiImpiantiGrid(Impianti impianti)
        {
            impiantiDataGridView.Rows.Clear();
            foreach(Impianto i in impianti.ListaImpianti)
            {
                impiantiDataGridView.Rows.Add(i.Codice,i.Nome,i.Versante,i.GetPisteAlpine().Count,i.GetPisteFondo().Count,i.GetPisteSnowPark().Count);
            }
        }

        //restituisce la stringa corrispondente al tipo di skipass
        private string GetTipologiaBySkipass(SkiPass skipass)
        {
            if (skipass is SkiPassAGiornata)
            {
                return "SkiPass A Giornata";
            }
            if (skipass is SkiPassAdAccesso)
            {
                return "SkiPass Ad Accesso";
            }
            return "";
        }

        private void SetRangeDate()
        {
            skipassAGiornataDataInizioTimePicker.MinDate = prenotazioneController.Gss.Resort.DataInizioStagione;
            skipassAGiornataDataInizioTimePicker.MaxDate = prenotazioneController.Gss.Resort.DataFineStagione;

            skipassAGiornataDataFineTimePicker.MinDate = prenotazioneController.Gss.Resort.DataInizioStagione;
            skipassAGiornataDataFineTimePicker.MaxDate = prenotazioneController.Gss.Resort.DataFineStagione;

            skipassAdAccessoDataInizioTimePicker.MinDate = prenotazioneController.Gss.Resort.DataInizioStagione;
            skipassAdAccessoDataInizioTimePicker.MaxDate = prenotazioneController.Gss.Resort.DataFineStagione;

        }

        private void visualizzaDettagliImpiantoButton_Click(object sender, EventArgs e)
        {
            foreach (Impianto i in prenotazioneController.Gss.Resort.Impianti.ListaImpianti)
            {
                if (i.Codice == impiantiDataGridView.SelectedRows[0].Cells[0].Value.ToString())
                {
                    VisualizzaImpianto visualizzaForm = new VisualizzaImpianto(i);
                    visualizzaForm.Show();
                }
            }  
        }

        private void filtraButton_Click(object sender, EventArgs e)
        {
            if (perNomeRadioButton.Checked)
            {
                FiltraPerNome();
            }
            else if (prezzoMassimoRadioButton.Checked)
            {
                FiltraPerPrezzo();
            }
            else if (nPisteDiTipoRadioButton.Checked)
            {
                FiltraPerNPisteDiTipo();
            }
            else if (caratteristicaSpecificaRadioButton.Checked)
            {
                FiltraPerCaratteristicaSpecifica();
            }
        }

        private void FiltraPerCaratteristicaSpecifica()
        {
            if (caratteristicaSpecificaAlmenoFiltroTextBox.Text != "")
            {
                if (caratteristicaSpecificaFiltroComboBox.SelectedIndex == 0)//difficolta
                {

                    if (checkDifficoltà(caratteristicaSpecificaAlmenoFiltroTextBox.Text))
                    {
                        Difficolta difficoltaCercata =(Difficolta)Enum.Parse((typeof(Difficolta)), getDifficoltàGiustaByString(caratteristicaSpecificaAlmenoFiltroTextBox.Text));
                        IFiltra filtroDifficoltà = new FiltraPerDifficolta(difficoltaCercata);
                        resortController.Filtro = filtroDifficoltà;
                        Impianti impiantiCercati = resortController.Filtra(resortController.GetImpianti());
                        RiempiImpiantiGrid(impiantiCercati);
                    }
                    else
                    {
                        MessageBox.Show("Difficoltà non valida, inserisci (Alta, Media, Bassa)");
                    }

                }
                else if (caratteristicaSpecificaFiltroComboBox.SelectedIndex == 1)//dislivello max
                {
                    double dislivelloCercato = 0;
                    try
                    {
                        dislivelloCercato = double.Parse(caratteristicaSpecificaAlmenoFiltroTextBox.Text);
                        if (dislivelloCercato >= 0)
                        {
                            IFiltra filtraDislivello = new FiltraPerDislivelloMassimo(dislivelloCercato);
                            resortController.Filtro = filtraDislivello;
                            Impianti impiantiFiltrati = resortController.Filtra(resortController.GetImpianti());
                            RiempiImpiantiGrid(impiantiFiltrati);
                        }
                        else
                        {
                            MessageBox.Show("Inserire un dislivello positivo");
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Inserire un numero nel campo");
                    }
                }
                else if (caratteristicaSpecificaFiltroComboBox.SelectedIndex == 2)//dislivello medio
                {
                    double dislivelloCercato = 0;
                    try
                    {
                        dislivelloCercato = double.Parse(caratteristicaSpecificaAlmenoFiltroTextBox.Text);
                        if (dislivelloCercato >= 0)
                        {
                            IFiltra filtraDislivello = new FiltraPerDislivelloMedio(dislivelloCercato);
                            resortController.Filtro = filtraDislivello;
                            Impianti impiantiFiltrati = resortController.Filtra(resortController.GetImpianti());
                            RiempiImpiantiGrid(impiantiFiltrati);
                        }
                        else
                        {
                            MessageBox.Show("Inserire un dislivello positivo");
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Inserire un numero nel campo");
                    }
                }
                else if (caratteristicaSpecificaFiltroComboBox.SelectedIndex == 3)//numero salti
                {
                    int numeroCercato = 0;
                    try
                    {
                        numeroCercato = int.Parse(caratteristicaSpecificaAlmenoFiltroTextBox.Text);
                        if (numeroCercato >= 0)
                        {
                            IFiltra filtraDislivello = new FiltraPerNumeroSalti(numeroCercato);
                            resortController.Filtro = filtraDislivello;
                            Impianti impiantiFiltrati = resortController.Filtra(resortController.GetImpianti());
                            RiempiImpiantiGrid(impiantiFiltrati);
                        }
                        else
                        {
                            MessageBox.Show("Inserire un numero salti");
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Inserire un numero nel campo");
                    }
                }
                else //numero jibs
                {
                    int numeroCercato = 0;
                    try
                    {
                        numeroCercato = int.Parse(caratteristicaSpecificaAlmenoFiltroTextBox.Text);
                        if (numeroCercato >= 0)
                        {
                            IFiltra filtraDislivello = new FiltraPerNumeroJibs(numeroCercato);
                            resortController.Filtro = filtraDislivello;
                            Impianti impiantiFiltrati = resortController.Filtra(resortController.GetImpianti());
                            RiempiImpiantiGrid(impiantiFiltrati);
                        }
                        else
                        {
                            MessageBox.Show("Inserire un numero jibs");
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Inserire un numero nel campo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Completa il campo nome per continuare");
            }
        }

        private bool checkDifficoltà(string difficolta)
        {
            string difficoltaBassa = "Bassa";
            string difficoltaAlta = "Alta";
            string difficoltaMedia = "Media";

            if ((difficoltaBassa.Equals(difficolta, StringComparison.InvariantCultureIgnoreCase))
                || (difficoltaAlta.Equals(difficolta, StringComparison.InvariantCultureIgnoreCase))
                || (difficoltaMedia.Equals(difficolta, StringComparison.InvariantCultureIgnoreCase)))
            {
                return true;
            }
            return false;
        }


        //Mi restituisce bene le stringhe per costruirmi l'enumerativo esatto
        private string getDifficoltàGiustaByString(string difficolta)
        {
            string difficoltaBassa = "Bassa";
            string difficoltaAlta = "Alta";
            string difficoltaMedia = "Media";

            if (difficoltaBassa.Equals(difficolta, StringComparison.InvariantCultureIgnoreCase))
            {
                return difficoltaBassa;
            }

            if (difficoltaAlta.Equals(difficolta, StringComparison.InvariantCultureIgnoreCase))
            {
                return difficoltaAlta;
            }
            if (difficoltaMedia.Equals(difficolta, StringComparison.InvariantCultureIgnoreCase))
            {
                return difficoltaMedia;
            }
            return "";
        }

        private void FiltraPerNPisteDiTipo()
        {
            if (numeroPisteFiltroTextBox.Text != "")
            {
                try
                {
                    int numeroPiste = int.Parse(numeroPisteFiltroTextBox.Text);
                    string tipoPistaCercata = tipologiaPistaFiltroComboBox.SelectedItem.ToString();
                    IFiltra filtraPerNPisteDiTipo = new FiltraPistePerTipo(numeroPiste, tipoPistaCercata);
                    resortController.Filtro = filtraPerNPisteDiTipo;
                    Impianti impiantiFiltrati = resortController.Filtra(resortController.GetImpianti());
                    RiempiImpiantiGrid(impiantiFiltrati);
                }
                catch (Exception)
                {
                    MessageBox.Show("Inserisci un numero di piste valido");
                }
            }
            else
            {
                MessageBox.Show("Completa il campo nome per continuare");
            }
        }

        private void FiltraPerPrezzo()
        {
            if (prezzoMassimoFiltroTextBox.Text != "")
            {
                try
                {
                    double prezzoCercato = double.Parse(prezzoMassimoFiltroTextBox.Text);
                    if (tipologiaSkipassComboBox.SelectedIndex == 0)
                    {
                        if (skipassAGiornataDataInizioTimePicker.Value < skipassAGiornataDataFineTimePicker.Value)
                        {
                            DateTime datainizio = skipassAGiornataDataInizioTimePicker.Value;
                            DateTime datafine = skipassAGiornataDataFineTimePicker.Value;
                            IFiltra filtraPerPrezzoAGioranta = new FiltraPerPrezzoGiornata(prezzoCercato,datainizio,datafine);
                            resortController.Filtro = filtraPerPrezzoAGioranta;
                            Impianti impiantiFiltrati = resortController.Filtra(resortController.GetImpianti());
                            RiempiImpiantiGrid(impiantiFiltrati);
                        }
                        else
                        {
                            MessageBox.Show("Inserisci una data d'inizio precedente alla data di fine");
                        }
                    }
                    else
                    {
                        DateTime datainizio = skipassAdAccessoDataInizioTimePicker.Value;
                        IFiltra filtraPerPrezzoAdAccesso = new FiltraPerPrezzoAccesso(prezzoCercato, datainizio);
                        resortController.Filtro = filtraPerPrezzoAdAccesso;
                        Impianti impiantiFiltrati = resortController.Filtra(resortController.GetImpianti());
                        RiempiImpiantiGrid(impiantiFiltrati);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Inserisci un prezzo valido");
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Completa il campo nome per continuare");
            }
        }

        private void FiltraPerNome()
        {
            if (nomeImpiantoFiltroTextBox.Text != "")
            {
                IFiltra filtroPerNome = new FiltraPerNome(nomeImpiantoFiltroTextBox.Text);
                resortController.Filtro = filtroPerNome;
                Impianti impiantiFiltrati = resortController.Filtra(resortController.GetImpianti());
                RiempiImpiantiGrid(impiantiFiltrati);
            }
            else
            {
                MessageBox.Show("Completa il campo nome per continuare");
            }
        }

        private void perNomeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tipoFiltroTabControl.SelectedTab = filtroPerNomeTabPage;
        }

        private void prezzoMassimoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tipoFiltroTabControl.SelectedTab = filtroPerPrezzoTabPage;
        }

        private void nPisteDiTipoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tipoFiltroTabControl.SelectedTab = filtroPerTipoPisteTabPage;
        }

        private void caratteristicaSpecificaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tipoFiltroTabControl.SelectedTab = filtroPerCaratteristicaTabPage;
        }

        //riempio le combo box di tutti i pannelli filtra
        private void RiempiComdoBoxForm()
        {
            tipologiaSkipassComboBox.Items.Insert(0, "SkiPass A Giornata");
            tipologiaSkipassComboBox.Items.Insert(1, "SkiPass Ad Accesso");
            tipologiaSkipassComboBox.SelectedIndex = 0;

            tipologiaPistaFiltroComboBox.Items.Insert(0, "Tutte");
            tipologiaPistaFiltroComboBox.Items.Insert(1, "Alpina");
            tipologiaPistaFiltroComboBox.Items.Insert(2, "Fondo");
            tipologiaPistaFiltroComboBox.Items.Insert(3, "SnowPark");
            tipologiaPistaFiltroComboBox.SelectedIndex = 0;


            caratteristicaSpecificaFiltroComboBox.Items.Insert(0, "Difficoltà");
            caratteristicaSpecificaFiltroComboBox.Items.Insert(1, "Dislivello Massimo");
            caratteristicaSpecificaFiltroComboBox.Items.Insert(2, "Dislivello Medio");
            caratteristicaSpecificaFiltroComboBox.Items.Insert(3, "Numero Salti");
            caratteristicaSpecificaFiltroComboBox.Items.Insert(4, "Numero Jibs");
            caratteristicaSpecificaFiltroComboBox.SelectedIndex = 0;

        }

        private bool checkFields(params String[] fields)
        {
            bool all_Ok = true;

            foreach (String s in fields)
            {
                all_Ok &= (s != "");
            }
            return all_Ok;
        }

        private void caratteristicaSpecificaFiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            caratteristicaSpecificaAlmenoFiltroTextBox.Clear();
        }

        }
    }

