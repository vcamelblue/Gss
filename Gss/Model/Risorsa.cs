using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    abstract class Risorsa
    {
        private string _codice;

        public Risorsa(string codice)
        {
            _codice = codice;
        }

        public PrezziRisorsa GetPrezzo(GestorePeriodi gestorePeriodi, DateTime data)
        {
            Periodo periodo = gestorePeriodi.GetPeriodoByData(data);
            return periodo.Profilo.GetPrezziRisorsa(this);
        }






        public string Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }
    }
}
