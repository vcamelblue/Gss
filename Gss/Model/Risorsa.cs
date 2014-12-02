using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public abstract class Risorsa : ICloneable
    {
        private string _codice;

        public Risorsa(string codice)
        {
            _codice = codice;
        }

        public PrezziRisorsa GetPrezzoFor(DateTime data)
        {
            Periodo periodo = GestorePeriodi.GetInstance().getPeriodoByData(data);
            if (periodo == null)
                return null;
            return periodo.Profilo.GetPrezziRisorsa(this);
        }

        public string Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Risorsa risorsa;
            if (obj is Risorsa)
            {
                risorsa = (Risorsa)obj;
            }
            else
                return false;
            if (risorsa.Codice == this.Codice)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return this.Codice;
        }

        public abstract object Clone();
    }
}
