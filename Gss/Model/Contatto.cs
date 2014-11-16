using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class Contatto
    {
        private string _tipo;
        private string _valore;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public string Valore
        {
            get { return _valore; }
            set { _valore = value; }
        }

    }
}
