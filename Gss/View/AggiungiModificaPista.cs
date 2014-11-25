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

        public AggiungiModificaPista(ResortController resortController, Impianto impianto ) {

            _inEditingMode = false;
            _impianto = impianto;
            _resortController = resortController;


            InitializeComponent();

        }

        public AggiungiModificaPista(ResortController resortController, Impianto impianto, Pista pista)
        {
            _inEditingMode = true;
            _impianto = impianto;
            _resortController = resortController;



            InitializeComponent();

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
        }

        private int checkPista(Pista pista)
        {
            if (pista is Alpina)
            {
                return 1;
            }

            if (pista is Fondo)
            {
                return 2;
            }
            if (pista is SnowPark)
            {
                return 3;
            }
            else return -1;

        }
    }
}
