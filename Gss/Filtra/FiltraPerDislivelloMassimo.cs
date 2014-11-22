using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Filtra
{
    class FiltraPerDislivelloMassimo : IFiltra
    {
        private double _dislivelloMassimoToFilter;

        public FiltraPerDislivelloMassimo(double dislivelloMassimo)
        {
            _dislivelloMassimoToFilter = dislivelloMassimo;
        }

        public double DislivelloMassimoToFilter
        {
            get { return _dislivelloMassimoToFilter; }
            set { _dislivelloMassimoToFilter = value; }
        }

        public Impianti Filtra(Impianti impianti)
        {
            Impianti result = new Impianti();

            foreach (Impianto i in impianti.ListaImpianti)
            {
                foreach (Pista p in i.Piste)
                {
                    if (p is Fondo)
                    {
                        Fondo fondo = (Fondo)p;
                        if (fondo.DislivelloMassimo == DislivelloMassimoToFilter)
                        {
                            result.Add(i);
                        }
                        break;
                    }
                }
            }

            return result;
        }
    }
}
