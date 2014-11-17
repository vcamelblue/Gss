using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class Stanza
    {
        private int _numeroPostiStandard;
        private int _numeroPostiMax;

        public Stanza(int numeroPostiStandard, int numeroPostiMax)
        {
            _numeroPostiStandard = numeroPostiStandard;
            _numeroPostiMax = numeroPostiMax;
        }

        public int NumeroPostiStandard
        {
            get { return _numeroPostiStandard; }
            set { _numeroPostiStandard = value; }
        }

        public int NumeroPostiMax
        {
            get { return _numeroPostiMax; }
            set { _numeroPostiMax = value; }
        }
    }
}
