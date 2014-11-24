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

namespace Gss.View {
    public partial class GestioneInformazioniResort : Form {
        
         //Fields

        private bool _inEditingMode;
        private Resort _resort;
        private Form _formChiamante;
        private ResortController _resortController;

        public GestioneInformazioniResort(ResortController resortController) {

            _resortController = resortController;
            _resort = null;
            _inEditingMode = false;

            InitializeComponent();
        
        }

        public GestioneInformazioniResort(ResortController resortController, Resort resort)
        {
            _resortController = resortController;
            _resort = resort;
            _inEditingMode = true;

            nomeTextBox.Text = resort.Nome;
            indirizzoTextBox.Text = resort.Indirizzo;
            telefonoTextBox.Text = resort.Telefono;
            emailTextBox.Text = resort.Email;
            dataIniziodateTimePicker.Value = resort.DataInizioStagione;
            dataFinedateTimePicker.Value = resort.DataFineStagione;

            InitializeComponent();

            this.Text = "Modifica Info";
            this.salvaButton.Text = "Salva Modifiche";
        }

        private void salvaButton_Click(object sender, EventArgs e)
        {
            //recupero i campi

            String nome = nomeTextBox.Text;
            String indirizzo = indirizzoTextBox.Text;
            String telefono = telefonoTextBox.Text;
            String email = emailTextBox.Text;
            DateTime dataInizio = dataIniziodateTimePicker.Value.Date;
            DateTime dataFine = dataFinedateTimePicker.Value.Date;

            if (checkFields(nome, indirizzo, telefono, email))
            {
                try
                    {
                        if (_inEditingMode)
                        {
                            _resortController.SetResortInfo(nome, indirizzo, telefono, email, dataInizio, dataFine);
                        }
                        else
                        {   Resort resort = new Resort(nome, indirizzo, telefono, email, dataInizio, dataFine);
                            
                            _resortController.SetResort(resort);
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

        //Utility Methods

        private bool checkFields(params String[] fields)
        {
            bool all_Ok = true;

            foreach (String s in fields)
            {
                all_Ok &= (s != "");
            }
            return all_Ok;
        }

        private String noNullString(String source)
        {
            return source != null ? source : "";
        }
    }
}
