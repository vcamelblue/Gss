using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Filtra
{
    class FiltraPerDislivelloMedio : IFiltra
    {
        private double _dislivelloMedio;

        public FiltraPerDislivelloMedio(double dislivelloMedio)
        {
            _dislivelloMedio = dislivelloMedio;
        }

        public double DislivelloMedio
        {
            get { return _dislivelloMedio; }
            set { _dislivelloMedio = value; }
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
                        if (fondo.DislivelloMedio == DislivelloMedio )
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
