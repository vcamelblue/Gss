using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Filtra
{
    class FiltraPerDislivelloMedio : IFiltra
    {
        private double _dislivelloMedio;

        public FiltraPerDislivelloMedio(double dislivelloMedio)
        {
            _dislivelloMedio = dislivelloMedio;
        }

        public double DislivelloMedio
        {
            get { return _dislivelloMedio; }
            set { _dislivelloMedio = value; }
        }

        public Impianti Filtra(Impianti impianti)
        {
            throw new NotImplementedException();
        }
    }
}
