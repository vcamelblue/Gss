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
    public partial class GestioneResortPanel : System.Windows.Forms.UserControl
    {
        private ResortController resortController;

        public GestioneResortPanel()
        {
            InitializeComponent();
        }

        public GestioneResortPanel(IContainer container, ResortController resortController)
        {
            this.resortController = resortController;
            container.Add(this);

            InitializeComponent();
        }

        private void GestioneResortPanel_Load(object sender, EventArgs e)
        {
            dataInizioStagioneTextBox.Text = resortController.Gss.Resort.isStagioneImpostata() ? resortController.Gss.Resort.DataInizioStagione.ToString("d MMMM yyyy") : "Non Impostata";
            dataFineStagioneTextBox.Text = resortController.Gss.Resort.isStagioneImpostata() ? resortController.Gss.Resort.DataFineStagione.ToString("d MMMM yyyy") : "Non Impostata";
            RiempiBungalowGrid();
            RiempiImpiantiGrid();
        }

        private void RiempiImpiantiGrid()
        {
            impiantiDataGridView.Rows.Clear();
            int numImpianti = resortController.GetImpianti().ListaImpianti.Count;
            foreach (Impianto i in resortController.GetImpianti().ListaImpianti)
            {
                impiantiDataGridView.Rows.Add(i.ToString());
            }
            totalePisteResortLabel.Text = "Piste Totali Resort  " + numImpianti;
        }

        private void RiempiBungalowGrid()
        {
            bungalowsDataGridView.Rows.Clear();
            int numeroPosti = 0;
            foreach (Bungalow b in resortController.GetBungalows().ListaBungalow)
            {
                numeroPosti += b.PostiTotaliStandard();
                bungalowsDataGridView.Rows.Add(b.ToString());
            }
            totalePostiResortLabel.Text = "Posti Totali Resort  " + numeroPosti;
        }

        public override void Refresh()
        {
            base.Refresh();
            dataInizioStagioneTextBox.Text = resortController.Gss.Resort.isStagioneImpostata() ? resortController.Gss.Resort.DataInizioStagione.ToString("d MMMM yyyy") : "Non Impostata";
            dataFineStagioneTextBox.Text = resortController.Gss.Resort.isStagioneImpostata() ? resortController.Gss.Resort.DataFineStagione.ToString("d MMMM yyyy") : "Non Impostata";
            RiempiImpiantiGrid();
            RiempiBungalowGrid();
        }

        private void gestioneBungalowsButton_Click(object sender, EventArgs e)
        {
            GestioneBungalows gestioneBungalowsForm = new GestioneBungalows(resortController);
            DialogResult res = gestioneBungalowsForm.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                Refresh();
            }
        }

        private void gestioneImpiantiButton_Click(object sender, EventArgs e)
        {
            GestioneImpianti gestioneImpiantiForm = new GestioneImpianti(resortController);
            DialogResult res = gestioneImpiantiForm.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                Refresh();
            }
        }

        private void gestioneInfoResortButton_Click(object sender, EventArgs e)
        {
            GestioneInformazioniResort gestioneInfoResort = new GestioneInformazioniResort(resortController,resortController.Gss.Resort);
            DialogResult res = gestioneInfoResort.ShowDialog();
            if (res == DialogResult.OK)
            {
                Refresh();
            }
        }
    }
}
