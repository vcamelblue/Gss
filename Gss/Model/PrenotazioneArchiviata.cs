﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class PrenotazioneArchiviata : Prenotazione
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
        
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrenotazioneArchiviata prenotazione=null;

            if (obj is PrenotazioneArchiviata && base.Equals(obj))
                prenotazione = (PrenotazioneArchiviata)obj;
            else
                return false;

            return (this.Fattura.Equals(prenotazione.Fattura));
        }

    }
}
