using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Gss.Model
{
    public class SkiPassAGiornata : SkiPass
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

        public override double GetPrezzoSkiPass()
        {
            double prezzo = 0;
            DateTime data = DataInizio.Date;

            while(data<=DataFine)
            {
                prezzo += Impianto.GetPrezzoFor(data).Prezzo;
                data = data.AddDays(1);
            }
            return prezzo;
        }


    }
}
