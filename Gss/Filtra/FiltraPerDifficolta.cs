using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Filtra
{
    class FiltraPerDifficolta :IFiltra
    {
        private Difficolta _difficoltaToFilter;

        public FiltraPerDifficolta(Difficolta difficolta)
        {
            _difficoltaToFilter = difficolta;
        }

        public Difficolta DifficoltaToFilter
        {
            get { return _difficoltaToFilter; }
            set { _difficoltaToFilter = value; }
        }

        public Impianti Filtra(Impianti impianti)
        {
            Impianti result = new Impianti();

            foreach (Impianto i in impianti.ListaImpianti)
            {
                foreach (Pista p in i.Piste)
                {
                    if (p is Alpina)
                    {
                        Alpina alpina = (Alpina)p;
                        if (alpina.Difficolta == DifficoltaToFilter)
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
