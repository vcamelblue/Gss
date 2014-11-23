using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacceProgramma.Components {
    public partial class MyButton : System.Windows.Forms.Button {
        public MyButton() {
            InitializeComponent();
        }

        public MyButton(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }
    }
}
