using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class SkiCard
    {
        private string _codice;
        private List<SkiPass> _skiPass;

        public SkiCard(string codice)
        {
            _codice = codice;
            _skiPass = new List<SkiPass>();
        }

        public string Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        public List<SkiPass> SkiPass
        {
            get { return _skiPass; }
            set { _skiPass = value; }
        }

        public bool Add(SkiPass skipass)
        {
            if (SkiPass.Contains(skipass))
                return false;

            SkiPass.Add(skipass);

            return true;
        }

        public bool Remove(SkiPass skipass)
        {
            return SkiPass.Remove(skipass);
        }

        public double GetPrezzoSkicard()
        {
            double result = 0;

            foreach (SkiPass s in SkiPass)
            {
                result += s.GetPrezzoSkiPass();
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            SkiCard skicard = null;

            if (obj is SkiCard)
            {
                skicard = (SkiCard)obj;
            }
            else 
                return false;

            if (this.Codice != skicard.Codice)
                return false;

            if (this.SkiPass.Count != skicard.SkiPass.Count)
                return false;

            foreach (SkiPass s in this.SkiPass)
            {
                if (!skicard.SkiPass.Contains(s))
                    return false;
            }
            
            return true;

        }

        public int GetNumeroSkiPassAGiornata()
        {
            int result=0;

            foreach(SkiPass s in this.SkiPass)
            {
                if (s is SkiPassAGiornata)
                    result++;
            }
            return result;
        }

        public int GetNumeroSkiPassAdAccesso()
        {
            int result = 0;

            foreach (SkiPass s in this.SkiPass)
            {
                if (s is SkiPassAdAccesso)
                    result++;
            }
            return result;
        }
    }
}
