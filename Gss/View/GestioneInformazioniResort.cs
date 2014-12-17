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
using Gss.View.Utility;

namespace Gss.View {
    public partial class GestioneInformazioniResort : Form {
        
         //Fields

        private bool inEditingMode;
        private Resort resort;
        private ResortController resortController;

        public GestioneInformazioniResort(ResortController resortController) {

            this.resortController = resortController;
            resort = null;
            inEditingMode = false;

            InitializeComponent();
        
        }

        public GestioneInformazioniResort(ResortController resortController, Resort resort)
        {
            this.resortController = resortController;
            this.resort = resort;
            inEditingMode = true;

            InitializeComponent();

            nomeTextBox.Text = resort == null ? "" : resort.Nome;
            indirizzoTextBox.Text = resort == null ? "" : resort.Indirizzo;
            telefonoTextBox.Text = resort == null ? "" : resort.Telefono;
            emailTextBox.Text = resort == null ? "" : resort.Email;
            dataIniziodateTimePicker.Value = resort.DataInizioStagione == DateTime.MinValue? DateTime.Now.AddMonths(1) : resort.DataInizioStagione;
            dataFinedateTimePicker.Value = resort.DataFineStagione == DateTime.MinValue? DateTime.Now.AddMonths(3) : resort.DataFineStagione;

            
            this.Text = "Modifica Info";
            this.salvaButton.Text = "Salva Modifiche";
        }

        /*
            try
            {

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
         */

        private void salvaButton_Click(object sender, EventArgs e)
        {
            //recupero i campi

            String nome = nomeTextBox.Text;
            String indirizzo = indirizzoTextBox.Text;
            String telefono = telefonoTextBox.Text;
            String email = emailTextBox.Text;
            DateTime dataInizio = dataIniziodateTimePicker.Value.Date;
            DateTime dataFine = dataFinedateTimePicker.Value.Date;

            if (ConfigAndUtility.checkFields(nome, indirizzo, telefono, email))
            {
                try
                {
                    if (inEditingMode)
                    {
                        resortController.SetResortInfo(nome, indirizzo, telefono, email, dataInizio, dataFine);

                        this.DialogResult = DialogResult.OK;
                        this.Close();                        
                    }
                    else
                    {   
                        Resort resort = new Resort(nome, indirizzo, telefono, email, dataInizio, dataFine);

                        resortController.SetResort(resort);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }                        
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }           
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
