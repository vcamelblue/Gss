using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model.Cliente;

namespace Gss.Model
{
    public abstract class  Prenotazione
    {
        private int _numeroPrenotazione;
        private int _numeroPersone;
        private DateTime _dataInizio;
        private DateTime _dataFine;
        private Cliente _cliente;

        public Prenotazione(int numeroPrenotazione, int numeroPersone, DateTime dataInizio, DateTime dataFine, Cliente cliente)
        {
            _numeroPrenotazione= numeroPrenotazione;
            _numeroPersone = numeroPersone;
            _dataInizio = dataInizio;
            _dataFine = dataFine;
            _cliente = cliente;
        }

        public Prenotazione(int numeroPrenotazione)
        {
            _numeroPrenotazione = numeroPrenotazione;
        }

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public DateTime DataFine
        {
            get { return _dataFine; }
            set { _dataFine = value; }
        }
       
        public DateTime DataInizio
        {
            get { return _dataInizio; }
            set { _dataInizio = value; }
        }
      
        public int NumeroPersone
        {
            get { return _numeroPersone; }
            set { _numeroPersone = value; }
        }

        public int NumeroPrenotazione
        {
            get { return _numeroPrenotazione; }
            set { _numeroPrenotazione = value; }
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            Prenotazione prenotazione=null;

            if (obj is SkiPass)
            {
                prenotazione = (Prenotazione)obj;
            }
            else return false;

            if (this.NumeroPrenotazione == prenotazione.NumeroPrenotazione)
                return true;
            else
                return false;

        }
    }
}
