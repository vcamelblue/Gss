﻿using System;
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

namespace Gss.View {

    public partial class GestioneInfoResort : Form {

        //Fields

        private bool _inEditingMode;
        private Resort _resort;
        private Form _formChiamante;
        private ResortController _resortController;

        public GestioneInfoResort(ResortController resortController) {

            _resortController = resortController;
            _resort = null;
            _inEditingMode = false;

            InitializeComponent();
        
        }

        public GestioneInfoResort(ResortController resortController, Resort resort)
        {
            _resortController = resortController;
            _resort = resort;
            _inEditingMode = false;

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



            try
            {
                if (_inEditingMode)
                {

                }

            }
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
