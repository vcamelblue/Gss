using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Model
{
    public class Alpina : Pista
    {
        private Difficolta _difficolta;

        public Alpina(string nome, Difficolta difficolta) 
            : base(nome) 
        {
            _difficolta = difficolta;
        }

        public Difficolta Difficolta
        {
            get { return _difficolta; }
            set { _difficolta = value; }
        }
        
        public override bool Equals(object obj)
        {

            Alpina alpina = null;

            if (obj is Alpina && base.Equals(obj))
                alpina = (Alpina)obj;
            else
                return false;

            return alpina.Difficolta.Equals(this.Difficolta);
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.Difficolta.ToString();
        }

        public override object Clone()
        {
            string nome = this.Nome;
            Difficolta difficolta = this.Difficolta;

            return new Alpina(nome, difficolta);
        }
    }
}
