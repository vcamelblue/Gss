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

        public int postiTotaliStandard()
        {
            int postiTotaliStandard = 0;
            foreach (Stanza s in Stanze)
            {
                postiTotaliStandard += s.NumeroPostiStandard;
            }
            return postiTotaliStandard;
        }

        public int postiTotaliMax()
        {
            int postiTotaliMax = 0;
            foreach (Stanza s in Stanze)
            {
                postiTotaliMax += s.NumeroPostiMax;
            }
            return postiTotaliMax;
        }

        public int postiTotaliMin()
        {
            int postiTotaliMin = 0;
            foreach (Stanza s in Stanze)
            {
                postiTotaliMin += s.NumeroPostiMin;
            }
            return postiTotaliMin;
        }

        public int getNumeroStanze()
        {
            return Stanze.Count;
        }

        public void add(Stanza stanza)
        {
            Stanze.Add(stanza);
        }

        public bool remove(Stanza stanza)
        {
            if (Stanze.Count == 1) return false;
            else return Stanze.Remove(stanza);
        }
    }
}
