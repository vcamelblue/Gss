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
        private PrenotazioneAttiva prenotazioneCorrente = null;

        private Button previusSelectedButton = null;
        private Color normalButtonColor = Color.FromKnownColor(KnownColor.LightGray);
        private Color selectedButtonColor = Color.FromArgb(54, 78, 102);
        private Color normalFontColor = Color.FromKnownColor(KnownColor.Black);
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
                //Recupero i campi per creare la prenotazione
                if (numeroPersoneTextBox.Text != "")
                {
                    try
                    {
                        int numeroPrenotazione = int.Parse(numeroPrenotazioneTextBox.Text);
                        int numeroPersone = int.Parse(numeroPersoneTextBox.Text);
                        Bungalow bungalowSelezionato = GetBungalowSelezionato();
                        prenotazioneCorrente = new PrenotazioneAttiva(numeroPrenotazione, numeroPersone, dataInizioPrenotazioneTimePicker.Value, dataFinePrenotazioneTimePicker.Value, clienteSelezionato);
                        prenotazioneCorrente.Bungalow = bungalowSelezionato;
                        tabControlWithoutHeader.SelectedTab = skicardsTabPage;
                        selectRightTab(skicardsTabButton);
                        RiempiGrigliaSkiCards();
                        if (prenotazioneCorrente.ListaSkiCards.ListaSkiCard.Count == 0)
                        {
                            modificaSkicardButton.Enabled = false;
                            rimuoviSkicardButton.Enabled = false;
                            duplicaSkicardButton.Enabled = false;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Inserire un numero di persone valido");
                    }
                }
                else
                {
                    MessageBox.Show("Completare tutti i campi");
                }
            }
            else if (tabControlWithoutHeader.SelectedTab == skicardsTabPage) // sono nella schermata skicards
            {
                tabControlWithoutHeader.SelectedTab = riepilogoTabPage;
                avantiConfermaButton.Text = "Conferma Prenotazione";
                selectRightTab(riepilogoTabButton);
                nomeCognomeClienteRiepilogoTextBox.Text = prenotazioneCorrente.Cliente.Nome + "  " + prenotazioneCorrente.Cliente.Cognome;
                dataInizioRiepilogoTimePicker.Value = prenotazioneCorrente.DataInizio;
                dataFineRiepilogoTimePicker.Value = prenotazioneCorrente.DataFine;
                numeroPrenotazioneRiepilogoTextBox.Text = prenotazioneCorrente.NumeroPrenotazione.ToString();
                numeroPersoneRiepilogoTextBox.Text = prenotazioneCorrente.NumeroPersone.ToString();
                codiceBungalowRiepilogoTextBox.Text = prenotazioneCorrente.Bungalow.Codice;
                numeroSkicardsCreateRiepilogoTextBox.Text = prenotazioneCorrente.ListaSkiCards.ListaSkiCard.Count.ToString();
                prezzoBungalowRiepilogoTextBox.Text = prenotazioneCorrente.GetSpesaBungalow() + " €";
                prezzpSkicardsRiepilogoTextBox.Text = prenotazioneCorrente.GetSpesaSkiCards() + " €";
                totaleRiepilogoTextBox.Text = prenotazioneCorrente.GetSpesaAttuale() + " €"; 
            }
            else // sono nella schermata riepilogo
            {
                try
                {
                    DialogResult result = MessageBox.Show("Sicuro di voler conferamre le prenotazione?", "Conferma Prenotazione", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        prenotazioniController.AddPrenotazione(prenotazioneCorrente);
                        this.Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            
        }

        private Bungalow GetBungalowSelezionato()
        {
            foreach (Bungalow b in resortController.GetBungalows().ListaBungalow)
            {
                if (b.Codice == bungalowDisponibiliDataGridView.SelectedRows[0].Cells[0].Value)
                {
                    return b;
                }
            }
            return null;
        }

        private void selectRightTab(Button newSelectedButton)
        {
            if (previusSelectedButton != null)
            {
                previusSelectedButton.BackColor = normalButtonColor;
                previusSelectedButton.ForeColor = normalFontColor;
                previusSelectedButton.FlatAppearance.MouseOverBackColor = normalButtonColor;
            }
            newSelectedButton.BackColor = selectedButtonColor;
            newSelectedButton.ForeColor = selectFontColor;
            newSelectedButton.FlatAppearance.MouseOverBackColor = selectedButtonColor;
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
                catch(FormatException) 
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
                double prezzoBungalow = prenotazioniController.GetSpesaBungalow(b,dataInizioPrenotazioneTimePicker.Value,dataFinePrenotazioneTimePicker.Value,numeroPersone);
                bungalowDisponibiliDataGridView.Rows.Add(b.Codice, b.GetNumeroStanze(), infoBungalow(b), b.PostiTotaliStandard(), b.PostiTotaliMax(), prezzoBungalow);
            }
            if (bungalowDisponibiliDataGridView.Rows.Count == 0)
            {
                avantiConfermaButton.Enabled = false;
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

        private void RiempiGrigliaSkiCards()
        {
            skicardsDataGridView.Rows.Clear();
            foreach(SkiCard s in prenotazioneCorrente.ListaSkiCards.ListaSkiCard)
            {
                skicardsDataGridView.Rows.Add(s.Codice, GetImpiantiBySkiCard(s), s.GetNumeroSkiPassAGiornata(), s.GetNumeroSkiPassAdAccesso(), s.GetPrezzoSkicard());
            }
            if (skicardsDataGridView.Rows.Count != 0)
            {
                modificaSkicardButton.Enabled = true;
                rimuoviSkicardButton.Enabled = true;
                duplicaSkicardButton.Enabled = true;
            }
        }

        private string GetImpiantiBySkiCard(SkiCard skicard)
        {
            string result = "";
            foreach (SkiPass s in skicard.SkiPass)
            {
                if (skicard.SkiPass.Last().Equals(s))
                {
                    result += s.Impianto.Nome;
                }
                else
                result += s.Impianto.Nome + ", ";
            }
            return result;
        }

        private void aggiungiSkicardButton_Click(object sender, EventArgs e)
        {
            AggiungiModificaSkicard aggiungiSkicardForm = new AggiungiModificaSkicard(prenotazioniController, resortController, prenotazioneCorrente.ListaSkiCards);

            DialogResult res = aggiungiSkicardForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                RiempiGrigliaSkiCards();
            }
        }

        private void modificaSkicardButton_Click(object sender, EventArgs e)
        {
            SkiCard skicardSelezionata = GetSkiCardSelezionata(skicardsDataGridView.SelectedRows[0].Cells[0].Value.ToString());

            AggiungiModificaSkicard modificaSkicardForm = new AggiungiModificaSkicard(prenotazioniController, resortController, prenotazioneCorrente.ListaSkiCards, skicardSelezionata);

            DialogResult res = modificaSkicardForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                RiempiGrigliaSkiCards();
            }
        }

        private void rimuoviSkicardButton_Click(object sender, EventArgs e)
        {
            SkiCard skicardSelezionata = GetSkiCardSelezionata(skicardsDataGridView.SelectedRows[0].Cells[0].Value.ToString());

            DialogResult result = MessageBox.Show("Sicuro di voler rimuovere la SkiCard selezionata?", "Rimozione SkiCard", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                prenotazioneCorrente.RemoveSkiCard(skicardSelezionata);
            }
            RiempiGrigliaSkiCards();
        }

        private void duplicaSkicardButton_Click(object sender, EventArgs e)
        {
            SkiCard skicardSelezionata = GetSkiCardSelezionata(skicardsDataGridView.SelectedRows[0].Cells[0].Value.ToString());

            DialogResult result = MessageBox.Show("Sicuro di voler duplicare la SkiCard selezionata?", "Duplicazione SkiCard", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string codiceSkicard = prenotazioniController.Gss.NumeroSkiCards.ToString();
                SkiCard skiCard = new SkiCard(codiceSkicard);
                foreach (SkiPass s in skicardSelezionata.SkiPass)
                {
                    if (s is SkiPassAdAccesso)
                    {
                        SkiPassAdAccesso skipassDaCopiare = (SkiPassAdAccesso)s;
                        //Creo la copia dello skipass
                        SkiPassAdAccesso skipassCopiato = new SkiPassAdAccesso(resortController.Gss.NumeroSkiPass.ToString(), skipassDaCopiare.Impianto, skipassDaCopiare.NAccessi, skipassDaCopiare.DataRilascio);
                        //Aggiungo la copia 
                        skiCard.Add(skipassCopiato);
                    }
                    else
                    {
                        SkiPassAGiornata skipassDaCopiare = (SkiPassAGiornata)s;
                        //Creo la copia dello skipass
                        SkiPassAGiornata skipassCopiato = new SkiPassAGiornata(resortController.Gss.NumeroSkiPass.ToString(), skipassDaCopiare.Impianto, skipassDaCopiare.DataInizio, skipassDaCopiare.DataFine);
                        //Aggiungo la copia
                        skiCard.Add(skipassCopiato);
                    }
                }
                //Aggiungo la skicard copiata alla prenotazione
                prenotazioneCorrente.AddSkiCard(skiCard);
                RiempiGrigliaSkiCards();
            }
        }

        private SkiCard GetSkiCardSelezionata(string codice)
        {
            foreach (SkiCard s in prenotazioneCorrente.ListaSkiCards.ListaSkiCard)
            {
                if (s.Codice == codice)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
