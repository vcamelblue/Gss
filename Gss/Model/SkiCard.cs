using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class SkiCard
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

        public bool add(SkiPass skipass)
        {
            foreach (SkiPass s in SkiPass)
            {
                if (s.Equals(skipass))
                {
                    return false;
                }
            }
            SkiPass.Add(skipass);
            return true;
        }

        public bool remove(SkiPass skipass)
        {
            return SkiPass.Remove(skipass);
        }

        public double prezzoSkicard()
        {
            double result = 0;
            foreach (SkiPass s in SkiPass)
            {
                result += s.prezzoSkiPass();
            }
            return result;
        }
    }
}
