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
        private double _dislivelloMedio;

        public Fondo(string nome, double dislivelloMassimo, double dislivelloMedio) 
            : base(nome) 
        {
            _dislivelloMassimo = dislivelloMassimo;
            _dislivelloMedio = dislivelloMedio;
        }

        public double DislivelloMassimo
        {
            get { return _dislivelloMassimo; }
            set { _dislivelloMassimo = value; }
        }

        public double DislivelloMedio
        {
            get { return _dislivelloMedio; }
            set { _dislivelloMedio = value; }
        }

    }
}
