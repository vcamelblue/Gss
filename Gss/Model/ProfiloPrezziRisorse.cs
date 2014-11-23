using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class ProfiloPrezziRisorse
    {
        private string _nome;
        private Dictionary<Risorsa, PrezziRisorsa> _prezziRisorsa;

        public ProfiloPrezziRisorse(string nome)
        {
            _nome = nome;
            _prezziRisorsa = new Dictionary<Risorsa, PrezziRisorsa>();
        }

        internal Dictionary<Risorsa, PrezziRisorsa> PrezziRisorsa
        {
            get { return _prezziRisorsa; }
            set { _prezziRisorsa = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

      

        public void Add(Risorsa risorsa, PrezziRisorsa prezziRisorsa)
        {
            _prezziRisorsa.Add(risorsa, prezziRisorsa);
        }

        public bool Remove(Risorsa risorsa)
        {
            return _prezziRisorsa.Remove(risorsa);
        }

        public PrezziRisorsa GetPrezziRisorsa(Risorsa risorsa)
        {
            return _prezziRisorsa[risorsa];
        }
    }
}
