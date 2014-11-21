using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    abstract class SkiPass
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

        abstract public double prezzoSkiPass();


        public override bool Equals(object obj)
        {
            SkiPass skipass = null;

            if (obj is SkiPass)
            {
                skipass = (SkiPass)obj;
            }
            else return false;

            if (this.Codice.Equals(skipass.Codice))
            {
                return true;
            }

            else return false;
        }

    }
}
