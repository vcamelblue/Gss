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
    public partial class AggiungiModificaPista : Form {

        private bool _inEditingMode;
        private Impianto _impianto;
        private Pista _pista;
        private ResortController _resortController;
        private int _indice;

        public AggiungiModificaPista(ResortController resortController, Impianto impianto ) {

            _inEditingMode = false;
            _impianto = impianto;
            _resortController = resortController;
            
            InitializeComponent();

            tabControlWithoutHeader1.SelectedTab = tabVuoto;
        }

        public AggiungiModificaPista(ResortController resortController, Impianto impianto, Pista pista)
        {
            _inEditingMode = true;
            _impianto = impianto;
            _resortController = resortController;
            _pista = pista;

            InitializeComponent();

            TabPage tabCorrente = checkPista(_pista);
            if (tabCorrente == null)
            {
              MessageBox.Show("Pista da modificare non valida");
            }

            tabControlWithoutHeader1.SelectedTab = checkPista(_pista);


            this.Text = "Modifica Pista";
            salvaButton.Text = "Salva Modifiche";
        }

        private void salvaButton_Click(object sender, EventArgs e)
        {
            if (tabControlWithoutHeader1.SelectedTab == tabAlpina)
            {
                salvaAlpina();
            }
            else if (tabControlWithoutHeader1.SelectedTab == tabFondo)
            {
                salvaAFondo();
            }
            else if (tabControlWithoutHeader1.SelectedTab == tabSnowpark)
            {
                salvaSnowpark();
            }
        }

        private void salvaSnowpark()
        {
            if (_inEditingMode)
            {
            }
            else 
            { 
            }
                
        }

        private void salvaAFondo()
        {

            if (_inEditingMode)
            {

            }
            else
            {

            }
        }

        private void salvaAlpina()
        {

            if (_inEditingMode)
            {

            }
            else
            {

            }
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AggiungiModificaPista_Load(object sender, EventArgs e)
        {
            tipologiaComboBox1.Items.Insert(0, "Alpina");
            tipologiaComboBox1.Items.Insert(1, "Fondo");
            tipologiaComboBox1.Items.Insert(2, "Snowpark");
            tipologiaComboBox1.SelectedIndex = 0;

            difficoltaComboBox.Items.Insert(0,Difficolta.Alta.ToString());
            difficoltaComboBox.Items.Insert(1,Difficolta.Media.ToString());
            difficoltaComboBox.Items.Insert(2,Difficolta.Bassa.ToString());

            if (_inEditingMode)
            {
                tipologiaComboBox1.SelectedIndex = tipologiaComboBox1.FindStringExact(cercaCategoria(_pista));
                tipologiaComboBox1.Enabled =  false;
                if (_pista is Alpina)
                {
                    Alpina alpina = (Alpina)_pista;
                    difficoltaComboBox.SelectedIndex = difficoltaComboBox.FindStringExact(alpina.Difficolta.ToString());
                }
            }

        }

        private TabPage checkPista(Pista pista)
        {
            if (pista is Alpina)
            {
                Alpina alpina = (Alpina)pista;
                _indice = 0;
                nomeAlpinaTextBox.Text = alpina.Nome;
                return tabAlpina;
            }

            if (pista is Fondo)
            {
                Fondo fondo = (Fondo)pista;
                _indice = 1;
                nomeFondoTextBox.Text = fondo.Nome;
                dislivelloMaxTextBox2.Text = fondo.DislivelloMassimo.ToString();
                dislivelloMedioTextBox.Text = fondo.DislivelloMedio.ToString();
                return tabFondo;
            }
            if (pista is SnowPark)
            {
                SnowPark snowPark = (SnowPark)pista;
                nomeSnowparkTextBox.Text = snowPark.Nome;
                numeroSaltiTextBox.Text = snowPark.NumeroSalti.ToString();
                numeroJibsTextBox.Text = snowPark.NumeroJibs.ToString();
                _indice = 2;
                return tabSnowpark;
            }
            else return null;

        }

        private string cercaCategoria(Pista pista)
        {
            if (pista is Alpina)
            {
               
                return "Alpina";
            }

            if (pista is Fondo)
            {
                return "Fondo";
            }
            if (pista is SnowPark)
            {
                return "SnowPark";
            }
            else return "";

        }

        private void tipologiaComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (tipologiaComboBox1.SelectedIndex == 0)
            {
                tabControlWithoutHeader1.SelectedTab = tabAlpina;
            }
            if (tipologiaComboBox1.SelectedIndex == 1)
            {
                tabControlWithoutHeader1.SelectedTab = tabFondo;
            }
            if (tipologiaComboBox1.SelectedIndex == 2)
            {
                tabControlWithoutHeader1.SelectedTab = tabSnowpark;
            }
        }


    }
}
