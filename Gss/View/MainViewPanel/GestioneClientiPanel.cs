using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gss.Controller;
using Gss.Model;

namespace Gss.View.MainViewPanel
{
    public partial class GestioneClientiPanel : System.Windows.Forms.UserControl
    {
        private ClientiController clientiController;

        public GestioneClientiPanel()
        {
            InitializeComponent();
        }

        public GestioneClientiPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void GestioneClientiPanel_Load(object sender, EventArgs e)
        {
            RiempiClienteGrid();
        }

        private void RiempiClienteGrid()
        {
            foreach (Cliente c in clientiController.GetAllClienti().ListaClienti)
            {
                clientiDataGridView.Rows.Add(c.Nome, c.Cognome, c.CodiceFiscale, c.Telefono, c.Email);
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            clientiDataGridView.Rows.Clear();
            RiempiClienteGrid();
        }

        private Cliente IndividuaCliente()
        {
            string nome = clientiDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string cognome = clientiDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            string cf = clientiDataGridView.SelectedRows[0].Cells[2].Value.ToString();

            foreach (Cliente c in clientiController.GetAllClienti().ListaClienti)
            {
                if ((c.Nome == nome) && (c.Cognome == cognome) && (c.CodiceFiscale == cf))
                {
                    return c;
                }
            }
            return null;
        }

        private void aggiungiClienteButton_Click(object sender, EventArgs e)
        {
            AggiungiModificaCliente aggiungiClienteForm = new AggiungiModificaCliente(clientiController);

            DialogResult res = aggiungiClienteForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void modificaClienteButton_Click(object sender, EventArgs e)
        {
            Cliente clienteSelezionato = IndividuaCliente();

            AggiungiModificaCliente modificaClienteForm = new AggiungiModificaCliente(clientiController, clienteSelezionato,false);

            DialogResult res = modificaClienteForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void rimuoviClienteButton_Click(object sender, EventArgs e)
        {
            /*Cliente clienteSelezionato = IndividuaCliente();

            DialogResult res = MessageBox.Show("Sicuro di voler rimuovere la pista selezionata?", "Rimozione Pista", MessageBoxButtons.OKCancel);

            if (res == DialogResult.OK)
            {
                Refresh();
            }*/
        }

        private void visualizzaClienteButton_Click(object sender, EventArgs e)
        {
            Cliente clienteSelezionato = IndividuaCliente();

            AggiungiModificaCliente modificaClienteForm = new AggiungiModificaCliente(clientiController, clienteSelezionato,true);
        }


       


    }
}
