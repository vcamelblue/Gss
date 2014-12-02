using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public static class Fatturatore
    {
        private static int _numeroFatture = 0;

        public static int NumeroFatture
        {
            get { return Fatturatore._numeroFatture; }
            set { Fatturatore._numeroFatture = value; }
        }

        public static Fattura GeneraFattura(PrenotazioneAttiva prenotazione)
        {
            NumeroFatture++;

            Fattura fattura = new Fattura(NumeroFatture, DateTime.Today);

            fattura.TotaleBungalow = prenotazione.GetSpesaBungalow();
            fattura.TotaleSkiCards = prenotazione.GetSpesaSkiCards();
            fattura.TotaleFattura = prenotazione.GetSpesaAttuale();

            return fattura;
        }
    }
}
