using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gss.Model;
using Gss.Controller;

namespace Gss.View 
{
    public partial class AggiungiModificaPeriodo : Form 
    {
        public AggiungiModificaPeriodo() 
        {
            InitializeComponent();
        }


        private void salvaButton_Click(object sender, EventArgs e) 
        {

        }

        private void annullaButton_Click(object sender, EventArgs e) 
        {
            this.Close();
        }
    }
}
