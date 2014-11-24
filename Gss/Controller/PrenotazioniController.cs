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
            if (prenotazione.IsConclusa())
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
            return Gss.Prenotazioni.GetPrenotazioneByNumPrenotazione(numeroPrenotazione);
        }

    }
}
