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
        private PeriodiProfiliController periodiProfiliController;
        private bool inEditingMode;
        private Periodo periodo;
        private List<Periodo> periodi;

        public AggiungiModificaPeriodo(PeriodiProfiliController periodiProfiliController,List<Periodo> periodi) 
        {
            this.periodiProfiliController = periodiProfiliController;
            inEditingMode = false;
            periodo = null;
            this.periodi = periodi;

            InitializeComponent();
        }

        public AggiungiModificaPeriodo(PeriodiProfiliController periodiProfiliController,List<Periodo> periodi,Periodo periodo)
        {
            this.periodiProfiliController = periodiProfiliController;
            inEditingMode = true;
            this.periodo = periodo;
            this.periodi = periodi;

            InitializeComponent();
            salvaButton.Text = "Salva Modifiche";
            this.Text = "Modifica Periodo";
        }


        private void salvaButton_Click(object sender, EventArgs e) 
        {
            DateTime dataInizio = dataInizioTimePicker.Value;
            DateTime dataFine = dataFineTimePicker.Value;
            string nomeProfilo = profiloPeriodoComboBox.SelectedItem.ToString();
            ProfiloPrezziRisorse profiloScelto = periodiProfiliController.GetProfiloByNome(nomeProfilo);

            //AGGIUNGERE CONTROLLO CHE UN PERIODO AGGIUNTO/MODIFICATO NON SIA GIA PRESENTE!!! GRAVE ERRORE ALTRIMENTI!

            if (inEditingMode)
            {
                foreach (Periodo p in periodi)
                {
                    if (p.Equals(periodo))
                    {
                        p.DataInizio = dataInizio;
                        p.DataFine = dataFine;
                        p.Profilo = profiloScelto;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                Periodo periodo = new Periodo(dataInizio, dataFine, profiloScelto);
                periodi.Add(periodo);
                this.DialogResult = DialogResult.OK;
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

        private void RiempiProfiloComboBox()
        {
            dataFineTimePicker.MinDate = periodiProfiliController.Gss.Resort.DataInizioStagione;
            dataFineTimePicker.MaxDate = periodiProfiliController.Gss.Resort.DataFineStagione;
            dataInizioTimePicker.MinDate = periodiProfiliController.Gss.Resort.DataInizioStagione;
            dataInizioTimePicker.MaxDate = periodiProfiliController.Gss.Resort.DataFineStagione;

            foreach (ProfiloPrezziRisorse p in periodiProfiliController.GetProfili().Profili)
            {
                profiloPeriodoComboBox.Items.Add(p.Nome);
            }
            if (inEditingMode)
            {
                profiloPeriodoComboBox.SelectedIndex = profiloPeriodoComboBox.FindStringExact(periodo.Profilo.Nome);
                dataInizioTimePicker.Value = periodo.DataInizio;
                dataFineTimePicker.Value = periodo.DataFine;
            }
        }
    }
}
