using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.View.MainViewPanel
{
    public partial class RiepilogoPanel : System.Windows.Forms.UserControl
    {
        public RiepilogoPanel()
        {
            InitializeComponent();
        }

        public RiepilogoPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            /*
            clientiInArrivoOggiDataGridView.Rows.Add("Vincenzo Villani");
            clientiInArrivoOggiDataGridView.Rows.Add("Antonio Benincasa");
            clientiInArrivoOggiDataGridView.Rows.Add("Pasquale Presutti");
            clientiInArrivoOggiDataGridView.Rows.Add("Unnome Molto Lungo e Art.");

            clientiInPartenzaOggiDataGridView.Rows.Add("Niola Mignogna");
            clientiInPartenzaOggiDataGridView.Rows.Add("Anthony De Castro Braciola");

            prenotazioniDaSaldareOggiDataGridView.Rows.Add("231 - Nicola Mignogna");
             */
        }
    }
}
