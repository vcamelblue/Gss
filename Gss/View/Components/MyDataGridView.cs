using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.View.Components {
    public partial class MyDataGridView : System.Windows.Forms.DataGridView
    {
        public MyDataGridView() 
        {
            InitializeComponent();
        }

        public MyDataGridView(IContainer container) 
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
