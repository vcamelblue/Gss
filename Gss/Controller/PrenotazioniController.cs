using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Controller
{
    public class PrenotazioniController : MyController
    {
        public PrenotazioniController()
            :base()
        {

        }

        public void AddPrenotazione(Prenotazione prenotazione)
        {
            if (!Gss.Prenotazioni.Add(prenotazione))
                throw new Exception("Prenotazione già presente nel sistema");
        }

        public void RemovePrenotazione(Prenotazione prenotazione)
        {
            if (prenotazione.DataInizio < DateTime.Today.AddDays(7))
                throw new Exception("La prenotazione già è iniziata");
            Gss.Prenotazioni.Remove(prenotazione);
        }

        public void ArchiviaPrenotazione(PrenotazioneAttiva prenotazione)
        {
            if (!prenotazione.IsConclusa())
                throw new Exception("La prenotazione non è archiviabile perchè non conclusa");
            if (!Gss.Prenotazioni.ArchiviaPrenotazione(prenotazione))
                throw new Exception("Errore nell'archiviazione");
        }

        public List<PrenotazioneAttiva> GetPrenotazioniAttive()
        {            
            return Gss.Prenotazioni.GetPrenotazioniAttive();
        }

        public List<PrenotazioneArchiviata> GetPrenotazioniArchiviate()
        {
            return Gss.Prenotazioni.GetPrenotazioneArchiviata();
        }

        public Prenotazione GetPrenotazioneByNumeroPrenotazione(int numeroPrenotazione)
        {
            Prenotazione result= Gss.Prenotazioni.GetPrenotazioneByNumPrenotazione(numeroPrenotazione);
            if (result == null)
                throw new Exception("Prenotazione non presente");
            return result;
        }

        public Prenotazioni GetPrenotazioniByCliente(Cliente cliente)
        {
            return Gss.Prenotazioni.GetPrenotazioniByCliente(cliente);
        }

        public Prenotazioni GetPrenotazioniIniziateOggi()
        {
            Prenotazioni prenotazioni = new Prenotazioni();
            foreach(Prenotazione p in Gss.Prenotazioni.ListaPrenotazioni)
            {
                if(p.DataInizio.Date==DateTime.Today)
                    prenotazioni.Add(p);
            }
            return prenotazioni;
        }

        public Prenotazioni GetPrenotazioniConcluseOggi()
        {
            Prenotazioni prenotazioni = new Prenotazioni();
            foreach (Prenotazione p in Gss.Prenotazioni.ListaPrenotazioni)
            {
                if (p.DataFine.Date == DateTime.Today)
                    prenotazioni.Add(p);
            }
            return prenotazioni;
        }

        public Prenotazioni GetPrenotazioniInCorsoOggi()
        {
            Prenotazioni prenotazioni = new Prenotazioni();
            foreach (Prenotazione p in Gss.Prenotazioni.ListaPrenotazioni)
            {
                if (p.DataInizio.Date >= DateTime.Today && p.DataFine.Date > DateTime.Today)
                    prenotazioni.Add(p);
            }
            return prenotazioni;
        }

        public Prenotazioni GetPrenotazioniConcluseNonArchiviate()
        {
            Prenotazioni prenotazioni = new Prenotazioni();
            foreach(PrenotazioneAttiva p in Gss.Prenotazioni.GetPrenotazioniAttive())
            {
                if (p.DataFine.Date<=DateTime.Today)
                    prenotazioni.Add(p);
            }
            return prenotazioni;
        }
        
        public Prenotazioni GetPrenotazioniFuture()
        {
            Prenotazioni prenotazioni = new Prenotazioni();
            foreach (PrenotazioneAttiva p in Gss.Prenotazioni.GetPrenotazioniAttive())
            {
                if (p.DataInizio.Date > DateTime.Today)
                    prenotazioni.Add(p);
            }
            return prenotazioni;
        }

        public Bungalows FindBungalowDisponibiliFor(DateTime dataInizio, DateTime dataFine, int numeroPersone)
        {
            
            Bungalows disponibili = cercaBungalowsDisponibiliByDate(dataInizio, dataFine);
            Bungalows result = cercaBungalowsByNumeroPersone(numeroPersone,disponibili);
            result.ListaBungalow.Sort(new BungalowComparer(numeroPersone));
            return result;

        }

        private Bungalows cercaBungalowsByNumeroPersone(int numeroPersone, Bungalows disponibili)
        {
           
            Bungalows result = new Bungalows();
           // foreach(Bungalow b in disponibili.ListaBungalow)
            //{
             //   if (b.PostiTotaliMax() >= numeroPersone)
               //     result.Add(b);
            //}
            return disponibili.GetBungalowConMaxPostiAlmeno(numeroPersone);
           // return result; 
        }

        private Bungalows cercaBungalowsDisponibiliByDate(DateTime dataInizio, DateTime dataFine)
        {
            Bungalows result = new Bungalows();
            result.ListaBungalow = Gss.Resort.Bungalows.ListaBungalow.ToList<Bungalow>();
            foreach(PrenotazioneAttiva p in Gss.Prenotazioni.GetPrenotazioniAttive())
            {
                if (!inData(p, dataInizio, dataFine))
                    result.Remove(p.Bungalow);
            }            
            return result;
        }

        private bool inData(PrenotazioneAttiva p, DateTime dataInizio, DateTime dataFine)
        {
            if (DateTime.Compare(p.DataFine.Date , dataInizio.Date)<=0 || DateTime.Compare( p.DataInizio.Date , dataFine.Date)>=0)
            {
                return true;
            }
            return false;
        }

        public double GetSpesaBungalow(Bungalow bungalow, DateTime dataInizio, DateTime dataFine,int numeroPersone)
        {
            double prezzo = 0;
            DateTime data = dataInizio.Date;

            if (bungalow == null) return prezzo;

            while (data<=dataFine.Date) //calcolo il prezzo standard per giornata
            {
                prezzo += bungalow.GetPrezzoFor(data.Date).Prezzo;
                data = data.AddDays(1);
            }

            if (numeroPersone <= bungalow.PostiTotaliStandard()) // controllo se ho affittato un bungalow senza sfruttare i posti max
            {
                return prezzo;
            }

            else
            {
                int numeroPersoneExtra = numeroPersone - bungalow.PostiTotaliStandard();
                while (data<=dataFine)                    //calcolo il prezzo per ogni persona extra  per giornata
                {
                    prezzo += (numeroPersoneExtra * bungalow.GetPrezzoFor(data).GetPrezzoByTipologia(TipologiaPrezzo.PrezzoPerPersonaExtra).Valore);
                    data = data.AddDays(1);
                }
                return prezzo;
            }
        }
    }
}
