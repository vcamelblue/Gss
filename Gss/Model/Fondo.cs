using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Model
{
    public class Fondo : Pista
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

        public override bool Equals(object obj)
        {
            Fondo fondo = null;

            if (obj is Fondo && base.Equals(obj))
                fondo = (Fondo)obj;
            else
                return false;

            return (fondo.DislivelloMedio.Equals(this.DislivelloMedio) && fondo.DislivelloMassimo.Equals(this.DislivelloMassimo));

        }

        public override string ToString()
        {
            return base.ToString()+ " " + this.DislivelloMassimo.ToString() + " " + this.DislivelloMedio.ToString();
        }

        public override object Clone()
        {
            string nome = this.Nome;
            double dislivelloMedio = this.DislivelloMedio;
            double dislivelloMassimo = this.DislivelloMassimo;

            return new Fondo(nome, dislivelloMassimo, dislivelloMedio);
        }
    }
}
