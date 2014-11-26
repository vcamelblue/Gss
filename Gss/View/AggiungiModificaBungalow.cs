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
using Gss.Model;

namespace Gss.View 
{
    public partial class AggiungiModificaBungalow : Form 
    {
        private ResortController resortController;
        private Bungalow bungalow;
        private bool inEditingMode;


        public AggiungiModificaBungalow(ResortController resortController) 
        {
            this.resortController = resortController;
            this.bungalow = null;
            inEditingMode = false;

            InitializeComponent();

        }

        public AggiungiModificaBungalow(ResortController resortController, Bungalow bungalow)
        {
            this.resortController = resortController;
            this.bungalow = bungalow;
            inEditingMode = true;

            InitializeComponent();

        }

        private void AggiungiModificaBungalow_Load(object sender, EventArgs e)
        {

        }


    }
}
