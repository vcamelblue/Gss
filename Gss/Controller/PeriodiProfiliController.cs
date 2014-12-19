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
            string result = "";
            Periodo periodoTemp;
            List<Periodo> temp = new List<Periodo>();
            periodi.Sort(new PeriodoComparer());
            foreach (Periodo p in periodi)
                temp.Add((Periodo)p.Clone());


            if (Gss.Resort.DataInizioStagione != temp.ElementAt(0).DataInizio.Date)
            {
                result += temp.ElementAt(0) + " modificato con data d'inizio portata a " + Gss.Resort.DataInizioStagione.ToShortDateString() + "\n\n";
                temp.ElementAt(0).DataInizio = Gss.Resort.DataInizioStagione;
            }
            int i = 1;
            while (i < temp.Count)
            {
                if (DateTime.Compare(temp.ElementAt(i).DataInizio.Date, temp.ElementAt(i - 1).DataInizio.Date) == 0 &&
                    DateTime.Compare(temp.ElementAt(i).DataFine, temp.ElementAt(i - 1).DataFine) != 0)
                {
                    result += temp.ElementAt(i) + " modificato con data inizio portata a ";
                    temp.ElementAt(i).DataInizio = temp.ElementAt(i - 1).DataFine.AddDays(1);
                    result += temp.ElementAt(i).DataInizio.ToShortDateString() + "\n\n";
                }
                if (DateTime.Compare(temp.ElementAt(i).DataInizio.Date, temp.ElementAt(i - 1).DataInizio.Date) == 0 &&
                    DateTime.Compare(temp.ElementAt(i).DataFine.Date, temp.ElementAt(i - 1).DataFine.Date) == 0)
                {
                    result += temp.ElementAt(i - 1) + " eliminato per sovrapposizione di date \n\n";
                    temp.RemoveAt(i - 1);
                    continue;
                }
                if (DateTime.Compare(temp.ElementAt(i).DataInizio.Date, temp.ElementAt(i - 1).DataFine.Date) <= 0)
                {
                    if (DateTime.Compare(temp.ElementAt(i).DataFine.Date, temp.ElementAt(i - 1).DataFine.Date) >= 0)
                    {
                        result += temp.ElementAt(i - 1);
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                        result += " modificato con data fine portata a " + temp.ElementAt(i - 1).DataFine.ToShortDateString() + "\n\n";
                    }
                    else
                    {
                        periodoTemp = new Periodo(temp.ElementAt(i).DataFine.AddDays(1), temp.ElementAt(i - 1).DataFine, temp.ElementAt(i - i).Profilo); // .Clone()???
                        result += "Inserito " + temp.ElementAt(i) + " in " + temp.ElementAt(i - 1) + "\n\n";
                        temp.Add(periodoTemp);
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                    }
                }

                else if (DateTime.Compare(temp.ElementAt(i).DataInizio.AddDays(-1).Date, temp.ElementAt(i - 1).DataFine.Date) > 0)
                {
                    result += temp.ElementAt(i - 1) + " modificato con data fine portata a " + temp.ElementAt(i).DataInizio.AddDays(-1).ToShortDateString()+ "\n";
                    temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                }
                temp.Sort(new PeriodoComparer());//
                i++;
            }
            i--;
            if (DateTime.Compare(temp.ElementAt(i).DataFine.Date, Gss.Resort.DataFineStagione) < 0)
            {
                result += temp.ElementAt(i) + " modificato con data fine portata a " + Gss.Resort.DataFineStagione.ToShortDateString();
                temp.ElementAt(i).DataFine = Gss.Resort.DataFineStagione;
            }
            return result;
        }

        public List<Periodo> SetPeriodi(List<Periodo> periodi)
        {
            if (IsStagioneIniziata())
                throw new Exception("Impossibile impostare i periodi! La stagione è gia iniziata.");


            Periodo periodoTemp;
            List<Periodo> temp = new List<Periodo>();
            periodi.Sort(new PeriodoComparer());
            foreach (Periodo p in periodi)
                temp.Add(p);


            if (Gss.Resort.DataInizioStagione != temp.ElementAt(0).DataInizio.Date)
            {
                temp.ElementAt(0).DataInizio = Gss.Resort.DataInizioStagione;
            }
            int i = 1;
            while (i < temp.Count)
            {
                if (DateTime.Compare(temp.ElementAt(i).DataInizio.Date, temp.ElementAt(i - 1).DataInizio.Date) == 0 &&
                    DateTime.Compare(temp.ElementAt(i).DataFine.Date, temp.ElementAt(i - 1).DataFine.Date) != 0)
                {
                    temp.ElementAt(i).DataInizio = temp.ElementAt(i - 1).DataFine.AddDays(1);
                }
                if (DateTime.Compare(temp.ElementAt(i).DataInizio, temp.ElementAt(i - 1).DataInizio) == 0 &&
                    DateTime.Compare(temp.ElementAt(i).DataFine, temp.ElementAt(i - 1).DataFine) == 0)
                {
                    temp.RemoveAt(i - 1);
                    continue;
                }
                if (DateTime.Compare(temp.ElementAt(i).DataInizio.Date, temp.ElementAt(i - 1).DataFine.Date) <= 0)
                {
                    if (DateTime.Compare(temp.ElementAt(i).DataFine.Date, temp.ElementAt(i - 1).DataFine.Date) >= 0)
                    {
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                    }
                    else
                    {
                        periodoTemp = new Periodo(temp.ElementAt(i).DataFine.AddDays(1), temp.ElementAt(i - 1).DataFine, temp.ElementAt(i - i).Profilo); // .Clone()???
                        temp.Add(periodoTemp);
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                        temp.Sort(new PeriodoComparer());
                    }
                }

                else if (DateTime.Compare(temp.ElementAt(i).DataInizio.AddDays(-1).Date, temp.ElementAt(i - 1).DataFine.Date) > 0)
                {
                    temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                }
                i++;
            }
            i--;
            if (DateTime.Compare(temp.ElementAt(i).DataFine.Date, Gss.Resort.DataFineStagione.Date) < 0)
            {
                temp.ElementAt(i).DataFine = Gss.Resort.DataFineStagione;
            }
            temp.Sort(new PeriodoComparer());
            Gss.GestorePeriodi.Periodi = temp;
            return temp;
        }

        public void RemoveAllPeriodi()
        {
            if (IsStagioneIniziata())
                throw new Exception("Impossibile rimuovere i periodi dal sistema! La stagione è gia iniziata.");

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

        //CONTINUARE DA QUI A RICONTROLLARE

        public ProfiliPrezziRisorse GetAllProfili()
        {
            return Gss.ProfiliPrezziRisorse;
        }

        public void SetPrezziForRisorsaInProfilo(Risorsa risorsa, PrezziRisorsa prezzi, ProfiloPrezziRisorse profilo)
        {
            if (IsStagioneIniziata())
                throw new Exception("Impossibile impostare i prezzi per la risorsa specificata! La stagione è gia iniziata.");

            if (risorsa == null || profilo == null || prezzi == null)
                throw new Exception("Impossibile impostare i prezzi per la risorsa nel profilo scelto! Uno o più valori sono errati.");

            if (!this.Gss.ProfiliPrezziRisorse.Profili.Contains(profilo))
                throw new Exception("Impossibile impostare i prezzi per la risorsa nel profilo scelto, Il profilo scelto non è presente nel sistema!");

            ProfiloPrezziRisorse p = this.Gss.ProfiliPrezziRisorse.GetProfiloPrezziRisorseByNome(profilo.Nome);
            p.PrezziRisorse.Add(risorsa, prezzi);
        }

        public void SetPrezziForRisorsaInProfilo(Risorsa risorsa, PrezziRisorsa prezzi, string nomeProfilo)
        {
            if (IsStagioneIniziata())
                throw new Exception("Impossibile impostare i prezzi per la risorsa specificata! La stagione è gia iniziata.");

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
                    if (ps.Valore != 0)
                        return ps.Valore;
                }
            } 
            
            throw new Exception("Prezzo specifico della risorsa non impostato per il profilo richiesto!");
        }

        public void AddProfilo(ProfiloPrezziRisorse profilo)
        {
            if (IsStagioneIniziata())
                throw new Exception("Impossibile aggiungere un nuovo profilo al sistema! La stagione è gia iniziata.");

            if (profilo == null)
                throw new Exception("Impossibile aggiungere un profilo nullo al sistema! Operazione non effettuata.");

            if (!this.Gss.ProfiliPrezziRisorse.Add(profilo))
                throw new Exception("Impossibile aggiungere il  profilo al sistema! Il profilo selezionato esiste già nel sistema. Operazione non effettuata.");
        }

        public void EditProfilo(ProfiloPrezziRisorse profiloModificato, string nomeProfiloDaModificare)
        {
            if (IsStagioneIniziata())
                throw new Exception("Impossibile modificare il profilo selezionato! La stagione è gia iniziata.");

            ProfiloPrezziRisorse profiloDaModificare = GetProfiloPrezziRisorsaByNome(nomeProfiloDaModificare);

            if (profiloDaModificare == null)
                throw new Exception("Impossibile modificare il profilo selezionato! Il profilo da modificare potrebbe essere corrotto nel sistema.");

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
            if (IsStagioneIniziata())
                throw new Exception("Impossibile rimuovere il profilo selezionato dal sistema! La stagione è gia iniziata.");

            if (!this.Gss.ProfiliPrezziRisorse.Remove(profilo))
                throw new Exception("Impossibile rimuovere il profilo selezionato dal sistema! Operazione non effettuata.");
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
