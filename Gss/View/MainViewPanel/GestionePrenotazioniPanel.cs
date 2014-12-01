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

namespace Gss.View.MainViewPanel
{
    public partial class GestionePrenotazioniPanel : System.Windows.Forms.UserControl
    {
        private Button previusSelectedButton = null;
        private Color normalButtonColor = Color.FromKnownColor(KnownColor.LightGray);
        private Color selectedButtonColor = Color.FromArgb(54, 78, 102); //Color.FromKnownColor(KnownColor.MenuHighlight);
        private Color normalFontColor = Color.FromKnownColor(KnownColor.Black);
        private Color selectFontColor = Color.FromArgb(251, 251, 251);

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
            modificaPrenotazioneButton.Enabled = false;
            prenotazioniDataGridView.Rows.Clear();
        }

        private void prenotazioniInCorsoTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(prenotazioniInCorsoTabButton);
            modificaPrenotazioneButton.Enabled = false;
            archiviaRimuoviPrenotazioneButton.Enabled = false;
            prenotazioniDataGridView.Rows.Clear();
            RiempiGrigliaPrenotazioniInCorso();
        }

        private void prenotazioniFutureTabButton_Click(object sender, EventArgs e)
        {
            selectRightTab(prenotazioniFutureTabButton);
            archiviaRimuoviPrenotazioneButton.Enabled = false;
            prenotazioniDataGridView.Rows.Clear();
            RiempiGrigliaPrenotazioniFuture();
        }

        private void RiempiGrigliaPrenotazioniFuture()
        {
            foreach (Prenotazione p in prenotazioniController.GetPrenotazioniFuture().ListaPrenotazioni)
            {
                prenotazioniDataGridView.Rows.Add(p.NumeroPrenotazione, p.DataInizio.ToString("d MMMM yyyy"), p.DataFine.ToString("d MMMM yyyy"), p.Cliente.Nome + "  " + p.Cliente.Cognome);
            }
        }

        private void RiempiGrigliaPrenotazioniInCorso()
        {
            foreach (Prenotazione p in prenotazioniController.GetPrenotazioniInCorsoOggi().ListaPrenotazioni)
            {
                prenotazioniDataGridView.Rows.Add(p.NumeroPrenotazione, p.DataInizio.ToString("d MMMM yyyy"), p.DataFine.ToString("d MMMM yyyy"), p.Cliente.Nome + "  " + p.Cliente.Cognome);
            }
        }

        private void RiempiGrigliaPrenotazioniConcluse()
        {
            foreach (Prenotazione p in prenotazioniController.GetPrenotazioniConcluseNonArchiviate().ListaPrenotazioni)
            {
                prenotazioniDataGridView.Rows.Add(p.NumeroPrenotazione, p.DataInizio.ToString("d MMMM yyyy"), p.DataFine.ToString("d MMMM yyyy"), p.Cliente.Nome + "  " + p.Cliente.Cognome);
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
            RiempiGrigliaPrenotazioniInCorso();
        }

        public override void Refresh()
        {
            base.Refresh();
            prenotazioniDataGridView.Rows.Clear();
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

        }
    }
}
