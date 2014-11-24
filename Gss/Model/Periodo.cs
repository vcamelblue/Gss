using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class Periodo
    {
        private ProfiloPrezziRisorse _profilo;
        private DateTime _dataInizio;
        private DateTime _dataFine;

        public Periodo(DateTime dataInizio, DateTime dataFine, ProfiloPrezziRisorse profilo)
        {
            _profilo = profilo;
            _dataInizio = dataInizio;
            _dataFine = dataFine;
        }

        public Periodo(DateTime dataInizio, DateTime dataFine)
        {
            _dataInizio = dataInizio;
            _dataFine = dataFine;
        }

        public ProfiloPrezziRisorse Profilo
        {
            get { return _profilo; }
            set { _profilo = value; }
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

        public bool IsDataInPeriodo(DateTime data)
        {
            if (_dataInizio.CompareTo(data) >= 0 && _dataFine.CompareTo(data) <= 0)
                return true;
            return false;
        }
        
    }
}
