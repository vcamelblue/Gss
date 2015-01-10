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
    public partial class AggiungiModificaStanza : Form
    {
        //Fields

        private bool inEditingMode;
        private Bungalow bungalow;
        private Stanza stanza;
        private ResortController resortController;

        //Costructors

        public AggiungiModificaStanza(Bungalow bungalow, ResortController resortController)
        {
            this.resortController = resortController;

            this.bungalow = bungalow;
            this.stanza = null;

            this.inEditingMode = false;

            InitializeComponent();
        }

        public AggiungiModificaStanza(Bungalow bungalow, Stanza stanza, ResortController resortController)
        {
            this.resortController = resortController;

            this.bungalow = bungalow;
            this.stanza = stanza;

            this.inEditingMode = true;

            InitializeComponent();

            numeroPostiMassimiTextBox.Text = stanza.NumeroPostiMax.ToString();
            numeroPostiStandardTextBox.Text = stanza.NumeroPostiStandard.ToString();

            this.Text = "Modifica Stanza";
            this.salvaButton.Text = "Salva Modifiche";
        }

        private void salvaButton_Click(object sender, EventArgs e)
        {
            int numeroPostiStandard = 0;
            int numeroPostiMassimi = 0;

            //recupero i campi
            try
            {
                 numeroPostiStandard = Convert.ToInt32(numeroPostiStandardTextBox.Text);
                 numeroPostiMassimi = Convert.ToInt32(numeroPostiMassimiTextBox.Text);
                  if ((numeroPostiStandard > 0) && (numeroPostiMassimi > 0) && (numeroPostiMassimi >= numeroPostiStandard))
                  {
                      if (inEditingMode)
                      {
                          stanza.NumeroPostiMax = numeroPostiMassimi;
                          stanza.NumeroPostiStandard = numeroPostiStandard;
                      }
                      else //nuova stanza
                      {
                          stanza = new Stanza(numeroPostiStandard, numeroPostiMassimi);
                          bungalow.AddStanza(stanza);
                      }

                      this.DialogResult = DialogResult.OK;
                      this.Close();
                  }
                  else
                  {
                      MessageBox.Show("Inserire numeri maggiori di zero e con posti massimi maggiori o uguali di posti standard");
                  }
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Inserisci solo numeri interi positivi!");
            }
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

