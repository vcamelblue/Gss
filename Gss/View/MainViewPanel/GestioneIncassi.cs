using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.View.MainViewPanel
{
    public partial class GestioneIncassi : System.Windows.Forms.UserControl
    {
        public GestioneIncassi()
        {
            InitializeComponent();
        }

        public GestioneIncassi(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
