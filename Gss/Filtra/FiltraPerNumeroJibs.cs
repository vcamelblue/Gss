using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Filtra 
{
    public class FiltraPerNumeroJibs : IFiltra
    {
        private int _numeroJibsToFilter;

        public FiltraPerNumeroJibs(int numeroJibs)
        {
            _numeroJibsToFilter = numeroJibs;
        }

        public int NumeroJibsToFilter
        {
            get { return _numeroJibsToFilter; }
            set { _numeroJibsToFilter = value; }
        }

        public Impianti Filtra(Impianti impianti)
        {
            Impianti result = new Impianti();

            foreach (Impianto i in impianti.ListaImpianti)
            {
                foreach (Pista p in i.Piste)
                {
                    if (p is SnowPark)
                    {
                        SnowPark snowpark = (SnowPark)p;
                        if (snowpark.NumeroJibs >= NumeroJibsToFilter)
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
