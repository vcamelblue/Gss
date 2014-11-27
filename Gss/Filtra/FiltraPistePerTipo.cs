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
            Impianti i = new Impianti();
            
            if(this._tipoPistaToFilter=="Tutte")
            {
                foreach (Impianto impianto in impianti.ListaImpianti)
                {
                if (impianto.NumeroPiste() >= this._numeroMinPisteToFilter)
                    i.Add(impianto);      
                }
                return i;
            }
            if(this._tipoPistaToFilter=="Alpina")
            {
                foreach (Impianto impianto in impianti.ListaImpianti)
                {
                    if (impianto.GetPisteAlpine().Count >= this._numeroMinPisteToFilter)
                        i.Add(impianto);
                }
                return i;
            }

            if (this._tipoPistaToFilter == "Fondo")
            {
                foreach (Impianto impianto in impianti.ListaImpianti)
                {
                    if (impianto.GetPisteFondo().Count >= this._numeroMinPisteToFilter)
                        i.Add(impianto);
                }
                return i;
            }

            if (this._tipoPistaToFilter == "SnowPark")
            {
                foreach (Impianto impianto in impianti.ListaImpianti)
                {
                    if (impianto.GetPisteSnowPark().Count >= this._numeroMinPisteToFilter)
                        i.Add(impianto);
                }
                return i;
            }
            return i;
        }


    }
}
