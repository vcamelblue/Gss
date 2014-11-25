using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.View.Components 
{
    public partial class MyComboBox : System.Windows.Forms.ComboBox 
    {
        public MyComboBox() 
        {
            InitializeComponent();
        }

        public MyComboBox(IContainer container) 
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
