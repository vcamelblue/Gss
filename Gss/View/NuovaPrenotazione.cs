using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gss.Controller;
using Gss.Model;

namespace Gss.View 
{
    public partial class NuovaPrenotazione : Form 
	{
        private PrenotazioniController prenotazioniController;
        private ClientiController clientiController;
        private ResortController resortController;

        //Location del tasto annulla:
        //in tab clienti:  (290, 503)
        //Altrove:         (35, 503)

        public NuovaPrenotazione(PrenotazioniController prenotazioniController, ClientiController clientiController, ResortController resortController) 
		{
            this.prenotazioniController = prenotazioniController;
            this.clientiController = clientiController;
            this.resortController = resortController;

            InitializeComponent();
           
        }



        private void clienteTabButton_Click(object sender, EventArgs e)
        {
            tabControlWithoutHeader.SelectedIndex = (tabControlWithoutHeader.SelectedIndex + 1 < tabControlWithoutHeader.TabCount) ?
                             tabControlWithoutHeader.SelectedIndex + 1 : tabControlWithoutHeader.SelectedIndex;
        }

        private void NuovaPrenotazione_Load(object sender, EventArgs e)
        {
            RiempiListaClienti();
        }

        private void RiempiListaClienti()
        {
            clientiDataGridView.Rows.Clear();
            foreach (Cliente c in clientiController.GetAllClienti().ListaClienti)
            {
                clientiDataGridView.Rows.Add(c.Nome + "  "+ c.Cognome,c.CodiceFiscale);
            }
        }

        private void nuvoClienteButton_Click(object sender, EventArgs e)
        {
            AggiungiModificaCliente aggiungiClienteForm = new AggiungiModificaCliente(clientiController);
            DialogResult res = aggiungiClienteForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                RiempiListaClienti();
            }
        }

        private void clientiDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Cliente clienteSelezionato = clientiController.GetClienteByCF(clientiDataGridView.SelectedRows[0].Cells[1]);
            nomeClienteTextBox.Text = clienteSelezionato.Nome;
            cognomeClienteTextBox.Text = clienteSelezionato.Cognome;
            indirizzoClienteTextBox.Text = clienteSelezionato.Indirizzo;
            codiceFiscaleClienteTextBox.Text = clienteSelezionato.CodiceFiscale;
            dataNascitaTimePicker.Value = clienteSelezionato.DataNascita;
        }


    }
}
