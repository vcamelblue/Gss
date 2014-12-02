using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Model
{
    public class SnowPark : Pista
    {
        private int _numeroSalti;
        private int _numeroJibs;

        public SnowPark (string nome, int numeroSalti, int numeroJibs) 
            : base(nome)
        {
            _numeroSalti = numeroSalti;
            _numeroJibs = numeroJibs;
        }

        public int NumeroSalti
        {
            get { return _numeroSalti; }
            set { _numeroSalti = value; }
        }

        public int NumeroJibs
        {
            get { return _numeroJibs; }
            set { _numeroJibs = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            SnowPark snowpark = null;

            if (obj is SnowPark && base.Equals(obj))
                snowpark = (SnowPark)obj;
            else
                return false;

            return (snowpark.NumeroSalti.Equals(this.NumeroSalti) && snowpark.NumeroJibs.Equals(this.NumeroJibs));

        }

        public override string ToString()
        {
            return base.ToString() + " " + this.NumeroSalti.ToString() + " " + this.NumeroJibs.ToString();
        }

        public override object Clone()
        {
            string nome = this.Nome;
            int numerosalti= this.NumeroSalti;
            int numeroJibs = this.NumeroJibs;

            return new SnowPark(nome, numerosalti, numeroJibs);
        }
    }
}
