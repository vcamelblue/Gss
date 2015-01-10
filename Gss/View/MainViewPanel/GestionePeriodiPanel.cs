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

            modificaPeriodiButton.Enabled = (periodiProfiliController.GetAllPeriodi().Count > 0);
            rimuoviTuttiIPeriodiButton.Enabled = (periodiProfiliController.GetAllPeriodi().Count > 0);
        }


        //Events

        private void impostaPeriodiButton_Click(object sender, EventArgs e)
        {
            if (!periodiProfiliController.IsStagioneIniziata())
            {
                AggiungiModificaPeriodi aggiungiPeriodiForm = new AggiungiModificaPeriodi(periodiProfiliController);

                DialogResult result = aggiungiPeriodiForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Refresh();
                }
            }
            else
            {
                MessageBox.Show("Impossibile impostare nuovi periodi, la stagione è già iniziata!");
            }
        }

        private void modificaPeriodiButton_Click(object sender, EventArgs e)
        {
            if (!periodiProfiliController.IsStagioneIniziata())
            {
                AggiungiModificaPeriodi modificaPeriodiForm = new AggiungiModificaPeriodi(periodiProfiliController, periodiProfiliController.GetCloneOfAllPeriodi());

                DialogResult result = modificaPeriodiForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Refresh();
                }
            }
            else
            {
                MessageBox.Show("Impossibile modificare i periodi, la stagione è già iniziata!");
            }
        }

        private void rimuoviTuttiIPeriodiButton_Click(object sender, EventArgs e)
        {
            if (!periodiProfiliController.IsStagioneIniziata())
            {
                DialogResult result = MessageBox.Show("Sicuro di voler rimuovere Tutti i periodi?", "Rimozione Periodi", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    periodiProfiliController.RemoveAllPeriodi();
                    Refresh();
                }
            }
            else
            {
                MessageBox.Show("Impossibile rimuovere i periodi, la stagione è già iniziata!");
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

            if (periodiProfiliController.GetAllPeriodi().Count > 0)
            {
                foreach (Periodo p in periodiProfiliController.GetAllPeriodi())
                {
                    periodiDataGridView.Rows.Add(p.Profilo.Nome, p.DataInizio.ToString("d MMMM yyyy"), p.DataFine.ToString("d MMMM yyyy"));
                }

                modificaPeriodiButton.Enabled = true;
                rimuoviTuttiIPeriodiButton.Enabled = true;
            }
            else
            {
                modificaPeriodiButton.Enabled = false;
                rimuoviTuttiIPeriodiButton.Enabled = false;
            }
        }
    }
}
