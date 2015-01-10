using Gss.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Filtra
{
    public class FiltraPerNome : IFiltra
    {
        private string _nameToFinder;

        public FiltraPerNome(String nome)
        {
            _nameToFinder = nome;
        }

        public string NameToFinder
        {
            get { return _nameToFinder; }
            set { _nameToFinder = value; }
        }

        public Impianti Filtra(Impianti impianti)
        {
            Impianti result = new Impianti();

           /* foreach (Impianto i in impianti.ListaImpianti)
            {
                if (i.Nome.IndexOf(NameToFinder, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    result.Add(i);
                }
            }

            return result;*/


            result.ListaImpianti = (from impianto in impianti.ListaImpianti
                        where impianto.Nome == NameToFinder
                         select impianto).ToList<Impianto>();

            return result;

        }
    }
}
