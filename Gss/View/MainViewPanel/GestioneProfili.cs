using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gss.Model;
using Gss.Controller;

namespace Gss.View.MainViewPanel
{
    public partial class GestioneProfili : System.Windows.Forms.UserControl
    {
        private PeriodiProfiliController periodiProfiliController;
        private ResortController resortController;

        public GestioneProfili()
        {
            InitializeComponent();
        }

        public GestioneProfili(IContainer container,PeriodiProfiliController periodiProfiliController,ResortController resortController)
        {
            this.resortController = resortController;
            this.periodiProfiliController = periodiProfiliController;
            container.Add(this);

            InitializeComponent();

        }

        private void GestioneProfili_Load(object sender, EventArgs e)
        {
            RiempiGridProfili();
        }

        private void RiempiGridProfili()
        {
            foreach (ProfiloPrezziRisorse p in periodiProfiliController.GetProfili().Profili)
            {
                profiliDataGridView.Rows.Add(p.Nome);
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            profiliDataGridView.Rows.Clear();
            RiempiGridProfili();
        }

        private void visualizzaProfiloButton_Click(object sender, EventArgs e)
        {
            string nomeSelezionato = profiliDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            ProfiloPrezziRisorse profiloSelezionato = periodiProfiliController.GetProfiloByNome(nomeSelezionato);
            AggiungiModificaVisualizzaProfilo visualizzaProfiloForm = new AggiungiModificaVisualizzaProfilo(resortController, periodiProfiliController, profiloSelezionato, true);
            visualizzaProfiloForm.Show();
        }

        private void rimuoviProfiloButton_Click(object sender, EventArgs e)
        {
            string nomeSelezionato = profiliDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            ProfiloPrezziRisorse profiloSelezionato = periodiProfiliController.GetProfiloByNome(nomeSelezionato);

            DialogResult result = MessageBox.Show("Sicuro di voler rimuovere il profilo selezionato?", "Rimozione Profilo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //periodiProfiliController
            }
        }
    }
}
