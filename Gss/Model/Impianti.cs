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

        public void Add(Impianto impianto)
        {
            ListaImpianti.Add(impianto);
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


    }
}
