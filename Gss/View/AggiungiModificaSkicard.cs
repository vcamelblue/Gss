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
    public partial class AggiungiModificaSkicard : Form 
    {

        private PrenotazioniController prenotazioniController;
        private ResortController resortController;
        private SkiCard skiCard;
        private SkiCards skicards;
        private bool inEditingMode;

        public AggiungiModificaSkicard(PrenotazioniController prenotazioniController, ResortController resortController,SkiCards skicards)
        {
            this.prenotazioniController = prenotazioniController;
            this.resortController = resortController;
            this.skiCard = null;
            this.skicards = skicards;
            inEditingMode = false;

            InitializeComponent();
        }

        public AggiungiModificaSkicard(PrenotazioniController prenotazioniController, ResortController resortController,SkiCards skicards, SkiCard skicard) 
        {
            this.prenotazioniController = prenotazioniController;
            this.resortController = resortController;
            this.skiCard = skicard;
            this.skicards = skicards;
            inEditingMode = true;

            InitializeComponent();

            this.Text = "Modifica SkiCard";
            this.salvaButton.Text = "Salva Modifiche";
        }

        private void AggiungiModificaSkicard_Load(object sender, EventArgs e)
        {
            codiceTextBox.Enabled = false;
            if (inEditingMode)
            {
                codiceTextBox.Text = skiCard.Codice;
                riempiSkiPassGrid();
            }
            else
            {
                codiceTextBox.Text = prenotazioniController.Gss.NumeroSkiCards.ToString();
            }
        }

        private void riempiSkiPassGrid()
        {
            totaleSkipassLabel.Text = "Pass Totali  " + skiCard.SkiPass.Count;
            double totale = 0;
            foreach(SkiPass s in skiCard.SkiPass)
            {
                skipassDataGridView.Rows.Add(s.Codice, s.Impianto.Nome, GetTipologiaSkipass(s), GetInfoBySkipass(s), s.GetPrezzoSkiPass());
                totale += s.GetPrezzoSkiPass();
            }
            totaleSkipassLabel.Text = "Totale SkiPass  " + totale + " €";
        }

        private string GetTipologiaSkipass(SkiPass skipass)
        {
            if (skipass is SkiPassAGiornata)
            {
                return "A Giornata";
            }
            return "Ad Accesso";
        }

        private string GetInfoBySkipass(SkiPass skipass)
        {
            if (skipass is SkiPassAGiornata)
            {
                SkiPassAGiornata skipassAGiornata = (SkiPassAGiornata) skipass;
                return "Dal : " + skipassAGiornata.DataInizio.ToString("dd/MM/yyyy") + ",  Al : " + skipassAGiornata.DataFine.ToString("dd/MM/yyyy");
            }
            SkiPassAdAccesso skipassAdAccesso = (SkiPassAdAccesso)skipass;
            return "Numero Accessi : " + skipassAdAccesso.NAccessi;
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aggiungiSkipassButton_Click(object sender, EventArgs e)
        {
            if (!inEditingMode && skiCard == null)
            {
                skiCard = new SkiCard(codiceTextBox.Text);
            }

            AggiungiModificaSkipass aggiungiSkipassForm = new AggiungiModificaSkipass(prenotazioniController, resortController, skiCard);
            DialogResult res = aggiungiSkipassForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void modificaSkipassButton_Click(object sender, EventArgs e)
        {
            foreach (SkiPass s in skiCard.SkiPass)
            {
                if (s.Codice == skipassDataGridView.SelectedRows[0].Cells[0].Value)
                {
                    AggiungiModificaSkipass modificaSkipassForm = new AggiungiModificaSkipass(prenotazioniController, resortController, skiCard,s);

                    DialogResult res = modificaSkipassForm.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        Refresh();
                    }
                    break;
                }
            }
        }

        private void rimuoviSkipssButton_Click(object sender, EventArgs e)
        {
            foreach (SkiPass s in skiCard.SkiPass)
            {
                if (s.Codice == skipassDataGridView.SelectedRows[0].Cells[0].Value)
                {
                    DialogResult result = MessageBox.Show("Sicuro di voler rimuovere lo SkiPass selezionat?", "Rimozione SkiPass", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        skiCard.Remove(s);
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

        private void salvaButton_Click(object sender, EventArgs e)
        {
            if(!inEditingMode)
            {
                skicards.Add(skiCard);
            }
            else
            {
                foreach (SkiCard s in skicards.ListaSkiCard)
                {
                    if (s.Codice == skiCard.Codice)
                    {
                        s.Codice = skiCard.Codice;
                        s.SkiPass = skiCard.SkiPass;
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        public override void Refresh()
        {
            base.Refresh();
            skipassDataGridView.Rows.Clear();
            riempiSkiPassGrid();
        }

    }
}

