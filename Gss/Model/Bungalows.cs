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

        public void Add(Bungalow bungalow)
        {
            ListaBungalow.Add(bungalow);
        }

        public bool Remove(Bungalow bungalow)
        {
            return ListaBungalow.Remove(bungalow);
        }

        public Bungalows GetBungalowConPostiAlmeno(int n)
        {
            Bungalows result = new Bungalows();
            foreach (Bungalow b in ListaBungalow)
            {
                if (b.PostiTotaliStandard() >= n)
                {
                    result.Add(b);
                }
            }
            return result;
        }

        public Bungalows GetBungalowConMaxPostiAlmeno(int n)
        {
            Bungalows result = new Bungalows();
            foreach (Bungalow b in ListaBungalow)
            {
                if (b.PostiTotaliMax() >= n)
                {
                    result.Add(b);
                }
            }
            return result;
        }

    }
}
