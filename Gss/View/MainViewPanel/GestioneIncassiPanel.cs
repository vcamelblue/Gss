using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Controller;
using Gss.Model;
using System.Windows.Forms;

namespace Gss.View.MainViewPanel
{

    public partial class GestioneIncassiPanel : System.Windows.Forms.UserControl
    {
        private PrenotazioniController prenotazioniController;

        public GestioneIncassiPanel()
        {
            InitializeComponent();
        }

        public GestioneIncassiPanel(IContainer container, PrenotazioniController prenotazioniController)
        {
            this.prenotazioniController = prenotazioniController;
            container.Add(this);

            InitializeComponent();
        }

        private void GestioneIncassiPanel_Load(object sender, EventArgs e)
        {
            RiempiIncassiGrid();
        }

        private void RiempiIncassiGrid()
        {
            incassiDataGridView.Rows.Clear();
            foreach(PrenotazioneArchiviata p in prenotazioniController.GetPrenotazioniArchiviate())
            {
                incassiDataGridView.Rows.Add(p.Fattura.Numero, p.Fattura.DataFattura.ToString("d MMMM yyyy"), p.Cliente.Nome + "  " + p.Cliente.Cognome, p.Fattura.TotaleFattura + " €");
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            RiempiIncassiGrid();
        }

        private void visualizzaFatturaButton_Click(object sender, EventArgs e)
        {
            string fatturaSelezionata = incassiDataGridView.SelectedRows[0].Cells[0].Value.ToString();

            PrenotazioneArchiviata prenotazioneSelezionata = null;
            foreach (PrenotazioneArchiviata p in prenotazioniController.GetPrenotazioniArchiviate())
            {
                if (p.Fattura.Numero.ToString() == fatturaSelezionata)
                {
                    prenotazioneSelezionata = p;
                }
            }

            VisualizzaFattura visualizzaFatturaForm = new VisualizzaFattura(prenotazioneSelezionata);
            visualizzaFatturaForm.Show();
        }
    }
}
