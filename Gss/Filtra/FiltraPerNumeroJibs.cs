using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Filtra 
{
    class FiltraPerNumeroJibs : IFiltra
    {
        private int _numeroJibs;

        public FiltraPerNumeroJibs(int numeroJibs)
        {
            _numeroJibs = numeroJibs;
        }

        public int NumeroJibs
        {
            get { return _numeroJibs; }
            set { _numeroJibs = value; }
        }

        public Impianti Filtra(Impianti impianti)
        {
            throw new NotImplementedException();
        }
    }
}
