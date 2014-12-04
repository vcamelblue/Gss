using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class SkiPassAdAccesso : SkiPass
    {
        private int _numeroAccessi;
        private DateTime _dataRilascio;

        public SkiPassAdAccesso(string codice, Impianto impianto, int numeroAccessi, DateTime dataRilascio)
            : base(codice, impianto)
        {
            _numeroAccessi = numeroAccessi;
            _dataRilascio = dataRilascio;
        }

        public int NumeroAccessi
        {
            get { return _numeroAccessi; }
            set { _numeroAccessi = value; }
        }

        public DateTime DataRilascio
        {
            get { return _dataRilascio; }
            set { _dataRilascio = value; }
        }

        public override double GetPrezzoSkiPass()
        {
            
            Periodo periodo = GestorePeriodi.GetInstance().getPeriodoByData(DataRilascio);

            if (periodo == null)
            {
                throw new Exception("Impossibile Trovare Il prezzo per lo skipass nel periodo specificato!");
            }

            PrezziRisorsa prezziSkipass = periodo.Profilo.GetPrezziRisorsa(Impianto);

            if (prezziSkipass == null)
            {
                throw new Exception("Impossibile Trovare Il prezzo per lo skipass nel periodo specificato!");
            }

            PrezzoSpecifico prezzoPerAccessoSkipass = prezziSkipass.GetPrezzoByTipologia(TipologiaPrezzo.PrezzoPerAccesso);
            
            if (prezzoPerAccessoSkipass == null)
            {
                throw new Exception("Impossibile Trovare Il prezzo per lo skipass nel periodo specificato!");
            }

            return NumeroAccessi * prezzoPerAccessoSkipass.Valore;
        }
    }
}
