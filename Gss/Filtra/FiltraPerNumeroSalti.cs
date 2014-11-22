using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Filtra
{
    class FiltraPerNumeroSalti : IFiltra
    {
        private int _numeroSalti;

        public FiltraPerNumeroSalti(int numeroSalti)
        {
            _numeroSalti = numeroSalti;
        }

        public int NumeroSalti
        {
            get { return _numeroSalti; }
            set { _numeroSalti = value; }
        }

        public Impianti Filtra(Impianti impianti)
        {
            throw new NotImplementedException();
        }
    }
}
