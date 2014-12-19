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

        //DISABILITARE I PULSANTI SE LA GRIGLIA E' VUOTA

        public GestioneClientiPanel()
        {
            InitializeComponent();
        }

        public GestioneClientiPanel(IContainer container, ClientiController clientiController)
        {
            this.clientiController = clientiController;
            container.Add(this);

            InitializeComponent();
        }

        public GestioneClientiPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void GestioneClientiPanel_Load(object sender, EventArgs e)
        {
            RiempiGrigliaClienti();
        }

        private void RiempiGrigliaClienti()
        {
            clientiDataGridView.Rows.Clear();
            foreach (Cliente c in clientiController.GetAllClienti().ListaClienti)
            {
                clientiDataGridView.Rows.Add(c.Nome, c.Cognome, c.CodiceFiscale, c.Telefono, c.Email);
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            RiempiGrigliaClienti();
        }

        private void visualizzaClienteButton_Click(object sender, EventArgs e)
        {
            string codicefiscale = clientiDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Cliente clienteSelezionato = clientiController.GetClienteByCF(codicefiscale);

            AggiungiModificaCliente visualizzaClienteForm = new AggiungiModificaCliente(clientiController, clienteSelezionato, true);
            visualizzaClienteForm.Show();
        }

        private void rimuoviClienteButton_Click(object sender, EventArgs e)
        {
            string codicefiscale = clientiDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Cliente clienteSelezionato = clientiController.GetClienteByCF(codicefiscale);

            DialogResult res = MessageBox.Show("Sicuro di voler rimuovere il cliente selezionato?", "Rimozione Cliente", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                try
                {
                    clientiController.RemoveCliente(clienteSelezionato);
                    Refresh();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            
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
            string codicefiscale = clientiDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Cliente clienteSelezionato = clientiController.GetClienteByCF(codicefiscale);

            AggiungiModificaCliente modificaClienteForm = new AggiungiModificaCliente(clientiController, clienteSelezionato, false);

            DialogResult res = modificaClienteForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                Refresh();
            }
        }
        
    }
}
