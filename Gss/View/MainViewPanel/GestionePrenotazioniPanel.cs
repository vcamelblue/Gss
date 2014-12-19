using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gss.Model;
using Gss.Controller;
using Gss.View.Utility;

namespace Gss.View.MainViewPanel
{
    public partial class GestionePrenotazioniPanel : System.Windows.Forms.UserControl
    {
        private Button previusSelectedButton = null;
        private Color normalButtonColor = ConfigAndUtility.normalButtonColor;
        private Color selectedButtonColor = ConfigAndUtility.selectedButtonColor;
        private Color normalFontColor = ConfigAndUtility.normalFontColor;
        private Color selectFontColor = ConfigAndUtility.selectFontColor;

        private ClientiController clientiController;
        private ResortController resortController;
        private PrenotazioniController prenotazioniController;

        public GestionePrenotazioniPanel()
        {
            InitializeComponent();
        }

        public GestionePrenotazioniPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public GestionePrenotazioniPanel(IContainer container, PrenotazioniController prenotazioniController, ClientiController clientiController, ResortController resortController)
        {
            this.clientiController = clientiController;
            this.resortController = resortController;
            this.prenotazioniController = prenotazioniController;

            container.Add(this);

            InitializeComponent();
        }

        private void prenotazioniConcluseTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(prenotazioniConcluseTabButton);
            RiempiGrigliaPrenotazioniConcluse();
        }

        private void prenotazioniInCorsoTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(prenotazioniInCorsoTabButton);
            RiempiGrigliaPrenotazioniInCorso();
        }

        private void prenotazioniFutureTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(prenotazioniFutureTabButton);
            RiempiGrigliaPrenotazioniFuture();
        }

        private void RiempiGrigliaPrenotazioniFuture()
        {
            prenotazioniDataGridView.Rows.Clear();
            foreach (Prenotazione p in prenotazioniController.GetPrenotazioniFuture().ListaPrenotazioni)
            {
                prenotazioniDataGridView.Rows.Add(p.NumeroPrenotazione, p.DataInizio.ToString("d MMMM yyyy"), p.DataFine.ToString("d MMMM yyyy"), p.Cliente.Nome + "  " + p.Cliente.Cognome);
            }
            if (prenotazioniController.GetPrenotazioniFuture().ListaPrenotazioni.Count == 0)
            {
                archiviaRimuoviPrenotazioneButton.Enabled = false;
            }
            else
            {
                archiviaRimuoviPrenotazioneButton.Text = "Elimina Prenotazione";
                archiviaRimuoviPrenotazioneButton.Enabled = true;
            }
        }

        private void RiempiGrigliaPrenotazioniInCorso()
        {
            prenotazioniDataGridView.Rows.Clear();
            foreach (Prenotazione p in prenotazioniController.GetPrenotazioniInCorsoOggi().ListaPrenotazioni)
            {
                prenotazioniDataGridView.Rows.Add(p.NumeroPrenotazione, p.DataInizio.ToString("d MMMM yyyy"), p.DataFine.ToString("d MMMM yyyy"), p.Cliente.Nome + "  " + p.Cliente.Cognome);
            }
        }

        private void RiempiGrigliaPrenotazioniConcluse()
        {
            prenotazioniDataGridView.Rows.Clear();
            foreach (Prenotazione p in prenotazioniController.GetPrenotazioniConcluseNonArchiviate().ListaPrenotazioni)
            {
                prenotazioniDataGridView.Rows.Add(p.NumeroPrenotazione, p.DataInizio.ToString("d MMMM yyyy"), p.DataFine.ToString("d MMMM yyyy"), p.Cliente.Nome + "  " + p.Cliente.Cognome);
            }
            if (prenotazioniController.GetPrenotazioniConcluseNonArchiviate().ListaPrenotazioni.Count == 0)
            {
                archiviaRimuoviPrenotazioneButton.Enabled = false;
            }
            else
            {
                archiviaRimuoviPrenotazioneButton.Text = "Archivia Prenotazione";
                archiviaRimuoviPrenotazioneButton.Enabled = true;
            }
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

        private void GestionePrenotazioniPanel_Load(object sender, EventArgs e)
        {
            selectRightTab(prenotazioniInCorsoTabButton);
            archiviaRimuoviPrenotazioneButton.Enabled = false;
            modificaPrenotazioneButton.Enabled = false;
            RiempiGrigliaPrenotazioniInCorso();
        }

        public override void Refresh()
        {
            base.Refresh();
            selectRightTab(prenotazioniInCorsoTabButton);
            RiempiGrigliaPrenotazioniInCorso();
        }

        private void nuovaPrenotazioneButton_Click(object sender, EventArgs e)
        {
            NuovaPrenotazione nuovaPrenotazione = new NuovaPrenotazione(prenotazioniController, clientiController, resortController);

            DialogResult res = nuovaPrenotazione.ShowDialog();
            if (res == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void archiviaRimuoviPrenotazioneButton_Click(object sender, EventArgs e)
        {   
            int numeroPrenotazioneSelezionata = int.Parse(prenotazioniDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            Prenotazione prenotazioneSelezionata = prenotazioniController.GetPrenotazioneByNumeroPrenotazione(numeroPrenotazioneSelezionata);
            if (previusSelectedButton.Equals(prenotazioniConcluseTabButton))
            {
                DialogResult result = MessageBox.Show("Sicuro di voler archiviare la prenotazione?", "Archviazione Prenotazione", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        prenotazioniController.ArchiviaPrenotazione((PrenotazioneAttiva)prenotazioneSelezionata);
                        VisualizzaFattura visualizzaFatt = new VisualizzaFattura((PrenotazioneArchiviata)prenotazioniController.GetPrenotazioneByNumeroPrenotazione(numeroPrenotazioneSelezionata));
                        visualizzaFatt.Show();
                        Refresh();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Sicuro di voler eliminare la prenotazione?", "Elimina Prenotazione", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        prenotazioniController.RemovePrenotazione(prenotazioneSelezionata);
                        Refresh();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
        }
    }
}
