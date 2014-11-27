using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class Periodo :ICloneable
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

        public Periodo()
        {
            _profilo=new ProfiloPrezziRisorse();
        }

        public Periodo(DateTime dataInizio, DateTime dataFine)
        {
            _dataInizio = dataInizio;
            _dataFine = dataFine;
            _profilo = new ProfiloPrezziRisorse();
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

        public override string ToString()
        {
            return "Periodo dal " + this._dataInizio.Date.ToString("dd/MM/yyyy") + " al " + this.DataFine.Date.ToString("dd/MM/yyyy")+ ",Profilo:"+this.Profilo;
        }

        public object Clone()
        {
            return new Periodo(this.DataInizio, this.DataFine, this.Profilo);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Periodo p;
            if (obj is Periodo)
            {
                p = (Periodo)obj;
            }
            else
                return false;
            if (this._dataInizio == p.DataInizio && this._dataFine == p.DataFine)
                return true;
            return false;
        }
    }
}
