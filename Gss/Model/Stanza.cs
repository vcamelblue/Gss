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
        private int _numeroPostiMin;
        private int _numeroPostiMax;

        public Stanza(int numeroPostiStandard, int numeroPostiMin, int numeroPostiMax)
        {
            _numeroPostiStandard = numeroPostiStandard;
            _numeroPostiMax = numeroPostiMax;
            _numeroPostiMin = numeroPostiMin;
        }

        public int NumeroPostiStandard
        {
            get { return _numeroPostiStandard; }
            set { _numeroPostiStandard = value; }
        }

        public int NumeroPostiMin
        {
            get { return _numeroPostiMin; }
            set { _numeroPostiMin = value; }
        }

        public int NumeroPostiMax
        {
            get { return _numeroPostiMax; }
            set { _numeroPostiMax = value; }
        }
    }
}
