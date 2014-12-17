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
    public partial class VisualizzaImpianto : Form 
    {
        private Impianto impianto;

        public VisualizzaImpianto(Impianto impianto) 
        {
            this.impianto = impianto;

            InitializeComponent();

        }

        private void VisualizzaImpianto_Load(object sender, EventArgs e)
        {
            if (impianto == null)
            {
                MessageBox.Show("Impossibile Visualizzare l'impianto richiesto! L'impianto selezionato potrebbe essere corrotto.");
                this.Close();
            }

            int alpineCount = 0;
            int fondoCount = 0;
            int snowparkCount = 0;

            foreach(Pista p in impianto.Piste)
            {
                if (p is Alpina)
                {
                    Alpina alpina = (Alpina)p;
                    pisteAlpineDataGridView.Rows.Add(alpina.Nome, alpina.Difficolta.ToString());
                    alpineCount++;
                }
                else if (p is Fondo)
                {
                    Fondo fondo = (Fondo)p;
                    pisteDiFondoDataGridView.Rows.Add(fondo.Nome, fondo.DislivelloMedio.ToString(), fondo.DislivelloMassimo.ToString());
                    fondoCount++;
                }
                else if (p is SnowPark)
                {
                    SnowPark snowPark = (SnowPark)p;
                    pisteSnowparkDataGridView.Rows.Add(snowPark.Nome, snowPark.NumeroSalti.ToString(), snowPark.NumeroJibs.ToString());
                    snowparkCount++;
                }
            }

            nomeImpiantoTextBox.Text = impianto.Nome;
            versanteTextBox.Text = impianto.Versante;
            codiceTextBox.Text = impianto.Codice;

            pisteAlpineTotaliLabel.Text = "Piste Alpine Totali  " + alpineCount;
            pisteDiFondoTotaliLabel.Text = "Piste Di Fondo Totali  " + fondoCount;
            pisteSnowParkLabel.Text = "Piste SnowPark Totali  " + snowparkCount;
        }
    }
}
