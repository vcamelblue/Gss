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
    public partial class AggiungiModificaImpianto : Form 
    {
        private bool inEditingMode;
        private ResortController resortController;
        private Impianto impianto;
        private List<Pista> pisteImpianto;

        public AggiungiModificaImpianto(ResortController resortController) 
        {
            this.resortController = resortController;
            inEditingMode = false;
            impianto = null;
            pisteImpianto = new List<Pista>();

            InitializeComponent();
        }

        public AggiungiModificaImpianto(ResortController resortController, Impianto impianto)
        {
            this.resortController = resortController;
            inEditingMode = true;
            this.impianto = impianto;
            pisteImpianto = impianto.Piste;

            InitializeComponent();
        }

        private void AggiungiModificaImpianto_Load(object sender, EventArgs e)
        {
            if (inEditingMode)
            {
                codiceTextBox.Text = impianto.Codice;
                nomeTextBox.Text = impianto.Nome;
                versanteTextBox.Text = impianto.Versante;
                SetDataGrid();
                codiceTextBox.Enabled = false;

                this.Text = "Modifica Impianto";
                salvaButton.Text = "Salva Modifiche";
            }
            else pisteTotaliLabel.Text = "";
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

            if (!inEditingMode)
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
                if (p.Nome==pisteDataGridView.SelectedRows[0].Cells[0].Value)
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
                        pisteImpianto=impianto.Piste;
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

            if (checkFields(codiceImpianto, nomeImpianto, versante))
            {
                try
                {
                    if (inEditingMode)
                    {
                        Impianto impiantoModificato = new Impianto(codiceImpianto, nomeImpianto, versante);
                        List<Pista> pisteModificate = impianto.Piste;
                        impiantoModificato.Piste = pisteModificate;
                        resortController.EditImpianto(impianto, impiantoModificato);
                    }
                    else
                    {
                        Impianto nuovoImpianto = new Impianto(codiceImpianto, nomeImpianto, versante);
                        nuovoImpianto.Piste = pisteImpianto;
                        resortController.AddImpianto(nuovoImpianto);
                    }
                    //SE TUTTO OK FARE COSI'

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
            pisteDataGridView.Rows.Clear();
            SetDataGrid();
        }

       private void SetDataGrid()
        {
            foreach (Pista p in pisteImpianto)
            {
                pisteDataGridView.Rows.Add(p.Nome, GetTipologiaByPista(p), GetInfoByPista(p));
            }
            pisteTotaliLabel.Text = "Piste Totali  " + pisteImpianto.Count().ToString();
        }

       private bool checkFields(params String[] fields)
       {
           bool all_Ok = true;

           foreach (String s in fields)
           {
               all_Ok &= (s != "");
           }
           return all_Ok;
       }
       

    }
}
