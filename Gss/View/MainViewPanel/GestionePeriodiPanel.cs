using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Controller;
using Gss.Model;
using System.Windows.Forms;

namespace Gss.View.MainViewPanel
{
    public partial class GestionePeriodiPanel : System.Windows.Forms.UserControl
    {
        private PeriodiProfiliController periodiProfiliController;

        public GestionePeriodiPanel()
        {
            InitializeComponent();
        }

        public GestionePeriodiPanel(IContainer container,PeriodiProfiliController periodiProfiliController)
        {
            this.periodiProfiliController = periodiProfiliController;
            container.Add(this);

            InitializeComponent();
        }


        //Events

        private void impostaPeriodiButton_Click(object sender, EventArgs e)
        {
            AggiungiModificaPeriodi aggiungiPeriodiForm = new AggiungiModificaPeriodi(periodiProfiliController);

            DialogResult result = aggiungiPeriodiForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void modificaPeriodiButton_Click(object sender, EventArgs e)
        {
            AggiungiModificaPeriodi modificaPeriodiForm = new AggiungiModificaPeriodi(periodiProfiliController, periodiProfiliController.GetAllPeriodiClone());

            DialogResult result = modificaPeriodiForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void rimuoviTuttiIPeriodiButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sicuro di voler rimuovere Tutti i periodi?", "Rimozione Periodi", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                periodiProfiliController.RemoveAllPeriodi();
                Refresh();
            }
        }

        //Methods
        public override void Refresh()
        {
            base.Refresh();
            RiempiGrigliaPeriodi();
        }


        //Private Utility Methods

        private void RiempiGrigliaPeriodi()
        {
            periodiDataGridView.Rows.Clear();

            foreach (Periodo p in periodiProfiliController.GetAllPeriodi())
            {
                periodiDataGridView.Rows.Add(p.Profilo.Nome, p.DataInizio.ToString("d MMMM yyyy"), p.DataFine.ToString("d MMMM yyyy"));
            }
        }
    }
}
