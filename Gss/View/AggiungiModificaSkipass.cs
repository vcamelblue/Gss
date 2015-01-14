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
        //Fileds
        
        private PrenotazioniController prenotazioneController;
        private ResortController resortController;
        private SkiCard skicard;
        private SkiPass skipass;
        private bool inEditingMode;

        
            #region UtilityFields

        private readonly string difficoltaBassa = "Bassa";
        private readonly string difficoltaAlta = "Alta";
        private readonly string difficoltaMedia = "Media";

        
        private readonly int TIPO_SKIPASS_A_GIORNATA_INDEX = 0;
        private readonly int TIPO_SKIPASS_AD_ACCESSO_INDEX = 1;

        private readonly int TIPO_PISTA_TUTTE_FILTRO_INDEX = 0;
        private readonly int TIPO_PISTA_ALPINA_FILTRO_INDEX = 1;
        private readonly int TIPO_PISTA_FONDO_FILTRO_INDEX = 2;
        private readonly int TIPO_PISTA_SNOWPARK_FILTRO_INDEX = 3;

        private readonly int CARATT_SPECIF_DIFFICOLTA_FILTRO_INDEX = 0;
        private readonly int CARATT_SPECIF_DISL_MAX_FILTRO_INDEX = 1;
        private readonly int CARATT_SPECIF_DISL_MED_FILTRO_INDEX = 2;
        private readonly int CARATT_SPECIF_NUM_SALTI_FILTRO_INDEX = 3;
        private readonly int CARATT_SPECIF_NUM_JIBS_FILTRO_INDEX = 4;
        
            #endregion

        //Constructors

            //New Skipass Constructors

        public AggiungiModificaSkipass(PrenotazioniController prenotazioneController, ResortController resortController,SkiCard skicard) 
		{
            this.prenotazioneController = prenotazioneController;
            this.resortController = resortController;
            this.skicard = skicard;
            this.skipass = null;
            
            this.inEditingMode = false;

            InitializeComponent();
        }

            //Editing Skipass Constructors

        public AggiungiModificaSkipass(PrenotazioniController prenotazioneController,ResortController resortController, SkiCard skicard, SkiPass skipass)
        {
            this.prenotazioneController = prenotazioneController;
            this.resortController = resortController;
            this.skicard = skicard;
            this.skipass = skipass;
            
            this.inEditingMode = true;

            InitializeComponent();

            this.Text = "Modifica SkiPass";
            AggiungiSkipassButton.Text = "Salva Modifiche";
        }


        //Events

        #region Events

        private void AggiungiModificaSkipass_Load(object sender, EventArgs e)
        {
            RiempiImpiantiGrid(resortController.GetImpianti());

            RiempiComdoBoxForm();

            SetRangeDate();

            if (!inEditingMode)
            {
                codiceSkipassTextBox.Text = prenotazioneController.Gss.ProssimoNumeroSkiPass.ToString();
            }
            else
            {
                codiceSkipassTextBox.Text = skipass.Codice;
                tipologiaSkipassComboBox.SelectedIndex = tipologiaSkipassComboBox.FindStringExact(GetTipologiaBySkipass(skipass));
                tipologiaSkipassComboBox.Enabled = false;

                if (tipologiaSkipassComboBox.SelectedIndex == TIPO_SKIPASS_A_GIORNATA_INDEX)
                {
                    SkiPassAGiornata skipassAGiornata = (SkiPassAGiornata)skipass;
                    skipassAGiornataDataInizioTimePicker.Value = skipassAGiornata.DataInizio;
                    skipassAGiornataDataFineTimePicker.Value = skipassAGiornata.DataFine;
                }
                else
                {
                    SkiPassAdAccesso skipassAdAccesso = (SkiPassAdAccesso)skipass;
                    numeroAccessiTextBox.Text = skipassAdAccesso.NumeroAccessi.ToString();
                    skipassAdAccessoDataInizioTimePicker.Value = skipassAdAccesso.DataRilascio;
                }
            }
        }


        private void tipologiaSkipassComboBox_SelectedIndexChanged(object sender, EventArgs e) //switch pannello by skipass
        {
            if (tipologiaSkipassComboBox.SelectedIndex == TIPO_SKIPASS_A_GIORNATA_INDEX)
                tipoSkipassTabControl.SelectedTab = skipassAGiornataTabPage;
            else 
                tipoSkipassTabControl.SelectedTab = skipassAdAccessoTabPage;
        }

        private void skipassAGiornataDataInizioTimePicker_ValueChanged(object sender, EventArgs e) //correzione date selezionabili
        {
            skipassAGiornataDataFineTimePicker.MinDate = skipassAGiornataDataInizioTimePicker.Value;
        }
        
        private void perNomeRadioButton_CheckedChanged(object sender, EventArgs e)          //Switch filtro panel
        {
            tipoFiltroTabControl.SelectedTab = filtroPerNomeTabPage;
        }

        private void prezzoMassimoRadioButton_CheckedChanged(object sender, EventArgs e)    //Switch filtro panel
        {
            tipoFiltroTabControl.SelectedTab = filtroPerPrezzoTabPage;
        }

        private void nPisteDiTipoRadioButton_CheckedChanged(object sender, EventArgs e)     //Switch filtro panel
        {
            tipoFiltroTabControl.SelectedTab = filtroPerTipoPisteTabPage;
        }

        private void caratteristicaSpecificaRadioButton_CheckedChanged(object sender, EventArgs e) //Switch filtro panel
        {
            tipoFiltroTabControl.SelectedTab = filtroPerCaratteristicaTabPage;
        }

        private void caratteristicaSpecificaFiltroComboBox_SelectedIndexChanged(object sender, EventArgs e) //svuotamento campo di testo
        {
            caratteristicaSpecificaAlmenoFiltroTextBox.Clear();
        }


        private void AggiungiSkipassButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Recupero i campi
                string codiceSkipass = codiceSkipassTextBox.Text;

                if (tipologiaSkipassComboBox.SelectedIndex == TIPO_SKIPASS_A_GIORNATA_INDEX)//skipass a giornata
                {
                    DateTime datainizio = skipassAGiornataDataInizioTimePicker.Value;
                    DateTime datafine = skipassAGiornataDataFineTimePicker.Value;

                    if (inEditingMode)
                    {
                        SkiPassAGiornata skipassModificato = (SkiPassAGiornata)skipass;
                        Impianto impiantoScelto = recuperaImpianto();

                        skipassModificato.DataInizio = datainizio;
                        skipassModificato.DataFine = datafine;
                        skipassModificato.Impianto = impiantoScelto;
                    }
                    else
                    {
                        Impianto impiantoScelto = recuperaImpianto();
                        SkiPassAGiornata nuovoSkipass = new SkiPassAGiornata(codiceSkipass, impiantoScelto, datainizio, datafine);
                        skicard.Add(nuovoSkipass);
                    }
                }
                else // skipass ad accesso
                {
                    DateTime dataRilascio = skipassAdAccessoDataInizioTimePicker.Value;

                    if (numeroAccessiTextBox.Text != "")
                    {
                        int numeroAccessi = int.Parse(numeroAccessiTextBox.Text);

                        if (inEditingMode)
                        {
                            SkiPassAdAccesso skipassModificato = (SkiPassAdAccesso)skipass;
                            Impianto impiantoScelto = recuperaImpianto();

                            skipassModificato.DataRilascio = dataRilascio;
                            skipassModificato.NumeroAccessi = numeroAccessi;
                            skipassModificato.Impianto = impiantoScelto;
                        }
                        else
                        {
                            Impianto impiantoScelto = recuperaImpianto();
                            SkiPassAdAccesso nuovoSkipass = new SkiPassAdAccesso(codiceSkipass, impiantoScelto, numeroAccessi, dataRilascio);
                            skicard.Add(nuovoSkipass);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Riempire tutti i campi");
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Inserire un numero di accessi valido!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void visualizzaDettagliImpiantoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Impianto i = resortController.GetImpiantoByCodice(impiantiDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                VisualizzaImpianto visualizzaForm = new VisualizzaImpianto(i);
                visualizzaForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
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

        #endregion

        //Filtri

        #region MetodiFiltri

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
                MessageBox.Show("Inserisci il nome di impianto per continuare!");
            }
        }

        private void FiltraPerPrezzo()
        {
            if (prezzoMassimoFiltroTextBox.Text != "")
            {
                try
                {
                    double prezzoCercato = double.Parse(prezzoMassimoFiltroTextBox.Text);
                    if (tipologiaSkipassComboBox.SelectedIndex == TIPO_SKIPASS_A_GIORNATA_INDEX)
                    {
                        if (skipassAGiornataDataInizioTimePicker.Value < skipassAGiornataDataFineTimePicker.Value)
                        {
                            DateTime datainizio = skipassAGiornataDataInizioTimePicker.Value;
                            DateTime datafine = skipassAGiornataDataFineTimePicker.Value;
                            IFiltra filtraPerPrezzoAGioranta = new FiltraPerPrezzoGiornata(prezzoCercato, datainizio, datafine);
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
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Inserisci un prezzo massimo per continuare!");
            }
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
                MessageBox.Show("Inserisci il numero di piste minimo per continuare!");
            }
        }

        private void FiltraPerCaratteristicaSpecifica()
        {
            if (caratteristicaSpecificaAlmenoFiltroTextBox.Text != "")
            {
                if (caratteristicaSpecificaFiltroComboBox.SelectedIndex == CARATT_SPECIF_DIFFICOLTA_FILTRO_INDEX)//difficolta
                {
                    FiltraPistePerDifficolta();
                }
                else if (caratteristicaSpecificaFiltroComboBox.SelectedIndex == CARATT_SPECIF_DISL_MAX_FILTRO_INDEX)//dislivello max
                {
                    FiltraPistePerDislivelloMax();
                }
                else if (caratteristicaSpecificaFiltroComboBox.SelectedIndex == CARATT_SPECIF_DISL_MED_FILTRO_INDEX)//dislivello medio
                {
                    FiltraPistePerDislivelloMedio();
                }
                else if (caratteristicaSpecificaFiltroComboBox.SelectedIndex == CARATT_SPECIF_NUM_SALTI_FILTRO_INDEX)//numero salti
                {
                    FiltraPistePerNumSalti();
                }
                else if (caratteristicaSpecificaFiltroComboBox.SelectedIndex == CARATT_SPECIF_NUM_JIBS_FILTRO_INDEX)//numero jibs
                {
                    FiltraPistePerNumJibs();
                }
            }
            else
            {
                MessageBox.Show("Completa il campo nome per continuare");
            }
        }

        private void FiltraPistePerDifficolta()
        {
            if (isDifficoltàValid(caratteristicaSpecificaAlmenoFiltroTextBox.Text))
            {
                Difficolta difficoltaCercata = (Difficolta)Enum.Parse((typeof(Difficolta)), getDifficoltàGiustaByString(caratteristicaSpecificaAlmenoFiltroTextBox.Text));
                IFiltra filtroDifficoltà = new FiltraPerDifficolta(difficoltaCercata);
                resortController.Filtro = filtroDifficoltà;
                Impianti impiantiCercati = resortController.Filtra(resortController.GetImpianti());
                RiempiImpiantiGrid(impiantiCercati);
            }
            else
            {
                MessageBox.Show("Difficoltà non valida, Valori ammessi (Alta, Media, Bassa)");
            }
        }

        private void FiltraPistePerDislivelloMax()
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

        private void FiltraPistePerDislivelloMedio()
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

        private void FiltraPistePerNumSalti()
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

        private void FiltraPistePerNumJibs()
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

        #endregion

        //Private Utility Methods
        
        private void RiempiComdoBoxForm()  //riempio le combo box di tutti i pannelli filtra
        {
            tipologiaSkipassComboBox.Items.Insert(TIPO_SKIPASS_A_GIORNATA_INDEX, "SkiPass A Giornata");
            tipologiaSkipassComboBox.Items.Insert(TIPO_SKIPASS_AD_ACCESSO_INDEX, "SkiPass Ad Accesso");

            tipologiaSkipassComboBox.SelectedIndex = TIPO_SKIPASS_A_GIORNATA_INDEX;


            tipologiaPistaFiltroComboBox.Items.Insert(TIPO_PISTA_TUTTE_FILTRO_INDEX, "Tutte");
            tipologiaPistaFiltroComboBox.Items.Insert(TIPO_PISTA_ALPINA_FILTRO_INDEX, "Alpina");
            tipologiaPistaFiltroComboBox.Items.Insert(TIPO_PISTA_FONDO_FILTRO_INDEX, "Fondo");
            tipologiaPistaFiltroComboBox.Items.Insert(TIPO_PISTA_SNOWPARK_FILTRO_INDEX, "SnowPark");

            tipologiaPistaFiltroComboBox.SelectedIndex = TIPO_PISTA_TUTTE_FILTRO_INDEX;


            caratteristicaSpecificaFiltroComboBox.Items.Insert(CARATT_SPECIF_DIFFICOLTA_FILTRO_INDEX, "Difficoltà");
            caratteristicaSpecificaFiltroComboBox.Items.Insert(CARATT_SPECIF_DISL_MAX_FILTRO_INDEX, "Dislivello Massimo");
            caratteristicaSpecificaFiltroComboBox.Items.Insert(CARATT_SPECIF_DISL_MED_FILTRO_INDEX, "Dislivello Medio");
            caratteristicaSpecificaFiltroComboBox.Items.Insert(CARATT_SPECIF_NUM_SALTI_FILTRO_INDEX, "Numero Salti");
            caratteristicaSpecificaFiltroComboBox.Items.Insert(CARATT_SPECIF_NUM_JIBS_FILTRO_INDEX, "Numero Jibs");

            caratteristicaSpecificaFiltroComboBox.SelectedIndex = CARATT_SPECIF_DIFFICOLTA_FILTRO_INDEX;
        }

        private void RiempiImpiantiGrid(Impianti impianti)
        {
            impiantiDataGridView.Rows.Clear();
            foreach (Impianto i in impianti.ListaImpianti)
            {
                if(HavePrezzo(i))
                    impiantiDataGridView.Rows.Add(i.Codice, i.Nome, i.Versante, i.GetPisteAlpine().Count, i.GetPisteFondo().Count, i.GetPisteSnowPark().Count);
            }
        }

        private bool HavePrezzo(Impianto i)
        {
            foreach(ProfiloPrezziRisorse p in GSS.GetInstance().ProfiliPrezziRisorse.Profili)
            {
                if (p.GetPrezziRisorsa(i) == null)
                    return false;
            }
            return true;
        }

        private void SetRangeDate()
        {
            skipassAGiornataDataInizioTimePicker.MinDate = (resortController.Gss.Resort.DataInizioStagione > DateTime.Today.Date) ? resortController.Gss.Resort.DataInizioStagione : DateTime.Today.Date;
            skipassAGiornataDataInizioTimePicker.MaxDate = prenotazioneController.Gss.Resort.DataFineStagione;

            skipassAGiornataDataFineTimePicker.MinDate = skipassAGiornataDataInizioTimePicker.MinDate;
            skipassAGiornataDataFineTimePicker.MaxDate = prenotazioneController.Gss.Resort.DataFineStagione;

            skipassAdAccessoDataInizioTimePicker.MinDate = (resortController.Gss.Resort.DataInizioStagione > DateTime.Today.Date) ? resortController.Gss.Resort.DataInizioStagione : DateTime.Today.Date;
            skipassAdAccessoDataInizioTimePicker.MaxDate = prenotazioneController.Gss.Resort.DataFineStagione;
        }

        private Impianto recuperaImpianto()
        {
            return resortController.GetImpiantoByCodice(impiantiDataGridView.SelectedRows[0].Cells[0].Value.ToString());
        }
        
        private bool isDifficoltàValid(string difficolta)
        {
            if ((   difficolta.Equals(difficoltaBassa, StringComparison.InvariantCultureIgnoreCase))
                || (difficolta.Equals(difficoltaAlta,  StringComparison.InvariantCultureIgnoreCase))
                || (difficolta.Equals(difficoltaMedia, StringComparison.InvariantCultureIgnoreCase)))
            {
                return true;
            }
            return false;
        }
               
        private string GetTipologiaBySkipass(SkiPass skipass) //restituisce la stringa corrispondente al tipo di skipass
        {
            if (skipass is SkiPassAGiornata)
                return "SkiPass A Giornata";

            if (skipass is SkiPassAdAccesso)
                return "SkiPass Ad Accesso";

            return "";
        }
 
        private string getDifficoltàGiustaByString(string difficolta) //Metodo per farmi restituire bene le stringhe per costruirmi l'enumerativo esatto
        {
            if (difficolta.Equals(difficoltaBassa, StringComparison.InvariantCultureIgnoreCase))
                return difficoltaBassa;

            if (difficolta.Equals(difficoltaAlta,  StringComparison.InvariantCultureIgnoreCase))
                return difficoltaAlta;

            if (difficolta.Equals(difficoltaMedia, StringComparison.InvariantCultureIgnoreCase))
                return difficoltaMedia;

            return "";
        }

    }
}

