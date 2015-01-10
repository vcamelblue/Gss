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
            _listaSkiCards = new SkiCards();
        }

        public PrenotazioneAttiva(int numeroPrenotazione, int numeroPersone, DateTime dataInizio, DateTime dataFine, Cliente cliente)
            : this(numeroPrenotazione, numeroPersone, dataInizio, dataFine, cliente, null)
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
            return (DateTime.Today.Date >= DataInizio.Date);           
        }

        public bool IsConclusa()
        {
            return (DateTime.Today.Date >= DataFine.Date );
        }

        public bool IsInCorso()
        {
            return (IsIniziata() && !(IsConclusa()));
        }

        public bool IsEntroUnaSettimana()
        {
            return (DateTime.Today.AddDays(7).Date > DataInizio.Date);
        }

        public bool AddSkiCard(SkiCard skicard)
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
            DateTime data = DataInizio.Date;

            if (Bungalow == null) 
                return prezzo;

            while (data.Date < DataFine.Date) //calcolo il prezzo standard per giornata
            {
                PrezziRisorsa prezziBungalow = Bungalow.GetPrezzoFor(data);

                if (prezziBungalow == null)
                    throw new Exception("Impossibile Trovare Il prezzo per la risorsa specificata nel periodo specificato!");

                prezzo += prezziBungalow.Prezzo;
                data = data.AddDays(1);
            }

            if (NumeroPersone <= Bungalow.PostiTotaliStandard()) // controllo se ho affittato un bungalow senza sfruttare i posti max
            {
                return prezzo;
            }
            else
            {
                int numeroPersoneExtra = NumeroPersone - Bungalow.PostiTotaliStandard();
                data = DataInizio.Date;

                while (data.Date < DataFine.Date)                    //calcolo il prezzo per ogni persona extra  per giornata
                {
                    PrezziRisorsa prezziBungalow = Bungalow.GetPrezzoFor(data);
                    
                    if (prezziBungalow == null)
                        throw new Exception("Impossibile Trovare Il prezzo per la risorsa specificata nel periodo specificato!");

                    PrezzoSpecifico prezzoPerPersonaExtra = prezziBungalow.GetPrezzoByTipologia(TipologiaPrezzo.PrezzoPerPersonaExtra);

                    if (prezzoPerPersonaExtra == null)
                        throw new Exception("Impossibile Trovare Il prezzo per la risorsa specificata nel periodo specificato!");


                    prezzo += numeroPersoneExtra * prezzoPerPersonaExtra.Prezzo;
                    data = data.AddDays(1);
                }
                return prezzo;
            }
        }

        public double GetSpesaSkiCards()
        {
            if (ListaSkiCards.ListaSkiCard.Count == 0)
                return 0;
            else 
                return ListaSkiCards.GetPrezzoTotale();
        }

        
        public override bool Equals(object obj)
        {
            PrenotazioneAttiva prenotazione= null;
            if (obj is PrenotazioneAttiva && base.Equals(obj))
                prenotazione = (PrenotazioneAttiva)obj;
            else 
                return false;

            return (this.Bungalow.Equals(prenotazione.Bungalow));
        }

        public override string ToString() //FITTIZIA!!!!! DA FARE PRIMA O POI
        {
            return this.Bungalow.ToString();
        }
    }
}
