using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class Bungalows
    {
        private List<Bungalow> _bungalows;

        public Bungalows()
        {
            _bungalows = new List<Bungalow>();
        }

        public List<Bungalow> ListaBungalow
        {
            get { return _bungalows; }
            set { _bungalows = value; }
        }

        public void add(Bungalow bungalow)
        {
            ListaBungalow.Add(bungalow);
        }

        public bool remove(Bungalow bungalow)
        {
            return ListaBungalow.Remove(bungalow);
        }

        public Bungalows getBungalowConPostiAlmeno(int n)
        {
            Bungalows result = new Bungalows();
            foreach (Bungalow b in ListaBungalow)
            {
                if (b.postiTotaliStandard() >= n)
                {
                    result.add(b);
                }
            }
            return result;
        }

        public Bungalows getBungalowConMaxPostiAlmeno(int n)
        {
            Bungalows result = new Bungalows();
            foreach (Bungalow b in ListaBungalow)
            {
                if (b.postiTotaliMax() >= n)
                {
                    result.add(b);
                }
            }
            return result;
        }

    }
}
