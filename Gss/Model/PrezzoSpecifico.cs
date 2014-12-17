using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class PrezzoSpecifico
    {
       
        private TipologiaPrezzo _tipologia;
        private double _valore;

        public PrezzoSpecifico(TipologiaPrezzo tipologia, double valore)
        {
            _tipologia = tipologia;
            _valore = valore;
        }

        public TipologiaPrezzo Tipologia
        {
            get { return _tipologia; }
            set { _tipologia = value; }
        }
        public double Valore
        {
            get { return _valore; }
            set { _valore = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrezzoSpecifico p = null;

            if (obj is PrezzoSpecifico)
                p = (PrezzoSpecifico)obj;
            else
                return false;

            return (this.Tipologia == p.Tipologia && p.Valore == p.Valore);
        }

    }
}
