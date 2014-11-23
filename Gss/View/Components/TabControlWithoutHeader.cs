using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gss.View.Components {
    public partial class TabControlWithoutHeader : TabControl {
        public TabControlWithoutHeader() {
            InitializeComponent();
        }

        public TabControlWithoutHeader(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }

        //Function to remove header from tabControl
        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x1328 && !DesignMode) //remove ! to hide also in designer
                m.Result = (IntPtr)1;
            else
                base.WndProc(ref m);
        }
    }
}
