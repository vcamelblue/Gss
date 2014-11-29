using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gss.Controller;
using Gss.Model;

namespace Gss.View 
{
    public partial class AggiungiModificaBungalow : Form 
    {
        private ResortController resortController;
        private Bungalow bungalow;
        private bool inEditingMode;


        public AggiungiModificaBungalow(ResortController resortController) 
        {
            this.resortController = resortController;
            this.bungalow = null;
            inEditingMode = false;

            InitializeComponent();

        }

        public AggiungiModificaBungalow(ResortController resortController, Bungalow bungalow)
        {
            this.resortController = resortController;
            this.bungalow = bungalow;
            inEditingMode = true;

            InitializeComponent();

            this.Text = "Modifica Bungalow";
            this.salvaButton.Text = "Salva Modifiche";

        }

        private void AggiungiModificaBungalow_Load(object sender, EventArgs e)
        {
            if (inEditingMode)
            {
                codiceTextBox1.Text = bungalow.Codice;
                codiceTextBox1.Enabled = false;
                RiempiGrid();
            }
        }

        private void RiempiGrid()
        {
            foreach (Stanza s in bungalow.Stanze)
            {
                stanzeDataGridView.Rows.Add(TipoCameraByPosti(s), s.NumeroPostiStandard.ToString(), s.NumeroPostiMax.ToString());
            }
            postiTotoaliLabel.Text = "Posti Totali:  " + bungalow.PostiTotaliStandard();
            postiMaxTotaliLabel.Text = "Posti Max Totali:  " + bungalow.PostiTotaliMax();
        }

        //Mi dice come è una stanza (singola, doppia, tripla)
        private string TipoCameraByPosti(Stanza stanza)
        {
            return (stanza.NumeroPostiStandard == 1 ? "Singola" :
                    stanza.NumeroPostiStandard == 2 ? "Doppia" :
                    stanza.NumeroPostiStandard == 3 ? "Tripla" :
                    stanza.NumeroPostiStandard == 4 ? "Quadrupla" :
                    stanza.NumeroPostiStandard == 5 ? "Quintupla" : "Nupla");
        }

        public override void Refresh()
        {
            base.Refresh();
            if (bungalow.Stanze.Count == 0)
            {
                modificaStanzaButton.Enabled = false;
                salvaButton.Enabled = false;
            }
            stanzeDataGridView.Rows.Clear();
            RiempiGrid();
        }

        private void rimuoviStanzaButton_Click(object sender, EventArgs e)
        {
            int numerPostiStandardSelezionata = int.Parse(stanzeDataGridView.SelectedRows[0].Cells[1].Value.ToString());
            int numerPostiMaxSelezionata = int.Parse(stanzeDataGridView.SelectedRows[0].Cells[2].Value.ToString());
            Stanza stanzaSelezionata = new Stanza(numerPostiStandardSelezionata, numerPostiMaxSelezionata);

            foreach (Stanza s in bungalow.Stanze)
            {
                if ( s.Equals(stanzaSelezionata))
                {
                    DialogResult result = MessageBox.Show("Sicuro di voler rimuovere la stanza selezionata?", "Rimozione Stanza", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        bungalow.Remove(s);
                        Refresh();
                        break;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
            }
        }

        private void modificaStanzaButton_Click(object sender, EventArgs e)
        {
            int numerPostiStandardSelezionata = int.Parse(stanzeDataGridView.SelectedRows[0].Cells[1].Value.ToString());
            int numerPostiMaxSelezionata = int.Parse(stanzeDataGridView.SelectedRows[0].Cells[2].Value.ToString());
            Stanza stanzaSelezionata = new Stanza(numerPostiStandardSelezionata, numerPostiMaxSelezionata);
            bool trovato = false;
            for(int i = 0; i<bungalow.Stanze.Count && !trovato;i++) 
            {
                Stanza s = bungalow.Stanze[i];
                if (s.Equals(stanzaSelezionata))
                {
                    trovato = true;
                    AggiungiModificaStanza modificaStanza = new AggiungiModificaStanza(bungalow, s, resortController);

                    DialogResult res = modificaStanza.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        Refresh();
                    }
                    
                }
            }
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aggiungiStanzaButton_Click(object sender, EventArgs e)
        {
            if (!inEditingMode && bungalow == null)
            {
                bungalow = new Bungalow(codiceTextBox1.Text);
            }

            AggiungiModificaStanza aggiungiStanzaForm = new AggiungiModificaStanza(bungalow, resortController);

            DialogResult res = aggiungiStanzaForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                Refresh();
            }

        }

        private void salvaButton_Click(object sender, EventArgs e)
        {
            //Recupero i campi
            string codiceBungalow = codiceTextBox1.Text;

            if (codiceBungalow!="")
            {
                try
                {
                    if (inEditingMode)
                    {
                        Bungalow bungalowModificato = new Bungalow(codiceBungalow);
                        bungalowModificato.Stanze = bungalow.Stanze;
                        resortController.EditBungalow(bungalow, bungalowModificato);
                    }
                    else
                    {
                        Bungalow bungalowNuovo = new Bungalow(codiceBungalow);
                        bungalowNuovo.Stanze = bungalow.Stanze;
                        resortController.AddBungalow(bungalowNuovo);
                    }
                    //SE TUTTO OK FARE COSI'

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Riempire tutti i campi");
            }
        }

    }
    }

