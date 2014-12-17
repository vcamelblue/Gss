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

namespace Gss.View 
{
    public partial class VisualizzaFattura : Form 
	{
        private PrenotazioneArchiviata prenotazioneArchiviata;

        public VisualizzaFattura(PrenotazioneArchiviata prenotazioneArchiviata) 
		{
            this.prenotazioneArchiviata = prenotazioneArchiviata;

            InitializeComponent();
        }

        private void VisualizzaFattura_Load(object sender, EventArgs e)
        {
            if (prenotazioneArchiviata == null)
            {
                MessageBox.Show("Impossibile Visualizzare la fattura richiesta! La fattura selezionata potrebbe essere corrotta.");
                this.Close();
            }

            numeroFatturaTextBox.Text = prenotazioneArchiviata.Fattura != null ? prenotazioneArchiviata.Fattura.Numero.ToString() : "";
            dataFatturaTimePicker.Value = prenotazioneArchiviata.Fattura.DataFattura;
            
            clienteDataGridView.Rows.Add(prenotazioneArchiviata.Cliente.Nome, prenotazioneArchiviata.Cliente.Nome, prenotazioneArchiviata.Cliente.CodiceFiscale, prenotazioneArchiviata.Cliente.Indirizzo);
            
            dettagliFatturaDataGridView.Rows.Add("Bungalow", prenotazioneArchiviata.Fattura.TotaleBungalow);
            dettagliFatturaDataGridView.Rows.Add("Skicards", prenotazioneArchiviata.Fattura.TotaleSkiCards);
            dettagliFatturaDataGridView.Rows.Add("");
            dettagliFatturaDataGridView.Rows.Add("Totale", prenotazioneArchiviata.Fattura.TotaleFattura);
            
            dettagliFatturaDataGridView.Rows[3].Selected = true;  
        }


    }
}
