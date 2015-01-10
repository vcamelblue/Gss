using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Filtra
{
    public class FiltraPerPrezzoAccesso : IFiltra
    {
        private double _prezzoToFilter;
        private DateTime _dataRilascio;

        public FiltraPerPrezzoAccesso(double prezzo,DateTime dataRilascio)
        {
            _prezzoToFilter = prezzo;
            _dataRilascio = dataRilascio;
        }

        public double PrezzoToFilter
        {
            get { return _prezzoToFilter; }
            set { _prezzoToFilter = value; }
        }

        public DateTime DataRilascio
        {
            get { return _dataRilascio; }
            set { _dataRilascio = value; }
        }

        public Impianti Filtra(Impianti impianti)
        {
            Impianti result = new Impianti();

            foreach (Impianto i in impianti.ListaImpianti)
            {
                if ((i.GetPrezzoFor(DataRilascio).GetPrezzoByTipologia(TipologiaPrezzo.PrezzoPerAccesso).Prezzo)<=PrezzoToFilter) 
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
