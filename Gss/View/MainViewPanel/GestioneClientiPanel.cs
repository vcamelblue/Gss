using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.View.MainViewPanel
{
    public partial class GestioneClientiPanel : System.Windows.Forms.UserControl
    {
        public GestioneClientiPanel()
        {
            InitializeComponent();
        }

        public GestioneClientiPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
