using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class PrezziRisorsa : ICloneable
    {
        private double _prezzo;
        private List<PrezzoSpecifico> _prezziSpecifici;

        public PrezziRisorsa(double prezzo, List<PrezzoSpecifico> prezziSpecifici)
        {
            _prezzo = prezzo;
            _prezziSpecifici = prezziSpecifici;
        }

        public PrezziRisorsa()
            : this(0, new List<PrezzoSpecifico>())
        {
            
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

        //Aggiungo solo prezzi specifici con tipologie diverse
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
            return null;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrezziRisorsa p = null;

            if (obj is PrezziRisorsa)
                p = (PrezziRisorsa)obj;
            else
                return false;

            return (this.Prezzo == p.Prezzo && p.PrezziSpecifici.Equals(p.PrezziSpecifici));
        }
        
        public object Clone()
        {
            PrezziRisorsa result = new PrezziRisorsa(this.Prezzo, new List<PrezzoSpecifico>());

            foreach (PrezzoSpecifico p in this.PrezziSpecifici)
            {
                result.PrezziSpecifici.Add(new PrezzoSpecifico(p.Tipologia, p.Valore));
            }

            return result;
        }
    }
}
