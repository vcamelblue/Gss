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
    public partial class GestioneBungalows : Form 
    {
        private ResortController resortController;

        public GestioneBungalows(ResortController resortController) 
        {
            this.resortController = resortController;

            InitializeComponent();
        }

        private void GestioneBungalows_Load(object sender, EventArgs e)
        {
            foreach (Bungalow b in resortController.Gss.Resort.Bungalows.ListaBungalow)
            {
                bungalowDataGridView.Rows.Add(b.Codice, b.GetNumeroStanze(), b.ToStringStanze(), b.PostiTotaliStandard(), b.PostiTotaliMax());
            }

            //bungalowDataGridView.Rows[15].Selected = true;
            //bungalowDataGridView.FirstDisplayedScrollingRowIndex = 15;
        }

        public override void Refresh()
        {
            base.Refresh();
            bungalowDataGridView.Rows.Clear();
            RiempiGrid();
        }

        private void RiempiGrid()
        {
            foreach (Bungalow b in resortController.GetBungalows().ListaBungalow)
            {
                bungalowDataGridView.Rows.Add(b.Codice, b.GetNumeroStanze(), b.ToStringStanze(), b.PostiTotaliStandard(), b.PostiTotaliMax());
            }
        }

        private void rimuoviBungalowButton_Click(object sender, EventArgs e)
        {
            foreach (Bungalow b in resortController.GetBungalows().ListaBungalow)
            {
                if (b.Codice == bungalowDataGridView.SelectedRows[0].Cells[0].Value)
                {
                    DialogResult result = MessageBox.Show("Sicuro di voler rimuovere il bungalow selezionato?", "Rimozione Bungalow", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        resortController.RemoveBungalow(b);
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

        private void aggiungiBungalowButton_Click(object sender, EventArgs e)
        {
            AggiungiModificaBungalow aggiungiBungalowForm = new AggiungiModificaBungalow(resortController);

            DialogResult res = aggiungiBungalowForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void modificaBungalowButton_Click(object sender, EventArgs e)
        {
            foreach (Bungalow b in resortController.GetBungalows().ListaBungalow)
            {
                if (b.Codice == bungalowDataGridView.SelectedRows[0].Cells[0].Value)
                {
                    Bungalow bungalowCopia = (Bungalow)b.Clone();
                    AggiungiModificaBungalow modificaBungalow = new AggiungiModificaBungalow(resortController, bungalowCopia);

                    DialogResult res = modificaBungalow.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        resortController.EditBungalow(b, bungalowCopia);
                        Refresh();
                        break;
                    }
                }
            }
        }

    }
}
