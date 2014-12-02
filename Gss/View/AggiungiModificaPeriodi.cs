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
        //Fields

        private PeriodiProfiliController periodiProfiliController;
        private List<Periodo> periodi;
        private bool inEditMode;


        //Constructors

            //New Period Mode
        public AggiungiModificaPeriodi(PeriodiProfiliController periodiProfiliController) 
		{
            this.periodiProfiliController = periodiProfiliController;
            this.periodi = new List<Periodo>();
            inEditMode = false;

            InitializeComponent();
        }
        
            //Edit Periodo Mode
        public AggiungiModificaPeriodi(PeriodiProfiliController periodiProfiliController,List<Periodo> periodi) 
        {
            this.periodiProfiliController = periodiProfiliController;
            this.periodi = periodi;
            inEditMode = true;

            InitializeComponent();

            this.Text = "Modifica Periodi Esistenti";
            this.salvaButton.Text = "Salva Modifiche";
        }


        //Events

        private void AggiungiModificaPeriodi_Load(object sender, EventArgs e)
        {
            if (inEditMode)
            {
                RiempiGrigliaPeriodi();
            }
        }

        private void aggiungiPeriodoButton_Click(object sender, EventArgs e)
        {
            AggiungiModificaPeriodo aggiungiModificaPeriodo = new AggiungiModificaPeriodo(periodiProfiliController, periodi);
            DialogResult result = aggiungiModificaPeriodo.ShowDialog();

            if (result == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void modificaPeriodoButton_Click(object sender, EventArgs e)

        {
            foreach (Periodo periodo in periodi)
            {
                //verifco ogni campo in quanto la equals di profilo è riconoscibile solo su tutti i campi!
                if (selectedPeriodRowIsEqualsTo(periodo))
                {
                    AggiungiModificaPeriodo aggiungiModificaPeriodo = new AggiungiModificaPeriodo(periodiProfiliController, periodi, periodo);
                    DialogResult result = aggiungiModificaPeriodo.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        Refresh();
                    }
                }
            }
        }

        private void rimuoviPeriodoButton_Click(object sender, EventArgs e)
        {
            foreach (Periodo periodo in periodi)
            {
                if (selectedPeriodRowIsEqualsTo(periodo))
                {

                    DialogResult result = MessageBox.Show("Sicuro di voler rimuovere il periodo selezionato?", "Rimozione Periodo", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        periodi.Remove(periodo);
                        Refresh();
                        break;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
            }
        }

        private void salvaButton_Click(object sender, EventArgs e)
        {
            String modificheAiPeriodi = periodiProfiliController.TrySetPeriodi(periodi);

            if (modificheAiPeriodi != "")
            {
                DialogResult result = MessageBox.Show("I periodi inseriti non sono applicabili,\npotrebbero essere apportate le seguenti modifiche:\n" + modificheAiPeriodi + "\n\nvuoi apportare queste modifiche?", "Modifiche Ai Periodi Inseriti", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Refresh();
                    List<Periodo> periodiModificati = periodiProfiliController.SetPeriodi(periodi);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Apportare delle modifiche manualmente per continuare!");
                }
            }
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Methods
        public override void Refresh()
        {
            base.Refresh();
            RiempiGrigliaPeriodi();
        }


        //Private Utility Methods

        private void RiempiGrigliaPeriodi()
        {
            periodiDataGridView.Rows.Clear();
            foreach (Periodo p in periodi)
            {
                periodiDataGridView.Rows.Add(p.Profilo.Nome, p.DataInizio.ToString("d MMMM yyyy"), p.DataFine.ToString("d MMMM yyyy"));
            }
        }

        //verifco ogni campo in quanto la equals di profilo è riconoscibile solo su tutti i campi!
        private bool selectedPeriodRowIsEqualsTo(Periodo periodo)
        {
            return (periodo.Profilo.Nome == periodiDataGridView.SelectedRows[0].Cells[0].Value.ToString()                           &&
                    periodo.DataInizio.ToString("d MMMM yyyy") == periodiDataGridView.SelectedRows[0].Cells[1].Value.ToString()     &&
                    periodo.DataFine.ToString("d MMMM yyyy") == periodiDataGridView.SelectedRows[0].Cells[2].Value.ToString()         );
            
        }
    }
}
