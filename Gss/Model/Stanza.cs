using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class Stanza : ICloneable
    {
        private int _numeroPostiStandard;
        private int _numeroPostiMax;

        public int NumeroPostiMax
        {
            get { return _numeroPostiMax; }
            set { _numeroPostiMax = value; }
        }

        public int NumeroPostiStandard
        {
            get { return _numeroPostiStandard; }
            set { _numeroPostiStandard = value; }
        }

        public Stanza(int numeroPostiStandard, int numeroPostiMax)
        {
            _numeroPostiStandard = numeroPostiStandard;
            _numeroPostiMax = numeroPostiMax;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Stanza stanza = null;

            if (obj is Stanza)
                stanza = (Stanza)obj;
            else
                return false;

            return (stanza.NumeroPostiStandard == this.NumeroPostiStandard &&
                    stanza.NumeroPostiMax == this.NumeroPostiMax );
        }

        public object Clone()
        {
            return new Stanza(NumeroPostiStandard, NumeroPostiMax);
        }

        public override string ToString()
        {
            return (NumeroPostiStandard == 1 ? "Singola" :
                    NumeroPostiStandard == 2 ? "Doppia" :
                    NumeroPostiStandard == 3 ? "Tripla" :
                    NumeroPostiStandard == 4 ? "Quadrupla" :
                    NumeroPostiStandard == 5 ? "Quintupla" : NumeroPostiStandard+"upla");
        }
    }
}
