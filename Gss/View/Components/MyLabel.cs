using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.View.Components {
    public partial class MyLabel : System.Windows.Forms.Label {
        public MyLabel() {
            InitializeComponent();
        }

        public MyLabel(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }
    }
}
