using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Filtra
{
    public class FiltraPerPrezzoGiornata : IFiltra
    {
        private double _prezzoToFilter;
        private DateTime _dataInizio;
        private DateTime _dataFine;

        public FiltraPerPrezzoGiornata(double prezzoGiornata, DateTime dataInizio, DateTime dataFine)
        {
            _prezzoToFilter = prezzoGiornata;
            _dataInizio = dataInizio;
            _dataFine = dataFine;
        }

        public double PrezzoToFilter
        {
            get { return _prezzoToFilter; }
            set { _prezzoToFilter = value; }
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

        public Impianti Filtra(Impianti impianti)
        {
            Impianti result = new Impianti();

            foreach (Impianto i in impianti.ListaImpianti)
            {
                double prezzo = 0;
                DateTime data = DataInizio;

                while (!(data.Equals(DataFine)))
                {
                    prezzo += i.GetPrezzoFor(data).Prezzo;
                    data.AddDays(1);
                }
                if (prezzo <= PrezzoToFilter)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
