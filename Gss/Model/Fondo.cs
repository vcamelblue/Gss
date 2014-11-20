using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model.Pista;

namespace Gss.Model
{
    class Fondo : Pista
    {

        private double _dislivelloMassimo;
        private double _dislivelloMinimo;

        public Fondo(string nome, double dislivelloMassimo, double dislivelloMinimo) 
            : base(nome) 
        {
            _dislivelloMassimo = dislivelloMassimo;
            _dislivelloMinimo = dislivelloMinimo;
        }

        public double DislivelloMassimo
        {
            get { return _dislivelloMassimo; }
            set { _dislivelloMassimo = value; }
        }

        public double DislivelloMinimo
        {
            get { return _dislivelloMinimo; }
            set { _dislivelloMinimo = value; }
        }

    }
}
