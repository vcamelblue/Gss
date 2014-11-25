using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class PrenotazioneAttiva : Prenotazione
    {
        private Bungalow _bungalow;
        private SkiCards _listaSkiCards;

        public PrenotazioneAttiva(int numeroPrenotazione, int numeroPersone, DateTime dataInizio, DateTime dataFine, Cliente cliente, Bungalow bungalow)
            : base(numeroPrenotazione, numeroPersone, dataInizio, dataFine, cliente)
        {
            _bungalow = bungalow;
        }

        public PrenotazioneAttiva(int numeroPrenotazione, int numeroPersone, DateTime dataInizio, DateTime dataFine, Cliente cliente)
            : base(numeroPrenotazione, numeroPersone, dataInizio, dataFine, cliente)
        {
     
        }

        public Bungalow Bungalow
        {
            get { return _bungalow; }
            set { _bungalow = value; }
        }

        public SkiCards ListaSkiCards
        {
            get { return _listaSkiCards; }
            set { _listaSkiCards = value; }
        }

        public bool IsIniziata()
        {
            if (DataInizio >= DateTime.Today)
                return true;
            else return false;
           
        }

        public bool IsConclusa()
        {
            if (DataFine <= DateTime.Today)
                return true;
            else return false;
        }

        public bool IsInCorso()
        {
            if (IsIniziata() && !(IsConclusa()))
                return true;
            else return false;
        }

        public bool IsEntroUnaSettimana()
        {
            if (DataInizio >= DateTime.Today.AddDays(7))
                return true;
            else return false;
        }

        public bool AddSkicard(SkiCard skicard)
        {
            return ListaSkiCards.Add(skicard);
        }

        public bool RemoveSkiCard(SkiCard skicard)
        {
            return ListaSkiCards.Remove(skicard);
        }

        public double GetSpesaAttuale()
        {
            return GetSpesaBungalow() + GetSpesaSkiCards();
        }

        public double GetSpesaBungalow()
        {
            double prezzo = 0;
            DateTime data = DataInizio;

            if (Bungalow == null) return prezzo;

            while (!(data.Equals(DataFine))) //calcolo il prezzo standard per giornata
            {
                prezzo += Bungalow.GetPrezzoFor(data).Prezzo;
                data.AddDays(1);
            }

            if (NumeroPersone <= Bungalow.PostiTotaliStandard()) // controllo se ho affittato un bungalow senza sfruttare i posti max
            {
                return prezzo;
            }

            else
            {
                int numeroPersoneExtra = NumeroPersone - Bungalow.PostiTotaliStandard();
                while (!(data.Equals(DataFine)))                    //calcolo il prezzo per ogni persona extra  per giornata
                {
                    prezzo +=(numeroPersoneExtra*Bungalow.GetPrezzoFor(data).GetPrezzoByTipologia(TipologiaPrezzo.PrezzoPerPersonaExtra).Valore);
                    data.AddDays(1);
                }
                return prezzo;
            }

        }

        public double GetSpesaSkiCards()
        {
            if (ListaSkiCards.ListaSkiCard.Count == 0)
                return 0;
            else return ListaSkiCards.GetPrezzoTotale();
        }

        public override bool Equals(object obj)
        {
            PrenotazioneAttiva prenotazione= null;
            if (base.Equals(obj) && obj is PrenotazioneAttiva)
                prenotazione = (PrenotazioneAttiva)obj;
            else 
                return false;
            if (this.Bungalow.Equals(prenotazione.Bungalow) &&
                this.Cliente.Equals(prenotazione.Cliente) &&
                this.DataInizio.Equals(prenotazione.DataInizio) &&
                this.DataFine.Equals(prenotazione.DataFine))
                return true;
            else
                return false;
        }

        public override string ToString() //FITTIZIA!!!!!
        {
            return this.Bungalow.ToString();
        }
    }
}
