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
using Gss.View;
using Gss.Model;

namespace Gss 
{
    public partial class Form1 : Form 
    {
        private ClientiController clientiController;

        private Button previusSelectedButton = null;
        private Color normalButtonColor = Color.FromKnownColor(KnownColor.LightGray);
        private Color selectedButtonColor = Color.FromArgb(54, 78, 102);

        internal Form1(ClientiController clientiController) 
        {
            this.clientiController = clientiController;


            InitializeComponent();
        }

        private void myButton1_Click(object sender, EventArgs e) 
        {
            AggiungiModificaCliente amc = new AggiungiModificaCliente(clientiController, clientiController.GetAllClienti().ListaClienti[3]);
            DialogResult res = amc.ShowDialog();
            if (res == DialogResult.OK) {
                Refresh();
            }
        }

        private void myButton2_Click(object sender, EventArgs e) {
            AggiungiModificaCliente amc = new AggiungiModificaCliente(clientiController);
            DialogResult res = amc.ShowDialog();
            if (res == DialogResult.OK) {
                Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            dataGridView1.Rows.Add("stri1", "stri1", "stri1", "stri1", "stri1");
            dataGridView1.Rows.Add("stri1", "stri1", "stri1", "stri1", "stri1");
            dataGridView1.Rows.Add("stri1", "stri1", "stri1", "stri1", "stri1");
        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            selectRightButton(myButton3);
        }

        private void myButton4_Click(object sender, EventArgs e)
        {
            selectRightButton(myButton4);
        }

        private void myButton5_Click(object sender, EventArgs e)
        {
            selectRightButton(myButton5);
        }


        //utilissima funzione
        private void selectRightButton(Button newSelectedButton)
        {
            if (previusSelectedButton != null)
            {
                previusSelectedButton.BackColor = normalButtonColor;
            }
            newSelectedButton.BackColor = selectedButtonColor;
            previusSelectedButton = newSelectedButton;            
        }
    }
}
