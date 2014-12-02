using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Controller;
using Gss.Model;

namespace Gss.View.MainViewPanel
{
    public partial class RiepilogoGiornalieroPanel : System.Windows.Forms.UserControl
    {
        private PrenotazioniController prenotazioniController;

        public RiepilogoGiornalieroPanel()
        {
            InitializeComponent();
        }

        public RiepilogoGiornalieroPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            
            clientiInArrivoOggiDataGridView.Rows.Add("Vincenzo Villani");
            clientiInArrivoOggiDataGridView.Rows.Add("Antonio Benincasa");
            clientiInArrivoOggiDataGridView.Rows.Add("Pasquale Presutti");
            clientiInArrivoOggiDataGridView.Rows.Add("Unnome Molto Lungo e Art.");

            clientiInPartenzaOggiDataGridView.Rows.Add("Niola Mignogna");
            clientiInPartenzaOggiDataGridView.Rows.Add("Anthony De Castro Braciola");

            prenotazioniDaSaldareOggiDataGridView.Rows.Add("231 - Nicola Mignogna");
             
        }

        public RiepilogoGiornalieroPanel(IContainer container, PrenotazioniController prenotazioniController)
        {
            this.prenotazioniController  = prenotazioniController;

            InitializeComponent();
        }

        private void RiempiDataGrids()
        {
            clientiInArrivoOggiDataGridView.Rows.Clear();
            clientiInPartenzaOggiDataGridView.Rows.Clear();
            prenotazioniDaSaldareOggiDataGridView.Rows.Clear();
            foreach(Prenotazione p in prenotazioniController.GetPrenotazioniConcluseOggi().ListaPrenotazioni)
            {
                clientiInPartenzaOggiDataGridView.Rows.Add(p.Cliente.Nome+"  "+p.Cliente.Cognome);
            }
            foreach(Prenotazione p in prenotazioniController.GetPrenotazioniIniziateOggi().ListaPrenotazioni)
            {
                clientiInArrivoOggiDataGridView.Rows.Add(p.Cliente.Nome+"  "+p.Cliente.Cognome);
            }
            foreach (Prenotazione p in prenotazioniController.GetPrenotazioniConcluseNonArchiviate().ListaPrenotazioni)
            {
                prenotazioniDaSaldareOggiDataGridView.Rows.Add(p.NumeroPrenotazione + " - " + p.Cliente.Nome + "  " + p.Cliente.Cognome);
            }
        }

        private void RiepilogoGiornalieroPanel_Load(object sender, EventArgs e)
        {
            RiempiDataGrids();
        }

        public override void Refresh()
        {
            base.Refresh();
            RiempiDataGrids();
        }

    }
}
