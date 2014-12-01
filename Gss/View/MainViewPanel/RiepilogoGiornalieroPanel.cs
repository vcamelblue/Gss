using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;
using Gss.Controller;

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
             
        }

        public override void Refresh()
        {
            base.Refresh();
            clientiInArrivoOggiDataGridView.Rows.Clear();
            clientiInPartenzaOggiDataGridView.Rows.Clear();
            prenotazioniDaSaldareOggiDataGridView.Rows.Clear();
            RiempiGrids();
        }
        private void RiepilogoGiornalieroPanel_Load(object sender, EventArgs e)
        {
            RiempiGrids();
        }

        private void RiempiGrids()
        {
            foreach (Prenotazione p in prenotazioniController.GetPrenotazioniIniziateOggi().ListaPrenotazioni)
            {
                clientiInArrivoOggiDataGridView.Rows.Add(p.Cliente.Nome);
            }
            foreach (Prenotazione p in prenotazioniController.GetPrenotazioniConcluseOggi().ListaPrenotazioni)
            {
                clientiInPartenzaOggiDataGridView.Rows.Add(p.Cliente.Nome);
            }
            foreach (Prenotazione p in prenotazioniController.GetPrenotazioniConcluseNonArchiviate().ListaPrenotazioni)
            {
                prenotazioniDaSaldareOggiDataGridView.Rows.Add(p.NumeroPrenotazione + " - " + p.Cliente.Nome);
            }
        }

    }
}
