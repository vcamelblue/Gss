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
    public partial class GestioneImpianti : Form 
    {
        private ResortController resortController;

        public GestioneImpianti(ResortController resortController) 
        {
            this.resortController = resortController;

            InitializeComponent();
        }

        private void GestioneImpianti_Load(object sender, EventArgs e)
        {
            RiempiDataGrid();
        }

        private void visualizzaImpiantoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Impianto impiantoToShow = resortController.GetImpiantoByCodice(impiantiDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                VisualizzaImpianto visualizzaImpiantoForm = new VisualizzaImpianto(impiantoToShow);
                visualizzaImpiantoForm.Show();            
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void rimuoviImpiantoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Impianto impiantoToRemove = resortController.GetImpiantoByCodice(impiantiDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            
                DialogResult result = MessageBox.Show("Sicuro di voler rimuovere l'impianto selezionato?", "Rimozione Pista", MessageBoxButtons.OKCancel);
            
                if (result == DialogResult.OK)
                {
                    resortController.RemoveImpianto(impiantoToRemove);
                    Refresh();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AggiungiImpiantoButton_Click(object sender, EventArgs e)
        {
            AggiungiModificaImpianto aggiungiImpiantoForm = new AggiungiModificaImpianto(resortController);
           
            DialogResult res = aggiungiImpiantoForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void modificaImpiantoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Impianto impiantoToEdit = resortController.GetImpiantoByCodice(impiantiDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            
                Impianto impiantoCopia = (Impianto)impiantoToEdit.Clone();
            
                AggiungiModificaImpianto modificaImpianto = new AggiungiModificaImpianto(resortController, impiantoCopia);

                DialogResult res = modificaImpianto.ShowDialog();
                if (res == DialogResult.OK)
                {
                    resortController.EditImpianto(impiantoToEdit, impiantoCopia);
                    Refresh();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        
        public override void Refresh()
        {
            base.Refresh();
            RiempiDataGrid();
        }
        
        private void RiempiDataGrid()
        {
            impiantiDataGridView.Rows.Clear();
            foreach (Impianto i in resortController.GetImpianti().ListaImpianti)
            {
                impiantiDataGridView.Rows.Add(i.Codice, i.Nome, i.Versante, i.GetPisteAlpine().Count, i.GetPisteFondo().Count, i.GetPisteSnowPark().Count);
            }
            if (impiantiDataGridView.Rows.Count == 0)
            {
                rimuoviImpiantoButton.Enabled = false;
                modificaImpiantoButton.Enabled = false;
                visualizzaImpiantoButton.Enabled = false;
            }
            else
            {
                rimuoviImpiantoButton.Enabled = true;
                modificaImpiantoButton.Enabled = true;
                visualizzaImpiantoButton.Enabled = false;
            }
        }
    }
}
