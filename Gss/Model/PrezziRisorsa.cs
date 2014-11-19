using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class PrezziRisorsa
    {
        private double _prezzo;
        private List<PrezzoSpecifico> _prezziSpecifici;

        public PrezziRisorsa(double prezzo, List<PrezzoSpecifico> prezziSpecifici)
        {
            _prezzo = prezzo;
            _prezziSpecifici = new List<PrezzoSpecifico>();
            _prezziSpecifici = prezziSpecifici;
        }

        public double Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        public List<PrezzoSpecifico> PrezziSpecifici
        {
            get { return _prezziSpecifici; }
            set { _prezziSpecifici = value; }
        }

        public bool add(PrezzoSpecifico prezzoSpecifico)
        {
            foreach (PrezzoSpecifico ps in PrezziSpecifici)
            {
                if (ps.Tipologia.Equals(prezzoSpecifico.Tipologia))
                {
                    return false;
                }
            }
            PrezziSpecifici.Add(prezzoSpecifico);
            return true;
        }

        public bool remove(PrezzoSpecifico prezzoSpecifico)
        {
            return PrezziSpecifici.Remove(prezzoSpecifico);
        }

        public Double GetPrezzoByTipologia(TipologiaPrezzo tipologia)
        {
            foreach (PrezzoSpecifico ps in PrezziSpecifici)
            {
                if (ps.Tipologia.Equals(tipologia))
                {
                    return ps.Valore;
                }
            }
            return -1;  // return -1 se non è presente quella tipologia, trattare il caso nelle funzioni sopra
        }
    }
}
