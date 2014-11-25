using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gss.View 
{
    public partial class VisualizzaImpianto : Form 
    {
        public VisualizzaImpianto() 
        {
            InitializeComponent();

            pisteAlpineDataGridView.Rows.Add("asds", "alta");
            pisteAlpineDataGridView.Rows.Add("dfdsasas", "diff");
            pisteAlpineDataGridView.Rows.Add("asds", "med");
            pisteAlpineDataGridView.Rows.Add("asds", "alta");
            pisteAlpineDataGridView.Rows.Add("dfdsasas", "diff");
            pisteAlpineDataGridView.Rows.Add("asds", "med");
            pisteAlpineDataGridView.Rows.Add("asds", "med");


            pisteDiFondoDataGridView.Rows.Add("3", "2", "12");
            pisteDiFondoDataGridView.Rows.Add("5", "55", "34");
            pisteDiFondoDataGridView.Rows.Add("1", "1", "54");
            pisteDiFondoDataGridView.Rows.Add("3", "2", "12");
            pisteDiFondoDataGridView.Rows.Add("5", "55", "34");
            pisteDiFondoDataGridView.Rows.Add("1", "1", "54");
            pisteDiFondoDataGridView.Rows.Add("1", "1", "54");


            pisteSnowparkDataGridView.Rows.Add("3", "1", "2");
            pisteSnowparkDataGridView.Rows.Add("5", "3", "4");
            pisteSnowparkDataGridView.Rows.Add("1", "6", "5");
            pisteSnowparkDataGridView.Rows.Add("3", "1", "2");
            pisteSnowparkDataGridView.Rows.Add("5", "3", "4");
            pisteSnowparkDataGridView.Rows.Add("1", "6", "5");
            pisteSnowparkDataGridView.Rows.Add("1", "6", "5");
        }
    }
}
