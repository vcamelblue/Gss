using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    static class Fatturatore
    {
        private static int _numeroFatture=0;

        public static Fattura GeneraFattura(PrenotazioneAttiva prenotazione)
        {
            int numeroFattura = _numeroFatture++;
            Fattura fattura = new Fattura(numeroFattura, DateTime.Today);
            fattura.TotaleBungalow = prenotazione.GetSpesaBungalow();
            fattura.TotaleSkiCards = prenotazione.GetSpesaSkiCards();
            fattura.TotaleFattura = prenotazione.GetSpesaAttuale();
            return fattura;
        }
    }
}
