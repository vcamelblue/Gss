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
        private int _numeroMinPisteToFilter;


        public FiltraPistePerTipo(int numeroMinPisteToFilter, string tipoPistaToFilter)
        {
            _numeroMinPisteToFilter = numeroMinPisteToFilter;
            _tipoPistaToFilter = tipoPistaToFilter;
        }


        public string TipoPistaToFilter
        {
            get { return _tipoPistaToFilter; }
            set { _tipoPistaToFilter = value; }
        }

        public int NumeroMinPisteToFilter
        {
            get { return _numeroMinPisteToFilter; }
            set { _numeroMinPisteToFilter = value; }
        }


        public Impianti Filtra(Impianti impianti)
        {
            Impianti i = new Impianti();
            
            if(TipoPistaToFilter == "Tutte")
            {
                foreach (Impianto impianto in impianti.ListaImpianti)
                {
                    if (impianto.NumeroPiste() >= NumeroMinPisteToFilter)
                        i.Add(impianto);      
                }

                return i;
            }


            if(TipoPistaToFilter == "Alpina")
            {
                foreach (Impianto impianto in impianti.ListaImpianti)
                {
                    if (impianto.GetPisteAlpine().Count >= NumeroMinPisteToFilter)
                        i.Add(impianto);
                }

                return i;
            }


            if (TipoPistaToFilter == "Fondo")
            {
                foreach (Impianto impianto in impianti.ListaImpianti)
                {
                    if (impianto.GetPisteFondo().Count >= NumeroMinPisteToFilter)
                        i.Add(impianto);
                }

                return i;
            }


            if (TipoPistaToFilter == "SnowPark")
            {
                foreach (Impianto impianto in impianti.ListaImpianti)
                {
                    if (impianto.GetPisteSnowPark().Count >= NumeroMinPisteToFilter)
                        i.Add(impianto);
                }

                return i;
            }

            return i;
        }
    }
}
