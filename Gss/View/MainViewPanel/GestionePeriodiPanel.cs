using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Controller;

namespace Gss.View.MainViewPanel
{
    public partial class GestionePeriodiPanel : System.Windows.Forms.UserControl
    {
        private PeriodiProfiliController periodiProfiliController;

        public GestionePeriodiPanel()
        {
            InitializeComponent();
        }

        public GestionePeriodiPanel(IContainer container,PeriodiProfiliController periodiProfiliController)
        {
            this.periodiProfiliController = periodiProfiliController;
            container.Add(this);

            InitializeComponent();
        }

        private void impostaPeriodiButton_Click(object sender, EventArgs e)
        {
            AggiungiModificaPeriodi aggiungiPeriodiForm = new AggiungiModificaPeriodi(periodiProfiliController);
            aggiungiPeriodiForm.Show();
        }

        private void modificaPeriodiButton_Click(object sender, EventArgs e)
        {
            AggiungiModificaPeriodi modificaPeriodiForm = new AggiungiModificaPeriodi(periodiProfiliController, periodiProfiliController.GetAllPeriodi());
            modificaPeriodiForm.Show();
        }

        private void rimuoviTuttiIPeriodiButton_Click(object sender, EventArgs e)
        {

        }
    }
}
