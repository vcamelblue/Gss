using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class Bungalows
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

        public bool Add(Bungalow bungalow)
        {

            if (this.ListaBungalow.Contains(bungalow))
                return false;

            ListaBungalow.Add(bungalow);

            return true;
        }

        public bool Remove(Bungalow bungalow)
        {
            return this.ListaBungalow.Remove(bungalow);
        }

        public Bungalows GetBungalowConPostiAlmeno(int n)
        {
            Bungalows result = new Bungalows();

            foreach (Bungalow b in ListaBungalow)
            {
                if (b.PostiTotaliStandard() >= n)
                    result.Add(b);
            }

            return result;
        }

        public Bungalows GetBungalowConMaxPostiAlmeno(int n)
        {
            Bungalows result = new Bungalows();

            foreach (Bungalow b in ListaBungalow)
            {
                if (b.PostiTotaliMax() >= n)
                    result.Add(b);
            }

            return result;
        }

        public Bungalow GetBungalowByCodice(string codice)
        {
            foreach (Bungalow b in this.ListaBungalow)
            {
                if (b.Codice == codice)
                    return b;
            }

            return null;
        }

        public override string ToString()
        {
            string result = "";

            foreach(Bungalow b in this.ListaBungalow)
            {
                result += b.ToString() + "\n";
            }

            return result;
        }
        
    }
}
