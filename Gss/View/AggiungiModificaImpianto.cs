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
    public partial class AggiungiModificaImpianto : Form 
    {
        public AggiungiModificaImpianto() 
        {
            InitializeComponent();

            pisteDataGridView.Rows.Add("3", "asds", "strdfgsdfgsdfi1");
            pisteDataGridView.Rows.Add("5", "dfdsasas", "strdfgsdfgsdfi1");
            pisteDataGridView.Rows.Add("1", "asds", "strdfgsdfgsdfi1");
        }
    }
}
