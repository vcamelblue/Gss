using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class PrezziRisorsa
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

        public bool Add(PrezzoSpecifico prezzoSpecifico)
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

        public bool Remove(PrezzoSpecifico prezzoSpecifico)
        {
            return PrezziSpecifici.Remove(prezzoSpecifico);
        }

        public PrezzoSpecifico GetPrezzoByTipologia(TipologiaPrezzo tipologia)
        {
            foreach (PrezzoSpecifico ps in PrezziSpecifici)
            {
                if (ps.Tipologia.Equals(tipologia))
                {
                    return ps;
                }
            }
            return null; // trattare il null nelle funzioni sopra
        }
    }
}
