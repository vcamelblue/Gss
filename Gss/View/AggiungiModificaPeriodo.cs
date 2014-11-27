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

            if (CheckData(dataInizio) && CheckData(dataFine))
            {
                if (inEditingMode)
                {
                    foreach(Periodo p in periodi)
                    {
                        if(p.Equals(periodo))
                        {
                            p.DataInizio = dataInizio;
                            p.DataFine = dataFine;
                            p.Profilo = profiloScelto;
                        }
                    }   
                }
                else
                {
                    Periodo periodo = new Periodo(dataInizio, dataFine, profiloScelto);
                    periodi.Add(periodo);
                }
            }
            else
            {
                MessageBox.Show("Inserisci date all'interno della sagione");
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

        private bool CheckData(DateTime data)
        {
            if((data >= periodiProfiliController.Gss.Resort.DataInizioStagione) && 
                (data <= periodiProfiliController.Gss.Resort.DataFineStagione))
            {
                return true;
            }

            return false;
        }

    }
}
