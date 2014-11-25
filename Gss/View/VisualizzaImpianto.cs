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

            pisteAlpineDataGridView.Rows.Add("3", "asds", "strdfgsdfgsdfi1");
            pisteAlpineDataGridView.Rows.Add("5", "dfdsasas", "strdfgsdfgsdfi1");
            pisteAlpineDataGridView.Rows.Add("1", "asds", "strdfgsdfgsdfi1");
        }
    }
}
