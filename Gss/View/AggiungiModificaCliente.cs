﻿using System;
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

namespace Gss.View
{
    public partial class AggiungiModificaCliente : Form 
    {
        //Fields

        private bool inEditingMode;
        private bool inViewMode;
        private Cliente clienteToEdit;
        private ClientiController clientiController;


        //Constructors

        public AggiungiModificaCliente(ClientiController clientiController) 
        {
            this.clientiController = clientiController;
            this.inEditingMode = false;
            this.inViewMode = false;

            InitializeComponent();
        }

        public AggiungiModificaCliente(ClientiController clientiController, Cliente clienteToEdit, bool inViewMode) 
        {
            this.clientiController = clientiController;
            this.clienteToEdit = clienteToEdit;
            this.inViewMode = inViewMode;

            InitializeComponent();
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

            //controllo che non siano nulli/vuoti, telefono e email sono opzionali, 
            //ma almeno uno dei due deve esistere
            
            if( ConfigAndUtility.checkFields(nome, cognome, codiceFiscale, indirizzo) && dataNascita != null
                && (telefono != "" || email != "") ) 
            {
                //se in editing mode setto i campi del cliente passato
                try 
                {
                    if (inEditingMode) 
                    {   
                        Cliente clienteEdited = new Cliente(nome, cognome, codiceFiscale, dataNascita, indirizzo, telefono, email);
                        clientiController.EditCliente(clienteToEdit, clienteEdited);
                    }
                    else //nuovo cliente
                    {
                        Cliente cliente = new Cliente(nome, cognome, codiceFiscale, dataNascita, indirizzo, telefono, email);
                        clientiController.AddCliente(cliente);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception exception) {
                    MessageBox.Show(exception.Message);
                }
            }
            else //se lo sono lancio errore
            {
                MessageBox.Show("Completa i campi per continuare!");
            }

        }

        private void annullaButton_Click(object sender, EventArgs e) 
        {
            this.Close();
        }


        private void AggiungiModificaCliente_Load(object sender, EventArgs e)
        {
            dataNascitaTimePicker.MaxDate = DateTime.Today.AddYears(-18);

            if ((inEditingMode || inViewMode))
            {
                if (clienteToEdit == null)
                {
                    MessageBox.Show("Impossibile caricare i dati del cliente selezionato! Il cliente potrebbe essere corrotto.");
                    this.Close();
                }

                if (inViewMode == true)
                {
                    this.inEditingMode = false;

                    nomeTextBox.Enabled = false;
                    cognomeTextBox.Enabled = false;
                    dataNascitaTimePicker.Enabled = false;
                    codiceFiscaleTextBox.Enabled = false;
                    indirizzoTextBox.Enabled = false;
                    telefonoTextBox.Enabled = false;
                    emailTextBox.Enabled = false;
                    salvaButton.Visible = false;
                    annullaButton.Visible = false;

                    this.Height -= annullaButton.Height + 20;

                    this.Text = "Visualizza Cliente";
                }
                else
                {
                    this.inEditingMode = true;

                    this.Text = "Modifica Cliente";
                    this.salvaButton.Text = "Salva Modifiche";
                }

                nomeTextBox.Text = clienteToEdit.Nome;
                cognomeTextBox.Text = clienteToEdit.Cognome;
                dataNascitaTimePicker.Value = clienteToEdit.DataNascita;
                codiceFiscaleTextBox.Text = clienteToEdit.CodiceFiscale;
                indirizzoTextBox.Text = clienteToEdit.Indirizzo;
                telefonoTextBox.Text = clienteToEdit.Telefono;
                emailTextBox.Text = clienteToEdit.Email;

            }
        }

    }
}
