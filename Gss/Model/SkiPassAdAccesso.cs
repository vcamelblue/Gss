using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class SkiPassAdAccesso : SkiPass
    {
        private int _nAccessi;
        private DateTime _dataRilascio;

        public SkiPassAdAccesso(string codice, Impianto impianto, int nAccessi, DateTime dataRilascio)
            : base(codice, impianto)
        {
            _nAccessi = nAccessi;
            _dataRilascio = dataRilascio;
        }

        public int NAccessi
        {
            get { return _nAccessi; }
            set { _nAccessi = value; }
        }

        public DateTime DataRilascio
        {
            get { return _dataRilascio; }
            set { _dataRilascio = value; }
        }

        public override double GetPrezzoSkiPass()
        {
            Periodo periodo = GestorePeriodi.GetInstance().getPeriodoByData(DataRilascio);
            PrezziRisorsa prezziRisorsa = periodo.Profilo.GetPrezziRisorsa(Impianto);
            return NAccessi * prezziRisorsa.GetPrezzoByTipologia(TipologiaPrezzo.PrezzoPerAccesso).Valore;  
        }
    }
}
