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
        private bool clearDataGridViewInCorso = false;  //evitare errori con le clear, con il combio delle selezioni
        private PrenotazioniController prenotazioniController;
        private ClientiController clientiController;
        private ResortController resortController;
        private Cliente clienteSelezionato = null;

        private Button previusSelectedButton = null;
        private Color normalButtonColor = Color.FromKnownColor(KnownColor.LightGray);
        private Color selectedButtonColor = Color.FromArgb(54, 78, 102);
        private Color normalFontColor = Color.FromArgb(86, 86, 86);
        private Color selectFontColor = Color.FromArgb(251,251,251);

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
            //Clienti tab
            RiempiListaClienti();

            //Prenotazione Tab
            dataInizioPrenotazioneTimePicker.MinDate = resortController.Gss.Resort.DataInizioStagione;
            dataInizioPrenotazioneTimePicker.MaxDate = resortController.Gss.Resort.DataFineStagione;
            dataFinePrenotazioneTimePicker.MaxDate = resortController.Gss.Resort.DataFineStagione;
            numeroPrenotazioneTextBox.Text = resortController.Gss.NumeroPrenotazioni.ToString();
            
            selectRightTab(clienteTabButton);
        }

        private void RiempiListaClienti()
        {
            clearDataGridViewInCorso = true;
            clientiDataGridView.Rows.Clear();
            clearDataGridViewInCorso = false;
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

        private void clientiDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (clearDataGridViewInCorso==false) 
            {
                Cliente clienteSelezionato = clientiController.GetClienteByCF(clientiDataGridView.SelectedRows[0].Cells[1].Value.ToString());
                nomeClienteTextBox.Text = clienteSelezionato.Nome;
                cognomeClienteTextBox.Text = clienteSelezionato.Cognome;
                indirizzoClienteTextBox.Text = clienteSelezionato.Indirizzo;
                codiceFiscaleClienteTextBox.Text = clienteSelezionato.CodiceFiscale;
                dataNascitaTimePicker.Value = clienteSelezionato.DataNascita;
                telefonoClienteTextBox.Text = clienteSelezionato.Telefono;
                emailClienteTextBox.Text = clienteSelezionato.Email;
            }   
        }

        private void avantiConfermaButton_Click(object sender, EventArgs e)
        {
            if (tabControlWithoutHeader.SelectedTab == clienteTabPage) // sono nella schermata cliente
            {
                clienteSelezionato = clientiController.GetClienteByCF(clientiDataGridView.SelectedRows[0].Cells[1].Value.ToString());
                tabControlWithoutHeader.SelectedTab = prenotazioneTabPage;
                annullaButton.Location = new Point(35,avantiConfermaButton.Location.Y);
                nuvoClienteButton.Visible = false;
                selectRightTab(prenotazioneTabButton);
            }
            else if (tabControlWithoutHeader.SelectedTab == prenotazioneTabPage) // sono nella schermata prenotazione
            {
                tabControlWithoutHeader.SelectedTab = skicardsTabPage;
                selectRightTab(skicardsTabButton);
            }
            else if (tabControlWithoutHeader.SelectedTab == skicardsTabPage) // sono nella schermata skicards
            {
                tabControlWithoutHeader.SelectedTab = riepilogoTabPage;
                avantiConfermaButton.Text = "Conferma Prenotazione";
                selectRightTab(riepilogoTabButton);
            }
            else // sono nella schermata riepilogo
            {

            }
            
        }

        private void selectRightTab(Button newSelectedButton)
        {
            if (previusSelectedButton != null)
            {
                previusSelectedButton.BackColor = normalButtonColor;
                previusSelectedButton.ForeColor = normalFontColor;
            }
            newSelectedButton.BackColor = selectedButtonColor;
            newSelectedButton.ForeColor = selectFontColor;
            previusSelectedButton = newSelectedButton;
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataInizioPrenotazioneTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dataFinePrenotazioneTimePicker.MinDate = dataInizioPrenotazioneTimePicker.Value;
        }

        private void ricercaBungalowButton_Click(object sender, EventArgs e)
        {
            if(numeroPersoneTextBox.Text!="")
            {
                int numeroPersone = 0;
                try
                {
                    numeroPersone = int.Parse(numeroPersoneTextBox.Text);
                    if (numeroPersone != 0)
                    {
                        Bungalows bungalowsDisponibili = prenotazioniController.FindBungalowDisponibiliFor(dataInizioPrenotazioneTimePicker.Value, dataFinePrenotazioneTimePicker.Value, numeroPersone);
                        riempiListaBungalow(bungalowsDisponibili,numeroPersone);
                    }
                    else
                    {
                        MessageBox.Show("Inserire un numero di persone maggiori di zero");
                    }
                }
                catch(FormatException ) 
                {
                    MessageBox.Show("Inserire un numero di persone valido");
                }
            }
            else
            {
                MessageBox.Show("Completare tutti i campi");
            }
        }

        private void riempiListaBungalow(Bungalows bungalows,int numeroPersone)
        {
            bungalowDisponibiliDataGridView.Rows.Clear();
            foreach (Bungalow b in bungalows.ListaBungalow)
            {
                double prezzoBungalow = prenotazioniController.GetPrezzoBungalowPerPeriodo(dataInizioPrenotazioneTimePicker.Value,dataFinePrenotazioneTimePicker.Value,numeroPersone);
                bungalowDisponibiliDataGridView.Rows.Add(b.Codice, b.GetNumeroStanze(), infoBungalow(b), b.PostiTotaliStandard(), b.PostiTotaliMax(), );
            }
        }

        // Mi dice come sono le stanze del bungalow
        private string infoBungalow(Bungalow bungalow)
        {
            string result = "";
            foreach (Stanza s in bungalow.Stanze)
            {
                if (s.Equals(bungalow.Stanze[bungalow.Stanze.Count - 1]))
                {
                    result += TipoCameraByPosti(s) + " ";
                }
                else
                {
                    result += TipoCameraByPosti(s) + " + ";
                }
            }
            return result;
        }

        //Mi dice come è una stanza (singola, doppia, tripla)
        private string TipoCameraByPosti(Stanza stanza)
        {
            return (stanza.NumeroPostiStandard == 1 ? "Singola" :
                    stanza.NumeroPostiStandard == 2 ? "Doppia" :
                    stanza.NumeroPostiStandard == 3 ? "Tripla" :
                    stanza.NumeroPostiStandard == 4 ? "Quadrupla" :
                    stanza.NumeroPostiStandard == 5 ? "Quintupla" : "Nupla");
        }


    }
}
