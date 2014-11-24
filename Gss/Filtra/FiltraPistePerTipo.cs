using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Filtra
{
    public class FiltraPistePerTipo : IFiltra
    {
        private string _tipoPistaToFilter;

        public string TipoPistaToFilter
        {
            get { return _tipoPistaToFilter; }
            set { _tipoPistaToFilter = value; }
        }
        private int _numeroMinPisteToFilter;

        public FiltraPistePerTipo(int numeroMinPisteToFilter, string tipoPistaToFilter)
        {
            _numeroMinPisteToFilter = numeroMinPisteToFilter;
            _tipoPistaToFilter = tipoPistaToFilter;
        }

        public Impianti Filtra(Impianti impianti)
        {
            return impianti;
        }


    }
}
