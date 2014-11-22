using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class PrenotazioneArchiviata : Prenotazione
    {
        private Fattura _fattura;

        public PrenotazioneArchiviata(int numeroPrenotazione, int numeroPersone, DateTime dataInizio, DateTime dataFine, Cliente cliente, Fattura fattura)
            : base(numeroPrenotazione,numeroPersone,dataInizio,dataFine,cliente)
        {
            _fattura = fattura;
        }

        public Fattura Fattura
        {
            get { return _fattura; }
            set { _fattura = value; }
        }


    }
}
