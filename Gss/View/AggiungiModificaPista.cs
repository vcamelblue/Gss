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

        //Costruttore per aggiunta
        public AggiungiModificaPista(ResortController resortController, Impianto impianto ) {

            _inEditingMode = false;
            _impianto = impianto;
            _resortController = resortController;
            
            InitializeComponent();

            tabControlWithoutHeader1.SelectedTab = tabVuoto;
        }

        //Costruttore per modifica, si assume che la pista passata sia il riferimento all'oggetto corretto,
        //da non modificare prima dell'effettivo salvataggio!
        public AggiungiModificaPista(ResortController resortController, Impianto impianto, Pista pista)
        {
            _inEditingMode = true;
            _impianto = impianto;
            _resortController = resortController;
            _pista = pista;

            InitializeComponent();

            //cerco il pannello corretto in base al tipo di pista, se nullo errore!
            TabPage tabCorrente = checkPista(_pista);

            if (tabCorrente != null)
            {
                tabControlWithoutHeader1.SelectedTab = checkPista(_pista);

                this.Text = "Modifica Pista";
                salvaButton.Text = "Salva Modifiche";
            }
            else
            {
              MessageBox.Show("Pista da modificare non valida!");
              this.Close();
            }

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
            //Recupero i campi
            string nomePista = nomeSnowparkTextBox.Text;
            int numeroSalti = 0;
            int numeroJibs = 0;

            if (nomePista != "")
            {
                try
                {
                    numeroSalti = int.Parse(numeroSaltiTextBox.Text);
                    numeroJibs = int.Parse(numeroJibsTextBox.Text);

                    if (_inEditingMode)
                    {
                        SnowPark snowpark = (SnowPark)_pista;
                        snowpark.Nome = nomePista;
                        snowpark.NumeroSalti = numeroSalti;
                        snowpark.NumeroJibs = numeroJibs;
                    }
                    else
                    {
                        SnowPark snowpark = new SnowPark(nomePista, numeroSalti, numeroJibs);
                        _impianto.Add(snowpark);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (FormatException)
                {
                    MessageBox.Show("Inserire numeri interi positivi!");
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Riempire tutti i campi!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            else
            {
                MessageBox.Show("Inserisci un nome valido per la pista!");
            }
        }

        private void salvaAFondo()
        {
            //Recupero i campi
            string nomePista = nomeFondoTextBox.Text;
            double dislivelloMassimo = 0;
            double dislivelloMedio = 0;

            if (nomePista != "")
            {
                try
                {
                    dislivelloMassimo = double.Parse(dislivelloMaxTextBox2.Text);
                    dislivelloMedio = double.Parse(dislivelloMedioTextBox.Text);
                    if (_inEditingMode)
                    {
                        Fondo fondo = (Fondo)_pista;
                        fondo.Nome = nomePista;
                        fondo.DislivelloMassimo = dislivelloMassimo;
                        fondo.DislivelloMedio = dislivelloMedio;
                    }
                    else
                    {
                        Fondo fondo = new Fondo(nomePista, dislivelloMassimo, dislivelloMedio);
                        _impianto.Add(fondo);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (FormatException)
                {
                    MessageBox.Show("Inserire numeri interi positivi!");
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Riempire i campi dei dislivelli!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            else
            {
                MessageBox.Show("Inserisci un nome valido per la pista!");
            }               
         
       }

        private void salvaAlpina()
        {
            //Recupero i campi
            string nomePista = nomeAlpinaTextBox.Text;
            string difficoltaString = difficoltaComboBox.SelectedItem.ToString();
            Difficolta difficoltaValue = 0;

            if (nomePista != "")
            {
                try
                {
                    difficoltaValue = (Difficolta)Enum.Parse(typeof(Difficolta), difficoltaString);

                    if (_inEditingMode)
                    {
                        Alpina alpina = (Alpina)_pista;
                        alpina.Nome = nomePista;
                        alpina.Difficolta = difficoltaValue;
                    }
                    else
                    {
                        Alpina alpina = new Alpina(nomePista, difficoltaValue);
                        _impianto.Add(alpina);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch(ArgumentException)
                {
                    MessageBox.Show("Inserisci una difficoltà valida!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            else
            {
                MessageBox.Show("Inserisci un nome valido per la pista!");
            }               
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //On Load Setto i vaori dei combobox, se alpina setto anche quello dentro il pannello
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


        //funzione per identificare il pannello in base alla tipologia di pista
        private TabPage checkPista(Pista pista)
        {
            if (pista is Alpina)
            {
                Alpina alpina = (Alpina)pista;

                nomeAlpinaTextBox.Text = alpina.Nome;

                return tabAlpina;
            }
            if (pista is Fondo)
            {
                Fondo fondo = (Fondo)pista;

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

                return tabSnowpark;
            }
            return null;
        }


        //Funzione per riconoscere Tipo Pista
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
            return "";
        }


        //Funzione per cambiare il pannello
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
