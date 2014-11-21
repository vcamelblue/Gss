using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class Bungalow : Risorsa
    {
        private List<Stanza> _stanze;

        public Bungalow(string codice) 
            : base(codice)
        {
            _stanze = new List<Stanza>();
        }

        public List<Stanza> Stanze
        {
            get { return _stanze; }
            set { _stanze = value; }
        }

        public int PostiTotaliStandard()
        {
            int postiTotaliStandard = 0;
            foreach (Stanza s in Stanze)
            {
                postiTotaliStandard += s.NumeroPostiStandard;
            }
            return postiTotaliStandard;
        }

        public int PostiTotaliMax()
        {
            int postiTotaliMax = 0;
            foreach (Stanza s in Stanze)
            {
                postiTotaliMax += s.NumeroPostiMax;
            }
            return postiTotaliMax;
        }

        public int GetNumeroStanze()
        {
            return Stanze.Count;
        }

        public void Add(Stanza stanza)
        {
            Stanze.Add(stanza);
        }

        public bool Remove(Stanza stanza)
        {
            if (Stanze.Count == 1) return false;
            else return Stanze.Remove(stanza);
        }
    }
}
