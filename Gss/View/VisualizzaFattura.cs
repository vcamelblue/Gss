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
    public partial class VisualizzaFattura : Form 
	{
        public VisualizzaFattura() 
		{
            InitializeComponent();

            clienteDataGridView.Rows.Add("Vincenzo", "Villani", "VNCVLL90M02C095R", "Via Saffi 15, Bologna (BO)");

            dettagliFatturaDataGridView.Rows.Add("Bungalow", "560 €");
            dettagliFatturaDataGridView.Rows.Add("SkiCards", "89 €");
            dettagliFatturaDataGridView.Rows.Add("", "");
            dettagliFatturaDataGridView.Rows.Add("Totale", "649 €");
        }
    }
}
