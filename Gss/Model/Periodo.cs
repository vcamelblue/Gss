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

        public Periodo(DateTime dataInizio, DateTime dataFine, ProfiloPrezziRisorse profilo)
        {
            _profilo = profilo;
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
            return (DataInizio.Date <= data.Date && data.Date <= DataFine.Date);
        }

        public override string ToString()
        {
            return "Periodo " + this.Profilo.Nome + " dal " + this.DataInizio.Date.ToString("dd/MM/yyyy") + " al " + this.DataFine.Date.ToString("dd/MM/yyyy");
        }

        public object Clone()
        {
            return new Periodo(this.DataInizio, this.DataFine, (ProfiloPrezziRisorse) this.Profilo.Clone());
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Periodo p;

            if (obj is Periodo)
                p = (Periodo)obj;
            else
                return false;

            return (this.Profilo.Equals(p.Profilo) && this._dataInizio == p.DataInizio && this._dataFine == p.DataFine);
        }
    }
}
