using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.View.MainViewPanel
{
    public partial class GestioneProfili : System.Windows.Forms.UserControl
    {
        public GestioneProfili()
        {
            InitializeComponent();
        }

        public GestioneProfili(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            profiliDataGridView.Rows.Add("Altissima");
            profiliDataGridView.Rows.Add("Alta");
            profiliDataGridView.Rows.Add("Media");
            profiliDataGridView.Rows.Add("Bassissima");
            profiliDataGridView.Rows.Add("Bassa");
        }
    }
}
