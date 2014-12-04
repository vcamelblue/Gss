using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Model
{
    public abstract class SkiPass
    {
        private string _codice;
        private Impianto _impianto;

        public SkiPass(string codice, Impianto impianto)
        {
            _codice = codice;
            _impianto = impianto;
        }

        public string Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        public Impianto Impianto
        {
            get { return _impianto; }
            set { _impianto = value; }
        }

        abstract public double GetPrezzoSkiPass();


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            SkiPass skipass = null;

            if (obj is SkiPass)
            {
                skipass = (SkiPass)obj;
            }
            else return false;

            return (this.Codice == skipass.Codice && this.Impianto.Equals(skipass.Impianto));
        }

    }
}
