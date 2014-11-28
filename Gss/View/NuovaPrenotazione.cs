using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gss.View 
{
    public partial class NuovaPrenotazione : Form 
	{
        //Location del tasto annulla:
        //in tab clienti:  (290, 503)
        //Altrove:         (35, 503)

        public NuovaPrenotazione() 
		{
            InitializeComponent();
            clientiDataGridView.Rows.Add("Pasquale il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");
            clientiDataGridView.Rows.Add("antonio il frocio");


            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");
            bungalowDisponibiliDataGridView.Rows.Add("sdfsdf", "uweasas", "siefjasd", "33", "544", "23 €");

            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
            skicardsDataGridView.Rows.Add("uweasas", "siefjasd", "33", "544", "23 €");
        }

        private void clienteTabButton_Click(object sender, EventArgs e)
        {

            tabControlWithoutHeader.SelectedIndex = (tabControlWithoutHeader.SelectedIndex + 1 < tabControlWithoutHeader.TabCount) ?
                             tabControlWithoutHeader.SelectedIndex + 1 : tabControlWithoutHeader.SelectedIndex;
        }
    }
}
