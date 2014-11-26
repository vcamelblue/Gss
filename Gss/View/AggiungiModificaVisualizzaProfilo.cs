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
    public partial class AggiungiModificaVisualizzaProfilo : Form 
	{
        public AggiungiModificaVisualizzaProfilo() 
		{
            InitializeComponent();

            //aggiustare tabulazione per passare al prossimo controllo!

            bungalowDataGridView.Rows.Add("001", "2", "Singola + Sngola", "2", "4");
            risorseDataGridView.Rows.Add("Bungalow - 001");
            risorseDataGridView.Rows.Add("Bungalow - 002");
            risorseDataGridView.Rows.Add("Bungalow - 003");
            risorseDataGridView.Rows.Add("Bungalow - 004");
            risorseDataGridView.Rows.Add("Bungalow - 005");
            risorseDataGridView.Rows.Add("Bungalow - 006");
            risorseDataGridView.Rows.Add("Impianto - 001");
            risorseDataGridView.Rows.Add("Impianto - 002");
            risorseDataGridView.Rows.Add("Impianto - 003");
            risorseDataGridView.Rows.Add("Impianto - 004");
            risorseDataGridView.Rows.Add("Impianto - 005");
            risorseDataGridView.Rows.Add("Impianto - 006");
            risorseDataGridView.Rows.Add("Impianto - 007");
            risorseDataGridView.Rows.Add("Impianto - 008");
            risorseDataGridView.Rows.Add("Impianto - 007");
            risorseDataGridView.Rows.Add("Impianto - 008");
            risorseDataGridView.Rows.Add("Impianto - 007");
            risorseDataGridView.Rows.Add("Impianto - 008");
            risorseDataGridView.Rows.Add("Impianto - 007");
            risorseDataGridView.Rows.Add("Impianto - 008");
            risorseDataGridView.Rows.Add("Impianto - 007");
            risorseDataGridView.Rows.Add("Impianto - 008");
        }
    }
}
