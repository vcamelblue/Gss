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
    public partial class AggiungiModificaCliente : Form 
    {
        //Fields

        private bool inEditingMode;
        private Form formChiamante;
        private Cliente clienteToEdit;
        private ClientiController clientiController;


        //Constructors

        public AggiungiModificaCliente(ClientiController clientiController) 
        {
            this.clientiController = clientiController;
            inEditingMode = false;

            InitializeComponent();
        }

        public AggiungiModificaCliente(ClientiController clientiController, Cliente clienteToEdit, Form formChiamante) 
        {
            this.formChiamante = formChiamante;
            this.clienteToEdit = clienteToEdit;
            this.inEditingMode = true;

            InitializeComponent();

            nomeTextBox.Text = clienteToEdit.Nome;
            cognomeTextBox.Text = clienteToEdit.Cognome;
            dataNascitaTimePicker.Value = clienteToEdit.DataNascita;
            codiceFiscaleTextBox.Text = clienteToEdit.CodiceFiscale;
            indirizzoTextBox.Text = clienteToEdit.Indirizzo;
            telefonoTextBox.Text = clienteToEdit.Telefono;
            emailTextBox.Text = clienteToEdit.Email;

            this.Text = "Modifica Cliente";
            this.salvaButton.Text = "Salva Modifiche";

        }


        //Methods

        private void salvaButton_Click(object sender, EventArgs e) 
        {
            //recupero i campi

            String nome = nomeTextBox.Text;
            String cognome = cognomeTextBox.Text;
            DateTime dataNascita = dataNascitaTimePicker.Value.Date;
            String codiceFiscale = codiceFiscaleTextBox.Text;
            String indirizzo = indirizzoTextBox.Text;
            String telefono = telefonoTextBox.Text;
            String email = emailTextBox.Text;

            //controllo che non siano nulli, telefono e email sono opzionali, 
            //ma almeno uno dei due deve esistere
            
            if( checkFields(nome, cognome, dataNascita, codiceFiscale, indirizzo) 
                && (telefono != null || email != null) ) 
            {
                //se in editing mode setto i campi del cliente passato
                try {
                    
                    if (inEditingMode) {   //verificare che il cliente originale non sia null?
                        Cliente clienteEdited = new Cliente(nome, cognome, codiceFiscale, dataNascita, indirizzo, telefono, email);
                        clientiController.EditCliente(clienteToEdit, clienteEdited);
                    }
                    else                    //nuovo cliente
                    {
                        clienteToEdit = new Cliente(nome, cognome, codiceFiscale, dataNascita, indirizzo, telefono, email);
                        clientiController.AddCliente(clienteToEdit);
                    }

                    formChiamante.Refresh();
                    this.Close();
                
                }
                catch (Exception exception) {
                    errorProvider.SetError(this, exception.Message);
                }

            }
            else //se lo sono lancio errore
            {
                errorProvider.SetError(this, "Completa i campi per continuare!");
            }

        }

        private void annullaButton_Click(object sender, EventArgs e) 
        {
            this.Close();
        }

        //Utility Methods

        private bool checkFields(params object[] fields) 
        {
            bool all_Ok = true;

            foreach (object o in fields) 
            {
                all_Ok &= (o != null);
            }
            return all_Ok;
        }

        private String noNullString(String source) {
            return source != null ? source : "";
        }

    }
}
