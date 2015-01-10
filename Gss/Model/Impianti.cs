using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class Impianti
    {
        private List<Impianto> _impianti;

        public Impianti()
        {
            _impianti = new List<Impianto>();
        }

        public List<Impianto> ListaImpianti
        {
            get { return _impianti; }
            set { _impianti = value; }
        }

        public bool Add(Impianto impianto)
        {

            if (this.ListaImpianti.Contains(impianto))
                return false;

            ListaImpianti.Add(impianto);

            return true;
        }

        public bool Remove(Impianto impianto)
        {
            return ListaImpianti.Remove(impianto);
        }

        

        public override string ToString()
        {
            string result = "";

            foreach(Impianto i in this.ListaImpianti)
            {
                result += i.ToString() + "\n\n";
            }

            return result;
        }

        public Impianto GetImpiantoByCodice(string codice)
        {
            foreach(Impianto i in this.ListaImpianti)
            {
                if(i.Codice==codice)
                    return i;
            }

            return null;
        }


    }
}
