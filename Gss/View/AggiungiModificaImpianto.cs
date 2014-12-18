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
using Gss.View.Utility;

namespace Gss.View 
{
    public partial class AggiungiModificaImpianto : Form 
    {
        private bool inEditingMode;
        private ResortController resortController;
        private Impianto impianto;
        private List<Pista> pisteImpianto;

        public AggiungiModificaImpianto(ResortController resortController) 
        {
            this.resortController = resortController;
            this.inEditingMode = false;
            this.impianto = null;
            this.pisteImpianto = new List<Pista>();

            InitializeComponent();
        }

        public AggiungiModificaImpianto(ResortController resortController, Impianto impianto)
        {
            this.resortController = resortController;
            this.inEditingMode = true;
            this.impianto = impianto;
            this.pisteImpianto = impianto.Piste;

            InitializeComponent();
        }

        private void AggiungiModificaImpianto_Load(object sender, EventArgs e)
        {
            if (inEditingMode)
            {
                if (impianto == null)
                {
                    MessageBox.Show("Impossibile caricare i dati dell'impianto selezionato! L'impianto potrebbe essere corrotto.");
                    this.Close();
                }

                codiceTextBox.Text = impianto.Codice;
                nomeTextBox.Text = impianto.Nome;
                versanteTextBox.Text = impianto.Versante;

                SetDataGrid();

                codiceTextBox.Enabled = false;

                this.Text = "Modifica Impianto";
                salvaButton.Text = "Salva Modifiche";
            }
            else 
                pisteTotaliLabel.Text = "";
        }

        private string GetTipologiaByPista(Pista pista)
        {
            if (pista is Alpina)
                return "Alpina";
            if (pista is Fondo)
                return "Fondo";
            if (pista is SnowPark)
                return "SnowPark";
            return "";
        }

        private string GetInfoByPista(Pista pista)
        {
            if (pista is Alpina)
            {
                Alpina alpina = (Alpina)pista;
                return "Difficoltà: " + alpina.Difficolta.ToString();
            }
            if (pista is Fondo)
            {
                Fondo fondo = (Fondo)pista;
                return "Dislivello Medio: " + fondo.DislivelloMedio + ";  Dislivello Massimo: " + fondo.DislivelloMassimo; 
            }
            if (pista is SnowPark)
            {
                SnowPark snowPark = (SnowPark)pista;
                return "Salti: " + snowPark.NumeroSalti + ";  Jibs:" + snowPark.NumeroJibs;
            }
            return "";
        }

        private void aggiungiPistaButton_Click(object sender, EventArgs e)
        {

            if (!inEditingMode && impianto == null)
            {
                impianto = new Impianto(codiceTextBox.Text, nomeTextBox.Text, versanteTextBox.Text);
            }

            AggiungiModificaPista aggiungiPistaForm = new AggiungiModificaPista(resortController, impianto);
            
            DialogResult res = aggiungiPistaForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                pisteImpianto = impianto.Piste;
                Refresh();
            }
        }

        private void modificaPistaButton_Click(object sender, EventArgs e)
        {
            foreach (Pista p in pisteImpianto)
            {
                if (p.Nome == pisteDataGridView.SelectedRows[0].Cells[0].Value)
                {
                    AggiungiModificaPista aggiungiPistaForm = new AggiungiModificaPista(resortController, impianto, p);
                    
                    DialogResult res = aggiungiPistaForm.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        pisteImpianto = impianto.Piste;
                        Refresh();
                    }
                    break;
                }
            }
        }

        private void rimuoviPistaButton_Click(object sender, EventArgs e)
        {
            foreach (Pista p in pisteImpianto)
            {
                if (p.Nome == pisteDataGridView.SelectedRows[0].Cells[0].Value)
                {
                    DialogResult result = MessageBox.Show("Sicuro di voler rimuovere la pista selezionata?", "Rimozione Pista", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        impianto.Remove(p);
                        pisteImpianto = impianto.Piste;
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

       private void annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void salvaButton_Click(object sender, EventArgs e)
        {
            //Recupero i campi
            string codiceImpianto = codiceTextBox.Text;
            string nomeImpianto = nomeTextBox.Text;
            string versante = versanteTextBox.Text;

            if (ConfigAndUtility.checkFields(codiceImpianto, nomeImpianto, versante))
            {
                try
                {
                    if (inEditingMode)
                    {
                        impianto.Codice = codiceImpianto;
                        impianto.Nome = nomeImpianto;
                        impianto.Versante = versante;

                        //le piste sono già impostate perchè l'agiunta/modifica/rimozione avviene sull'impianto passato,
                        //se in editing mode!
                    }
                    else
                    {
                        Impianto nuovoImpianto = new Impianto(codiceImpianto, nomeImpianto, versante);
                        nuovoImpianto.Piste = pisteImpianto;
                        resortController.AddImpianto(nuovoImpianto);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                 MessageBox.Show("Riempire tutti i campi");
            }
        }

       public override void Refresh()
       {
            base.Refresh();
            SetDataGrid();
       }

       private void SetDataGrid()
       {
            pisteDataGridView.Rows.Clear();
            foreach (Pista p in pisteImpianto)
            {
                pisteDataGridView.Rows.Add(p.Nome, GetTipologiaByPista(p), GetInfoByPista(p));
            }
            pisteTotaliLabel.Text = "Piste Totali  " + pisteImpianto.Count().ToString();

            if (pisteDataGridView.Rows.Count == 0)
            {
                rimuoviPistaButton.Enabled = false;
                modificaPistaButton.Enabled = false;
            }
            else
            {
                rimuoviPistaButton.Enabled = true;
                modificaPistaButton.Enabled = true;
            }
       }

    }
}
