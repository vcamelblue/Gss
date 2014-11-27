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

        public AggiungiModificaPeriodo(PeriodiProfiliController periodiProfiliController) 
        {
            this.periodiProfiliController = periodiProfiliController;
            inEditingMode = false;
            periodo = null;

            InitializeComponent();
        }

        public AggiungiModificaPeriodo(PeriodiProfiliController periodiProfiliController, Periodo periodo)
        {
            this.periodiProfiliController = periodiProfiliController;
            inEditingMode = true;
            this.periodo = periodo;

            InitializeComponent();
            salvaButton.Text = "Salva Modifiche";
            this.Text = "Modifica Periodo";
        }


        private void salvaButton_Click(object sender, EventArgs e) 
        {

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
            foreach (ProfiloPrezziRisorse p in periodiProfiliController.Gss.ProfiliPrezziRisorse.Profili)
            {
                profiloPeriodoComboBox.Items.Add(p.Nome);
            }
        }

    }
}
