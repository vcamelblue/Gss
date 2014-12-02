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
            dataFineStagioneTimePicker.Value = resortController.Gss.Resort.DataFineStagione;
            dataInizioStagioneTimePicker.Value = resortController.Gss.Resort.DataInizioStagione;
            RiempiBungalowGrid();
            RiempiImpiantiGrid();
        }

        private void RiempiImpiantiGrid()
        {
            int numImpianti = resortController.GetImpianti().ListaImpianti.Count;
            foreach (Impianto i in resortController.GetImpianti().ListaImpianti)
            {
                impiantiDataGridView.Rows.Add(" "+i.Codice+" - "+i.Nome+" - Versante: "+i.Versante);
            }
            totalePisteResortLabel.Text = "Piste Totali Resort  " + numImpianti;
        }

        private void RiempiBungalowGrid()
        {
            int numeroPosti = 0;
            foreach (Bungalow b in resortController.GetBungalows().ListaBungalow)
            {
                numeroPosti += b.PostiTotaliStandard();
                bungalowsDataGridView.Rows.Add(" " + b.Codice + " - Posti Standard: " + b.PostiTotaliStandard() + ",  Posti Max: "+ b.PostiTotaliMax());
            }
            totalePostiResortLabel.Text = "Posti Totali Resort  " + numeroPosti;
        }

        public override void Refresh()
        {
            base.Refresh();
            impiantiDataGridView.Rows.Clear();
            bungalowsDataGridView.Rows.Clear();
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
