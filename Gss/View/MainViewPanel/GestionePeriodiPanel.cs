using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.View.MainViewPanel
{
    public partial class GestionePeriodiPanel : System.Windows.Forms.UserControl
    {
        public GestionePeriodiPanel()
        {
            InitializeComponent();
        }

        public GestionePeriodiPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();


            periodiDataGridView.Rows.Add("Bassissima", "5 Gennaio 2015", "20 Gennaio 2015");
            periodiDataGridView.Rows.Add("Bassa", "5 Gennaio 2015", "20 Gennaio 2015");
            periodiDataGridView.Rows.Add("Media", "5 Gennaio 2015", "20 Gennaio 2015");
            periodiDataGridView.Rows.Add("Alta", "5 Gennaio 2015", "20 Gennaio 2015");
            periodiDataGridView.Rows.Add("Altissima", "5 Gennaio 2015", "20 Gennaio 2015");
            periodiDataGridView.Rows.Add("Alta", "5 Gennaio 2015", "20 Gennaio 2015");
            periodiDataGridView.Rows.Add("Media", "5 Gennaio 2015", "20 Gennaio 2015");
            periodiDataGridView.Rows.Add("Bassa", "5 Gennaio 2015", "20 Gennaio 2015");
            periodiDataGridView.Rows.Add("Bassissima", "5 Gennaio 2015", "20 Gennaio 2015");
        }
    }
}
