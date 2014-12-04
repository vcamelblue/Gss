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
            _dataInizio = dataInizio.Date;
            _dataFine = dataFine.Date;
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

            while(data.Date <= DataFine.Date)
            {
                PrezziRisorsa prezziSkipassImpianto = Impianto.GetPrezzoFor(data);
                
                if (prezziSkipassImpianto != null)
                {
                    prezzo += prezziSkipassImpianto.Prezzo;
                    data = data.AddDays(1);
                }
                else
                    throw new Exception("Impossibile Trovare Il prezzo per lo skipass nel periodo specificato!");
            }

            return prezzo;
        }

    }
}
