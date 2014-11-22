using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Filtra
{
    class FiltraPerPrezzoAccesso : IFiltra
    {
        private double _prezzoToFilter;

        public FiltraPerPrezzoAccesso(double prezzo)
        {
            _prezzoToFilter = prezzo;
        }

        public double PrezzoToFilter
        {
            get { return _prezzoToFilter; }
            set { _prezzoToFilter = value; }
        }

        public Impianti Filtra(Impianti impianti)
        {
            throw new NotImplementedException();
        }
    }
}
