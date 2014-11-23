using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class PrezzoSpecifico
    {
       
        private TipologiaPrezzo _tipologia;
        private double _valore;

        public PrezzoSpecifico(TipologiaPrezzo tipologia, double valore)
        {
            _tipologia = tipologia;
            _valore = valore;
        }

        internal TipologiaPrezzo Tipologia
        {
            get { return _tipologia; }
            set { _tipologia = value; }
        }
        public double Valore
        {
            get { return _valore; }
            set { _valore = value; }
        }


    }
}
