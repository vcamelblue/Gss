using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    using System;

    public abstract class Pista
    {
        private string _nome;

        public Pista(string nome)
        {
            _nome = nome;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

    }
}
