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
using Gss.View;
using Gss.Model;

namespace Gss 
{
    public partial class Form1 : Form 
    {
        private ClientiController clientiController;

        internal Form1(ClientiController clientiController) 
        {
            this.clientiController = clientiController;


            InitializeComponent();
        }

        private void myButton1_Click(object sender, EventArgs e) 
        {
            AggiungiModificaCliente agg = new AggiungiModificaCliente(clientiController, clientiController.GetAllClienti().ListaClienti[0], this);
            agg.Show();
        }
    }
}
