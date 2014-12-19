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
            : base()
        {

        }

        public void AddPrenotazione(Prenotazione prenotazione)
        {
            //AGGIUNGERE CONTROLLI SULL'INIZIO DELLA STAGIONE!
            if (!IsStagioneImpostata())
                throw new Exception("Impossibile aggiungere una nuova prenotazione al sistema! La stagione non è stata ancora impostata!");

            if (!Gss.Prenotazioni.Add(prenotazione))
                throw new Exception("Prenotazione già presente nel sistema");
        }

        public void RemovePrenotazione(Prenotazione prenotazione)
        {
            if (prenotazione.DataInizio.Date < DateTime.Today.AddDays(7).Date)
                throw new Exception("Impossibile rimuovere la prenotazione dal sistema! La prenotazione è già entro una settimana dalla data odierna.");

            if (!Gss.Prenotazioni.Remove(prenotazione))
                throw new Exception("Impossibile Rimuovere La Prenotazione Dal Sistema!");
        }

        public void ArchiviaPrenotazione(PrenotazioneAttiva prenotazione)
        {
            if (!prenotazione.IsConclusa())
                throw new Exception("Spiacente, la prenotazione non è archiviabile in quanto non è ancora conclusa");

            if (!Gss.Prenotazioni.ArchiviaPrenotazione(prenotazione))
                throw new Exception("Errore durante l'archiviazione della prenotazione, Archiviazione non effettuata");
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
            Prenotazione result = Gss.Prenotazioni.GetPrenotazioneByNumPrenotazione(numeroPrenotazione);

            if (result == null)
                throw new Exception("Prenotazione non presente nel sistema");

            return result;
        }

        public Prenotazioni GetPrenotazioniByCliente(Cliente cliente)
        {
            //Controlli sul numero di prenotazioni > 0, altrimenti messaggio??

            return Gss.Prenotazioni.GetPrenotazioniByCliente(cliente);
        }

        public Prenotazioni GetPrenotazioniIniziateOggi()
        {
            Prenotazioni prenotazioni = new Prenotazioni();

            foreach(Prenotazione p in Gss.Prenotazioni.GetPrenotazioniAttive())
            {
                if(p.DataInizio.Date == DateTime.Today.Date)
                    prenotazioni.Add(p);
            }
            return prenotazioni;
        }

        public Prenotazioni GetPrenotazioniConcluseOggi() //solo quelle che finiscono oggi!
        {
            Prenotazioni prenotazioni = new Prenotazioni();

            foreach (Prenotazione p in Gss.Prenotazioni.ListaPrenotazioni)
            {
                if (p.DataFine.Date == DateTime.Today.Date)
                    prenotazioni.Add(p);
            }
            return prenotazioni;
        }

        public Prenotazioni GetPrenotazioniInCorsoOggi()
        {
            Prenotazioni prenotazioni = new Prenotazioni();

            foreach (PrenotazioneAttiva p in Gss.Prenotazioni.GetPrenotazioniAttive())
            {
                //in base alle convenzioni usate le prenotazioni concluse oggi NON SONO IN CORSO, sfrutto i metodi sotto
                if (p.IsInCorso())
                    prenotazioni.Add(p);
            }
            return prenotazioni;
        }

        public Prenotazioni GetPrenotazioniConcluseNonArchiviate()
        {
            Prenotazioni prenotazioni = new Prenotazioni();

            foreach(PrenotazioneAttiva p in Gss.Prenotazioni.GetPrenotazioniAttive())
            {
                if (p.IsConclusa())
                    prenotazioni.Add(p);
            }
            return prenotazioni;
        }
        
        public Prenotazioni GetPrenotazioniFuture()
        {
            Prenotazioni prenotazioni = new Prenotazioni();

            foreach (PrenotazioneAttiva p in Gss.Prenotazioni.GetPrenotazioniAttive())
            {
                if (!p.IsIniziata())
                    prenotazioni.Add(p);
            }
            return prenotazioni;
        }


        public Bungalows FindBungalowDisponibiliFor(DateTime dataInizio, DateTime dataFine, int numeroPersone)
        {
            
            Bungalows bungalowsDisponibili = cercaBungalowsDisponibiliByDate(dataInizio, dataFine);

            bungalowsDisponibili = bungalowsDisponibili.GetBungalowConMaxPostiAlmeno(numeroPersone);

            bungalowsDisponibili.ListaBungalow.Sort(new BungalowComparer(numeroPersone));

            return bungalowsDisponibili;

        }
        /*
        private Bungalows cercaBungalowsByNumeroPersone(int numeroPersone, Bungalows bungalowsDisponibili)
        {
           
            //Bungalows result = new Bungalows();
           // foreach(Bungalow b in disponibili.ListaBungalow)
            //{
             //   if (b.PostiTotaliMax() >= numeroPersone)
               //     result.Add(b);
            //}
            return bungalowsDisponibili.GetBungalowConMaxPostiAlmeno(numeroPersone);
           // return result; 
        }*/

        private Bungalows cercaBungalowsDisponibiliByDate(DateTime dataInizio, DateTime dataFine)
        {
            Bungalows result = new Bungalows();
            
            //Ragionamento in logica negativa: tra tutti i bungalows rimuovo quelli non prenotabili

            result.ListaBungalow = Gss.Resort.Bungalows.ListaBungalow.ToList<Bungalow>();

            foreach(PrenotazioneAttiva p in Gss.Prenotazioni.GetPrenotazioniAttive())
            {
                /*
                 * CASI CON ESITO POSITIVO
                 * 
                 *              tempo (in millisec)
                 *  ---------------------------------------->
                 *   | data Bungalow | data Pren |       (data fine bungalow <= data inizio pren)
                 *   
                 *   | data Pren | data Bungalow |       (data inizio bungalow >= data fine pren)
                 */

                //Logica negativa, quelli che non hanno esito positivo vengono rimossi perche occupati in uno o più giorni

                if ( ! (dataInizio.Date >= p.DataFine.Date || dataFine.Date <= p.DataInizio.Date) )
                {
                    result.Remove(p.Bungalow);
                }

            }            
            return result;
        }


        public double GetSpesaBungalow(Bungalow bungalow, DateTime dataInizio, DateTime dataFine,int numeroPersone)
        {
            
            PrenotazioneAttiva tempPrenotation = new PrenotazioneAttiva(-1, numeroPersone, dataInizio.Date, dataFine.Date, null, bungalow);
            
            return tempPrenotation.GetSpesaBungalow(); 

            //try e catch gestito ai piani alti! nella view, cosi da lanciare messaggio utente



            /*
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
            }*/
        }
    }
}
