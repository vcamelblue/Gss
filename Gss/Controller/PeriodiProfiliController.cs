using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Controller
{
    public class PeriodiProfiliController : MyController
    {

        //Constructors

        public PeriodiProfiliController()
            : base()
        {

        }


        //Public Methods

        //Periodi
        public string TrySetPeriodi(List<Periodo> periodi)
        {
           return Gss.GestorePeriodi.TrySetPeriodi(periodi);
        }

        public List<Periodo> SetPeriodi(List<Periodo> periodi)
        {
            return Gss.GestorePeriodi.SetPeriodi(periodi);
        }

        public void RemoveAllPeriodi()
        {
            this.Gss.GestorePeriodi.Periodi = new List<Periodo>();
        }

        public List<Periodo> GetAllPeriodi()
        {
            return this.Gss.GestorePeriodi.Periodi;
        }

        public List<Periodo> GetCloneOfAllPeriodi()
        {
            List<Periodo> result = new List<Periodo>();

            foreach (Periodo p in this.Gss.GestorePeriodi.Periodi)
            {
                result.Add((Periodo)p.Clone());
            }
            return result;
        }

        public PrezziRisorsa GetPrezzoRisorsaByData(Risorsa risorsa, DateTime data)
        {
            PrezziRisorsa prezzi = Gss.GestorePeriodi.getPrezzoRisorsaByData(risorsa, data);

            if (prezzi == null)
                throw new Exception("Impossibile trovare un prezzo per la risorsa nella data specificata!");
            
            return prezzi;
        }

        //Profili

        public ProfiloPrezziRisorse GetProfiloPrezziRisorsaByNome(string nomeProfilo)
        {
            ProfiloPrezziRisorse profilo = Gss.ProfiliPrezziRisorse.GetProfiloPrezziRisorseByNome(nomeProfilo);

            if (profilo == null)
                throw new Exception("Il profilo richiesto non è presente nel sistema!");

            return profilo;
        }


        public ProfiliPrezziRisorse GetAllProfili()
        {
            return Gss.ProfiliPrezziRisorse;
        }

        public void SetPrezziForRisorsaInProfilo(Risorsa risorsa, PrezziRisorsa prezzi, ProfiloPrezziRisorse profilo)
        {
            if (risorsa == null || profilo == null || prezzi == null)
                throw new Exception("Impossibile impostare i prezzi per la risorsa nel profilo scelto! Uno o più valori sono errati.");

            if (!this.Gss.ProfiliPrezziRisorse.Profili.Contains(profilo))
                throw new Exception("Impossibile impostare i prezzi per la risorsa nel profilo scelto, Il profilo scelto non è presente nel sistema!");

            ProfiloPrezziRisorse p = this.Gss.ProfiliPrezziRisorse.GetProfiloPrezziRisorseByNome(profilo.Nome);
            p.PrezziRisorse.Add(risorsa, prezzi);
        }

        public void SetPrezziForRisorsaInProfilo(Risorsa risorsa, PrezziRisorsa prezzi, string nomeProfilo)
        {
            if (risorsa == null || nomeProfilo == null || prezzi == null)
                throw new Exception("Impossibile impostare i prezzi per la risorsa nel profilo scelto! Uno o più valori sono errati.");

            ProfiloPrezziRisorse p = this.Gss.ProfiliPrezziRisorse.GetProfiloPrezziRisorseByNome(nomeProfilo);

            if (p == null)
                throw new Exception("Impossibile impostare i prezzi per la risorsa nel profilo scelto, Il profilo scelto non è presente nel sistema!");

            p.PrezziRisorse.Add(risorsa, prezzi);
        }

        public double GetPrezzoRisorsaByProfilo(Risorsa risorsa, String profilo)
        {
            if(risorsa == null || profilo == null || profilo == "")
                throw new Exception("Impossibile recuperare il prezzo per la risorsa specificata! La risorsa o il profilo richiesto potrebbero essere corrotti.");

            ProfiloPrezziRisorse prof = GetProfiloPrezziRisorsaByNome(profilo);

            if (prof == null)
                throw new Exception("Impossibile recuperare il prezzo per la risorsa specificata! Il profilo scelto non è presente nel sistema.");

            PrezziRisorsa pr = prof.GetPrezziRisorsa(risorsa);

            if (pr == null)
                throw new Exception("Impossibile recuperare il prezzo per la risorsa richiesta! Il Profilo selto non contiene nessun prezzo per la risorsa.");

            if (pr.Prezzo == 0)
                throw new Exception("Prezzo della risorsa non impostato per il profilo richiesto!");
            
            return pr.Prezzo;        
        }

        public double GetPrezzoSpecificoRisorsaByProfilo(Risorsa risorsa, string profilo, TipologiaPrezzo tipologia)
        {
            if (risorsa == null || profilo == null || profilo == "")
                throw new Exception("Impossibile recuperare il prezzo specifico per la risorsa specificata! La risorsa o il profilo richiesto potrebbero essere corrotti.");


            ProfiloPrezziRisorse prof = GetProfiloPrezziRisorsaByNome(profilo);

            if (prof == null)
                throw new Exception("Impossibile recuperare il prezzo specifico per la risorsa specificata! Il profilo scelto non è presente nel sistema.");
            
            PrezziRisorsa pr = prof.GetPrezziRisorsa(risorsa);

            if (pr == null)
                throw new Exception("Impossibile recuperare il prezzo specifico per la risorsa richiesta! Il Profilo selto non contiene nessun prezzo per la risorsa.");

            List<PrezzoSpecifico> prezziSpecifici = pr.PrezziSpecifici;

            foreach (PrezzoSpecifico ps in prezziSpecifici)
            {
                if (ps.Tipologia == tipologia)
                {
                    if (ps.Prezzo != 0)
                        return ps.Prezzo;
                }
            } 
            
            throw new Exception("Prezzo specifico della risorsa non impostato per il profilo richiesto!");
        }

        public void AddProfilo(ProfiloPrezziRisorse profilo)
        {
            if (profilo == null)
                throw new Exception("Impossibile aggiungere un profilo nullo al sistema! Operazione non effettuata.");

            if (!this.Gss.ProfiliPrezziRisorse.Add(profilo))
                throw new Exception("Impossibile aggiungere il  profilo al sistema! Il profilo selezionato esiste già nel sistema. Operazione non effettuata.");
        }

        public void EditProfilo(ProfiloPrezziRisorse profiloModificato, string nomeProfiloDaModificare)
        {
            ProfiloPrezziRisorse profiloDaModificare = GetProfiloPrezziRisorsaByNome(nomeProfiloDaModificare);

            if (profiloDaModificare == null)
                throw new Exception("Impossibile modificare il profilo selezionato! Il profilo da modificare potrebbe essere corrotto nel sistema.");

            if (profiloModificato.Nome != nomeProfiloDaModificare && ((Gss.ProfiliPrezziRisorse.GetProfiloPrezziRisorseByNome(profiloModificato.Nome)) != null))
                throw new Exception("Il nome del profilo esiste già nel sistema");

            if (profiloModificato.PrezziRisorse.Count == profiloDaModificare.PrezziRisorse.Count)
            {
                if (!ProfiloIsChanged(profiloModificato, profiloDaModificare))
                    throw new Exception("Il profilo non è stato modificato!");
            }

            profiloDaModificare.Nome = profiloModificato.Nome;
            profiloDaModificare.PrezziRisorse = profiloModificato.PrezziRisorse;
        }


        public void RemoveProfilo(ProfiloPrezziRisorse profilo)
        {
            if (!this.Gss.ProfiliPrezziRisorse.Remove(profilo))
                throw new Exception("Impossibile rimuovere il profilo selezionato dal sistema! Operazione non effettuata.");

            #region RiallineamentoPeriodi

            List<Periodo> temp = new List<Periodo>();
            List<Periodo> periodi = Gss.GestorePeriodi.Periodi;

            foreach (Periodo p in periodi)
                temp.Add((Periodo)p.Clone());

            //Elimino da temp i periodi che hanno il profilo eliminato
            foreach (Periodo p in periodi)
            {
                if (p.Profilo.Equals(profilo))
                    temp.Remove(p);
            }

            //se ne ho rimosso almeno uno, reimposto i periodi
            if (periodi.Count != temp.Count)
                this.SetPeriodi(temp);
            
            #endregion
        }

        //Private Methods
        
        private bool ProfiloIsChanged(ProfiloPrezziRisorse p1, ProfiloPrezziRisorse p2)
        {
            if (p1.Nome != p2.Nome)
                return true;

            foreach(Risorsa r in p1.PrezziRisorse.Keys)
            {
                if (!p2.PrezziRisorse[r].Equals(p1.PrezziRisorse[r]))
                    return true;
            }
            return false;
        }
    }
}
