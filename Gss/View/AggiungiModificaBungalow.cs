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
    public partial class AggiungiModificaBungalow : Form 
    {
        public AggiungiModificaBungalow() 
        {
            InitializeComponent();

            stanzeDataGridView.Rows.Add("strdfgsdfgsdfi1", "3", "5");
            stanzeDataGridView.Rows.Add("stzdssdsri1", "5", "7");
            stanzeDataGridView.Rows.Add("strzsdzsdzddri1", "1", "1");
            stanzeDataGridView.Rows.Add("stzdssdsri1", "5", "7");
            stanzeDataGridView.Rows.Add("strzsdzsdzddri1", "1", "1");
            stanzeDataGridView.Rows.Add("stzdssdsri1", "5", "7");
            stanzeDataGridView.Rows.Add("strzsdzsdzddri1", "1", "1");
        }
    }
}
