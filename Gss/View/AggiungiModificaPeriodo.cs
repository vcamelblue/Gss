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
    public partial class AggiungiModificaPeriodo : Form 
    {

        //Fields

        private PeriodiProfiliController periodiProfiliController;
        private bool inEditingMode;
        private Periodo periodo;
        private List<Periodo> periodi;


        //Constructors

            //New Profilo Mode
        public AggiungiModificaPeriodo(PeriodiProfiliController periodiProfiliController,List<Periodo> periodi) 
        {
            this.periodiProfiliController = periodiProfiliController;
            this.inEditingMode = false;
            this.periodi = periodi;

            this.periodo = null;

            InitializeComponent();
        }

            //Editing Profilo Mode
        public AggiungiModificaPeriodo(PeriodiProfiliController periodiProfiliController,List<Periodo> periodi,Periodo periodo)
        {
            this.periodiProfiliController = periodiProfiliController;
            this.inEditingMode = true;
            this.periodo = periodo;
            this.periodi = periodi;

            InitializeComponent();

            salvaButton.Text = "Salva Modifiche";
            this.Text = "Modifica Periodo";
        }


        //Events

        private void salvaButton_Click(object sender, EventArgs e) 
        {
            try
            {
                DateTime dataInizio = dataInizioTimePicker.Value;
                DateTime dataFine = dataFineTimePicker.Value;

                string nomeProfilo = profiloPeriodoComboBox.SelectedItem.ToString();

                ProfiloPrezziRisorse profiloScelto = periodiProfiliController.GetProfiloPrezziRisorsaByNome(nomeProfilo);

                //AGGIUNGERE CONTROLLO CHE UN PERIODO AGGIUNTO/MODIFICATO NON SIA GIA PRESENTE!!! GRAVE ERRORE ALTRIMENTI!

                if (periodoConDataInizioGiaSettataInAltroPeriodo(profiloScelto, dataInizio))
                {
                    MessageBox.Show("Il periodo inserito contiene una Data Inizio già presente in un'altro periodo! Modifica i campi per continuare.");
                }
                else if (periodoGiaEsistente(profiloScelto, dataInizio, dataFine))
                {
                    MessageBox.Show("Il periodo inserito esiste già!\nModifica i campi per continuare.");
                }
                else
                {
                    if (inEditingMode)
                    {       
                            //testo se almeno qualcosa è cambiato
                        if (!(periodo.Profilo.Equals(profiloScelto) &&
                             periodo.DataInizio.Date == dataInizio.Date &&
                             periodo.DataFine.Date == dataFine.Date)) 
                        {
                            foreach (Periodo p in periodi)
                            {
                                if (p.Equals(periodo))
                                {
                                    p.DataInizio = dataInizio;
                                    p.DataFine = dataFine;
                                    p.Profilo = profiloScelto;

                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nessuna modifica apportata!");
                        }
                    }
                    else
                    {
                        Periodo periodo = new Periodo(dataInizio, dataFine, profiloScelto);
                        periodi.Add(periodo);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                
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

        private void AggiungiModificaPeriodo_Load(object sender, EventArgs e)
        {
            RiempiProfiloComboBox();
        }


        //Private Utility Methods

        private void RiempiProfiloComboBox()
        {
            dataFineTimePicker.MinDate = periodiProfiliController.Gss.Resort.DataInizioStagione;
            dataFineTimePicker.MaxDate = periodiProfiliController.Gss.Resort.DataFineStagione;
            dataInizioTimePicker.MinDate = periodiProfiliController.Gss.Resort.DataInizioStagione;
            dataInizioTimePicker.MaxDate = periodiProfiliController.Gss.Resort.DataFineStagione;

            foreach (ProfiloPrezziRisorse p in periodiProfiliController.GetAllProfili().Profili)
            {
                profiloPeriodoComboBox.Items.Add(p.Nome);
            }
            if (inEditingMode)
            {
                profiloPeriodoComboBox.SelectedIndex = profiloPeriodoComboBox.FindStringExact(periodo.Profilo.Nome);
                dataInizioTimePicker.Value = periodo.DataInizio;
                dataFineTimePicker.Value = periodo.DataFine;
            }
            else
            {
                profiloPeriodoComboBox.SelectedIndex = 0;
            }
        }


        private bool periodoGiaEsistente(ProfiloPrezziRisorse profiloScelto, DateTime dataInizio, DateTime dataFine)
        {
            foreach (Periodo p in periodi)
            {
                //escludo il periodo passato a questa form e testo sugli altri
                if (  periodo != null && !(p.Equals(periodo)) && p.Equals(new Periodo(dataInizio,dataFine,profiloScelto)))
                {
                    return true;
                }
            }
            return false;
        }

        private bool periodoConDataInizioGiaSettataInAltroPeriodo(ProfiloPrezziRisorse profiloScelto, DateTime dataInizio)
        {
            foreach (Periodo p in periodi)
            {
                //escludo il periodo passato a questa form e testo sugli altri
                if (periodo != null && !(p.Equals(periodo)) &&  p.DataInizio.Date == dataInizio.Date)
                {
                    return true;
                }
            }
            return false;
        }

        private void dataInizioTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dataFineTimePicker.MinDate = dataInizioTimePicker.Value;
        }
    }
}
