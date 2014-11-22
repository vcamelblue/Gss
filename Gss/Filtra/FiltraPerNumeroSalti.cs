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
        private int _numeroSaltiToFilter;

        public FiltraPerNumeroSalti(int numeroSalti)
        {
            _numeroSaltiToFilter = numeroSalti;
        }

        public int NumeroSaltiToFilter
        {
            get { return _numeroSaltiToFilter; }
            set { _numeroSaltiToFilter = value; }
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
                        if (snowpark.NumeroSalti == NumeroSaltiToFilter)
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
