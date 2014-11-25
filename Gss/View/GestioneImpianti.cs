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
    public partial class GestioneImpianti : Form 
    {
        public GestioneImpianti() 
        {
            InitializeComponent();

            impiantiDataGridView.Rows.Add("stri1", "stri1", "strdfgsdfgsdfi1", "stri1", "stri1", "sdjssal");
            impiantiDataGridView.Rows.Add("stri1", "stri1", "stzdssdsri1", "stri1", "stri1", "sdjssal");
            impiantiDataGridView.Rows.Add("stri1", "stri1", "strzsdzsdzddri1", "stri1", "stri1", "sdjssal");
            impiantiDataGridView.Rows.Add("stri1", "stri1", "strdfgsdfgsdfi1", "stri1", "stri1", "sdjssal");
            impiantiDataGridView.Rows.Add("stri1", "stri1", "stzdssdsri1", "stri1", "stri1", "sdjssal");
            
        }
    }
}
