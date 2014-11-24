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
        private Cliente cliente;
        private ClientiController _clientiController;


        //Constructors

        public AggiungiModificaCliente(ClientiController clientiController) 
        {
            this._clientiController = clientiController;
            inEditingMode = false;

            InitializeComponent();
        }

        public AggiungiModificaCliente(Cliente cliente, Form formChiamante) 
        {
            this.formChiamante = formChiamante;
            this.cliente = cliente;
            this.inEditingMode = true;

            InitializeComponent();

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
                if (inEditingMode) 
                {   //verificare che il cliente originale non sia null?
                    Cliente clienteEdited = new Cliente(nome, cognome, codiceFiscale, dataNascita, indirizzo, telefono, email);
                    _clientiController.EditCliente(cliente, clienteEdited);
                }
                else //nuovo cliente
                {
                    cliente = new Cliente(nome, cognome, codiceFiscale, dataNascita, indirizzo, telefono, email);
                    _clientiController.AddCliente(cliente);
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

    }
}
