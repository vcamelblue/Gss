using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class SkiCards
    {
        private List<SkiCard> _listaSkiCard;

        public SkiCards()
        {
            _listaSkiCard = new List<SkiCard>();
        }

        public bool Add(SkiCard skicard)
        {
            foreach (SkiCard s in ListaSkiCard)
            {
                if(s.Equals(skicard))
                {
                    return false;
                }
            }
            ListaSkiCard.Add(skicard);
            return true;
        }

        public bool Remove(SkiCard skicard)
        {
            return ListaSkiCard.Remove(skicard);
        }

        public double GetPrezzoTotale()
        {
            double result = 0;

            foreach (SkiCard s in ListaSkiCard)
            {
                result = +s.GetPrezzoSkicard();
            }

            return result;
        }

        public List<SkiCard> ListaSkiCard
        {
            get { return _listaSkiCard; }
            set { _listaSkiCard = value; }
        }

    }
}
