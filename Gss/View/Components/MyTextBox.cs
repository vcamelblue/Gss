using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.View.Components {
    public partial class MyTextBox : System.Windows.Forms.TextBox {
        public MyTextBox() {
            InitializeComponent();
        }

        public MyTextBox(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }
    }
}
