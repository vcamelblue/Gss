using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class SkiPassAGiornata : SkiPass
    {
        private DateTime _dataInizio;
        private DateTime _dataFine;

        public SkiPassAGiornata(string codice, Impianto impianto, DateTime dataInizio, DateTime dataFine)
            : base(codice, impianto)
        {
            _dataInizio = dataInizio;
            _dataFine = dataFine;
        }

        public DateTime DataInizio
        {
            get { return _dataInizio; }
            set { _dataInizio = value; }
        }

        public DateTime DataFine
        {
            get { return _dataFine; }
            set { _dataFine = value; }
        }

        public override double prezzoSkiPass()
        {
            throw new NotImplementedException();
        }
    }
}
