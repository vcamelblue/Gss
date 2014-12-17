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
    public partial class GestioneProfiliPanel : System.Windows.Forms.UserControl
    {
        private PeriodiProfiliController periodiProfiliController;
        private ResortController resortController;

        public GestioneProfiliPanel()
        {
            InitializeComponent();
        }

        public GestioneProfiliPanel(IContainer container,PeriodiProfiliController periodiProfiliController,ResortController resortController)
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
            profiliDataGridView.Rows.Clear();
            foreach (ProfiloPrezziRisorse p in periodiProfiliController.GetAllProfili().Profili)
            {
                profiliDataGridView.Rows.Add(p.Nome);
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            RiempiGridProfili();
        }

        private void visualizzaProfiloButton_Click(object sender, EventArgs e)
        {
            string nomeSelezionato = profiliDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            ProfiloPrezziRisorse profiloSelezionato = null;
            try
            {
                profiloSelezionato = periodiProfiliController.GetProfiloPrezziRisorsaByNome(nomeSelezionato);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            AggiungiModificaVisualizzaProfilo visualizzaProfiloForm = new AggiungiModificaVisualizzaProfilo(resortController, periodiProfiliController, profiloSelezionato, true);
            visualizzaProfiloForm.Show();
        }

        private void rimuoviProfiloButton_Click(object sender, EventArgs e)
        {
            string nomeSelezionato = profiliDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            ProfiloPrezziRisorse profiloSelezionato = null;
            try
            {
                profiloSelezionato = periodiProfiliController.GetProfiloPrezziRisorsaByNome(nomeSelezionato);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            DialogResult result = MessageBox.Show("Sicuro di voler rimuovere il profilo selezionato?", "Rimozione Profilo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                periodiProfiliController.RemoveProfilo(profiloSelezionato);
                Refresh();
            }
        }

        private void modificaProfiloButton_Click(object sender, EventArgs e)
        {
            string nomeSelezionato = profiliDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            ProfiloPrezziRisorse profiloSelezionato = null;
            try
            {
                profiloSelezionato = periodiProfiliController.GetProfiloPrezziRisorsaByNome(nomeSelezionato);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            AggiungiModificaVisualizzaProfilo modificaProfilo = new AggiungiModificaVisualizzaProfilo(resortController, periodiProfiliController, profiloSelezionato, false);

            DialogResult res = modificaProfilo.ShowDialog();
            if (res == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void aggiungiProfiloButton_Click(object sender, EventArgs e)
        {
            AggiungiModificaVisualizzaProfilo aggiungiProfilo = new AggiungiModificaVisualizzaProfilo(resortController, periodiProfiliController);

            DialogResult res = aggiungiProfilo.ShowDialog();
            if (res == DialogResult.OK)
            {
                Refresh();
            }
        }
    }
}
