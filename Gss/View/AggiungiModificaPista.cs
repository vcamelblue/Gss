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
            tipologiaComboBox1.SelectionStart = _indice;

        }

        private void salvaButton_Click(object sender, EventArgs e)
        {

        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AggiungiModificaPista_Load(object sender, EventArgs e)
        {
            tipologiaComboBox1.Items.Add("Alpina");
            tipologiaComboBox1.Items.Add("Fondo");
            tipologiaComboBox1.Items.Add("SnowPark");

            difficoltaComboBox.Items.Add(Difficolta.Alta.ToString());
            difficoltaComboBox.Items.Add(Difficolta.Media.ToString());
            difficoltaComboBox.Items.Add(Difficolta.Bassa.ToString());
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
    }
}
