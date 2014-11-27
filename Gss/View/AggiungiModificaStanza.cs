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

        private bool _inEditingMode;
        private Bungalow _bungalow;
        private Stanza _stanza;
        private ResortController _resortController;

        //Costructors

        public AggiungiModificaStanza(Bungalow bungalow, ResortController resortController)
        {
            _resortController = resortController;
            _bungalow = bungalow;
            _stanza = null;
            _inEditingMode = false;

            InitializeComponent();
        }

        public AggiungiModificaStanza(Bungalow bungalow, Stanza stanza, ResortController resortController)
        {
            _resortController = resortController;
            _bungalow = bungalow;
            _stanza = stanza;
            _inEditingMode = true;

            InitializeComponent();

            numeroPostiMassimiTextBox.Text = _stanza.NumeroPostiMax+"";
            numeroPostiStandardTextBox.Text = _stanza.NumeroPostiStandard+"";

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
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Inserisci numeri e non lettere");
            }
            try
            {
                  if ((numeroPostiStandard != 0) && (numeroPostiMassimi != 0) && (numeroPostiMassimi >= numeroPostiStandard))
                  {
                      if (_inEditingMode)
                      {
                          _stanza.NumeroPostiMax = numeroPostiMassimi;
                          _stanza.NumeroPostiStandard = numeroPostiStandard;
                      }
                      else //nuova stanza
                      {
                          _stanza = new Stanza(numeroPostiStandard, numeroPostiMassimi);
                          _bungalow.Add(_stanza);
                      }
                      //SE TUTTO OK FARE COSI'
                      this.DialogResult = DialogResult.OK;
                      this.Close();
                  }
                  else
                  {
                      MessageBox.Show("Inserire numeri maggiori di zero e con posti massimi maggiori o uguali di posti standard");
                  }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Inserisci numeri posti maggiori di zero, e posti massimi maggiori di posti standard");
            }
        }
    }
}

