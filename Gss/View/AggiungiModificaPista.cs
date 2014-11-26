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
                        SnowPark snowparkModificato = new SnowPark(nomePista, numeroSalti, numeroJibs);
                        SnowPark snowpark = (SnowPark)_pista;
                        _resortController.EditPistaSnowParkAdImpianto(snowpark, snowparkModificato);
                    }
                    else
                    {
                        SnowPark snowpark = new SnowPark(nomePista, numeroSalti, numeroJibs);
                        _resortController.AddPistaAdImpianto(_impianto, snowpark);
                    }
                    //SE TUTTO OK FARE COSI'

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (FormatException exception)
                {
                    MessageBox.Show("Inserire interi positivi");
                }
                catch (ArgumentNullException exception)
                {
                    MessageBox.Show("Riempire tutti i campi");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            else
            {
                MessageBox.Show("Inserire un nome valido");
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
                        Fondo fondoModificata = new Fondo(nomePista, dislivelloMassimo, dislivelloMedio);
                        Fondo fondo = (Fondo)_pista;
                        _resortController.EditPistaFondoAdImpianto(fondo, fondoModificata);
                    }
                    else
                    {
                        Fondo fondo = new Fondo(nomePista, dislivelloMassimo, dislivelloMedio);
                        _resortController.AddPistaAdImpianto(_impianto, fondo);
                    }
                    //SE TUTTO OK FARE COSI'

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (FormatException exception)
                {
                    MessageBox.Show("Inserire interi positivi");
                }
                catch (ArgumentNullException exception)
                {
                    MessageBox.Show("Riempire i campi dei dislivelli");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            else
            {
                MessageBox.Show("Inserire un nome valido");
            }               
         
       }

        private void salvaAlpina()
        {
            //Recupero i campi
            string nomePista = nomeAlpinaTextBox.Text;
            string difficoltaString = difficoltaComboBox.SelectedItem.ToString();
            Difficolta difficoltaValue = 0;

            if (nomePista!="")
            {
                try
                {
                    difficoltaValue = (Difficolta)Enum.Parse(typeof(Difficolta), difficoltaString);
                    if (_inEditingMode)
                    {
                        Alpina alpinaModificata = new Alpina(nomePista, difficoltaValue);
                        Alpina alpina = (Alpina)_pista;
                        _resortController.EditPistaAlpinaAdImpianto(alpina, alpinaModificata);
                    }
                    else
                    {
                        Alpina alpina = new Alpina(nomePista, difficoltaValue);
                        _resortController.AddPistaAdImpianto(_impianto, alpina);
                    }
                    //SE TUTTO OK FARE COSI'

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch(ArgumentException Exception)
                {
                    MessageBox.Show("Inserire una difficoltà valida");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            else
            {
                MessageBox.Show("Inserire un nome valido");
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
