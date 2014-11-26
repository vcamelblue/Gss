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
            foreach (Impianto i in resortController.GetImpianti().ListaImpianti)
            {
                if (i.Codice==impiantiDataGridView.SelectedRows[0].Cells[0].Value)
                {
                    VisualizzaImpianto visualizzaImpiantoForm = new VisualizzaImpianto(i);
                    visualizzaImpiantoForm.Show();
                }
            }
            
        }

        private void rimuoviImpiantoButton_Click(object sender, EventArgs e)
        {
            foreach (Impianto i in resortController.GetImpianti().ListaImpianti)
            {
                if (i.Codice == impiantiDataGridView.SelectedRows[0].Cells[0].Value)
                {
                    DialogResult result = MessageBox.Show("Sicuro di voler rimuovere l'impianto selezionato?", "Rimozione Pista", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        resortController.RemoveImpianto(i);
                        Refresh();
                        break;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
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
            foreach (Impianto i in resortController.GetImpianti().ListaImpianti)
            {
                if (i.Codice == impiantiDataGridView.SelectedRows[0].Cells[0].Value)
                {
                    Impianto impiantoCopia = (Impianto)i.Clone();
                    AggiungiModificaImpianto modificaImpianto = new AggiungiModificaImpianto(resortController, impiantoCopia);

                    DialogResult res = modificaImpianto.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        resortController.EditImpianto(i, impiantoCopia);
                        Refresh();
                        break;
                    }
                }
            }
        }
        
        public override void Refresh()
        {
            base.Refresh();
            impiantiDataGridView.Rows.Clear();
            RiempiDataGrid();
        }
        
        private void RiempiDataGrid()
        {
            foreach (Impianto i in resortController.GetImpianti().ListaImpianti)
            {
                impiantiDataGridView.Rows.Add(i.Codice, i.Nome, i.Versante, i.GetPisteAlpine().Count, i.GetPisteFondo().Count, i.GetPisteSnowPark().Count);
            }
        }
    }
}
