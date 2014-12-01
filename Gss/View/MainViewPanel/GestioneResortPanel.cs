using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.View.MainViewPanel
{
    public partial class GestioneResortPanel : System.Windows.Forms.UserControl
    {
        public GestioneResortPanel()
        {
            InitializeComponent();
        }

        public GestioneResortPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");
            bungalowsDataGridView.Rows.Add(" Bungalow 21 - Doppia + Doppia + Singola");

            impiantiDataGridView.Rows.Add(" Impianto 1 - Nomeee - Versante Est ");
            impiantiDataGridView.Rows.Add(" Impianto 1 - Nomeee - Versante Est ");
            impiantiDataGridView.Rows.Add(" Impianto 1 - Nomeee - Versante Est ");
            impiantiDataGridView.Rows.Add(" Impianto 1 - Nomeee - Versante Est ");
            impiantiDataGridView.Rows.Add(" Impianto 1 - Nomeee - Versante Est ");
            impiantiDataGridView.Rows.Add(" Impianto 1 - Nomeee - Versante Est ");
            impiantiDataGridView.Rows.Add(" Impianto 1 - Nomeee - Versante Est ");
            impiantiDataGridView.Rows.Add(" Impianto 1 - Nomeee - Versante Est ");
            impiantiDataGridView.Rows.Add(" Impianto 1 - Nomeee - Versante Est ");
            impiantiDataGridView.Rows.Add(" Impianto 1 - Nomeee - Versante Est ");
        }
    }
}
