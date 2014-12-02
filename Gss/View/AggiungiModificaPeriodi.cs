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

namespace Gss.View 
{
    public partial class AggiungiModificaPeriodi : Form 
	{
        private PeriodiProfiliController periodiProfiliController;
        private List<Periodo> periodi;
        private bool inEditMode;

        public AggiungiModificaPeriodi(PeriodiProfiliController periodiProfiliController) 
		{
            this.periodiProfiliController = periodiProfiliController;
            this.periodi = new List<Periodo>();
            inEditMode = false;
            InitializeComponent();
        }

        public AggiungiModificaPeriodi(PeriodiProfiliController periodiProfiliController,List<Periodo> periodi)
        {
            this.periodiProfiliController = periodiProfiliController;
            this.periodi = periodi;
            inEditMode = true;

            InitializeComponent();

            this.Text = "Modifica Periodi";
            this.salvaButton.Text = "Salva Modifiche";
        }

        private void RiempiGrigliaPeriodi()
        {
            periodiDataGridView.Rows.Clear();
            //foreach(Periodo p in periodiProfiliController)
        }

        public override void Refresh()
        {
            base.Refresh();
            RiempiGrigliaPeriodi();
        }

        private void AggiungiModificaPeriodi_Load(object sender, EventArgs e)
        {
            if (inEditMode)
            {
                RiempiGrigliaPeriodi();
            }
        }


    }
}
