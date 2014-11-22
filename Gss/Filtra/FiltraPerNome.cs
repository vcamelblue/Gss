using Gss.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Filtra
{
    class FiltraPerNome : IFiltra
    {
        private string _nameToFinder;

        public FiltraPerNome(String nome)
        {
            _nameToFinder = nome;
        }

        public string NameToFinder
        {
            get { return _nameToFinder; }
            set { _nameToFinder = value; }
        }

        public Impianti Filtra(Impianti impianti)
        {
            throw new NotImplementedException();
        }
    }
}
