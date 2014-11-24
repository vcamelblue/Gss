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
            if (base.Equals(obj) && obj is Alpina)
            {
                alpina = (Alpina)obj;
            }
            else
                return false;
            if (alpina.Difficolta.Equals(this.Difficolta))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return base.ToString()+" "+ this.Difficolta.ToString();
        }

    }
}
