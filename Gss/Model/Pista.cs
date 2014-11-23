using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    abstract class Pista
    {
        private string _nome;

        public Pista(string nome)
        {
            _nome = nome;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Pista pista = null;
            if (obj is Pista)
            {
                pista = (Pista)obj;
            }
            else return false;

            if (pista.Nome == this.Nome)
                return true;
            else
                return false;
        }
    }
}
