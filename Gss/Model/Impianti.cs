using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class Impianti
    {
        private List<Impianto> _impianti;

        public Impianti()
        {
            _impianti = new List<Impianto>();
        }

        public bool Add(Impianto impianto)
        {
            foreach(Impianto i in this.ListaImpianti)
            {
                if (i.Equals(impianto))
                {
                    return false;
                }

            }
            ListaImpianti.Add(impianto);
            return true;
        }

        public bool Remove(Impianto impianto)
        {
            return ListaImpianti.Remove(impianto);
        }

        internal List<Impianto> ListaImpianti
        {
            get { return _impianti; }
            set { _impianti = value; }
        }

        public override string ToString()
        {
            string result = "";
            foreach(Impianto i in this.ListaImpianti)
            {
                result += i.ToString() + "\n \n";
            }
            return result;
        }


    }
}
