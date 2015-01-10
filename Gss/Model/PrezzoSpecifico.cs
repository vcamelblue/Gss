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
        private double _prezzo;

        public PrezzoSpecifico(TipologiaPrezzo tipologia, double prezzo)
        {
            _tipologia = tipologia;
            _prezzo = prezzo;
        }

        public TipologiaPrezzo Tipologia
        {
            get { return _tipologia; }
            set { _tipologia = value; }
        }
        public double Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
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

            return (this.Tipologia == p.Tipologia && p.Prezzo == p.Prezzo);
        }

    }
}
