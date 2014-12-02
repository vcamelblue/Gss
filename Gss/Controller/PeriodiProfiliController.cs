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
        public PeriodiProfiliController()
            : base()
        {

        }
        public void RemoveAllPeriodi()
        {
            this.Gss.GestorePeriodi.Periodi = new List<Periodo>();
        }
        public void RemovePeriodo(Periodo periodo)
        {
            List<Periodo> periodi=this.Gss.GestorePeriodi.Periodi;
            if (periodi.Remove(periodo))
                throw new Exception("Il periodo che si tenta di rimuovere non è presente nella lista dei periodi");
            SetPeriodi(periodi);

        }

        public void AddPeriodo(Periodo periodo)
        {
            if (!CanAddPeriodo(periodo))
                throw new Exception("Non è possibile aggiungere il periodo perchè esiste già un periodo con data inizio "+periodo.DataInizio.ToString("dd MM yy"));
            List<Periodo> periodi = this.Gss.GestorePeriodi.Periodi;
            periodi.Add(periodo);
            SetPeriodi(periodi);
        }

        private bool CanAddPeriodo(Periodo periodo)
        {
            foreach(Periodo p in this.Gss.GestorePeriodi.Periodi)
            {
                if (p.DataInizio == periodo.DataInizio)
                    return false;
            }
            return true;
        }

        public List<Periodo> SetPeriodi(List<Periodo> periodi)
        {
            Periodo periodoTemp;
            periodi.Sort(new PeriodoComparer());
            List<Periodo> temp = new List<Periodo>(periodi);

            if (Gss.Resort.DataInizioStagione != temp.ElementAt(0).DataInizio)
            {

                temp.ElementAt(0).DataInizio = Gss.Resort.DataInizioStagione;
            }
            int i = 1;
            while (i < temp.Count)
            {
                DateTime data = temp.ElementAt(i).DataInizio.AddDays(-1);
                if (DateTime.Compare(data, temp.ElementAt(i - 1).DataFine) < 0)
                {
                    temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                }

                if (DateTime.Compare(data, temp.ElementAt(i - 1).DataFine) > 0)
                {
                    if (temp.ElementAt(i).DataFine > temp.ElementAt(i - 1).DataFine)
                    {
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                    }
                    else
                    {
                        periodoTemp = new Periodo(temp.ElementAt(i - 1).DataFine.AddDays(1), temp.ElementAt(i).DataFine, temp.ElementAt(i - 1).Profilo);
                        temp.Add(periodoTemp);
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                        temp.Sort(new PeriodoComparer());
                        i--;
                    }
                }
                i++;
            }
            temp.Last().DataFine = Gss.Resort.DataFineStagione;
            this.Gss.GestorePeriodi.Periodi = temp;
            return temp;

        }

        public string TrySetPeriodi(List<Periodo> periodi)
        {
            string result = "";
            Periodo periodoTemp;
            periodi.Sort(new PeriodoComparer());
            List<Periodo> temp = new List<Periodo>(periodi);

            if (Gss.Resort.DataInizioStagione != temp.ElementAt(0).DataInizio)
            {
                result += temp.ElementAt(0) + " modificato con data d'inizio portata a " + Gss.Resort.DataInizioStagione.ToString("dd/MM/yyyy") + "\n";
                temp.ElementAt(0).DataInizio = Gss.Resort.DataInizioStagione;
            }
            int i = 1;
            while (i < temp.Count)
            {
                DateTime data = temp.ElementAt(i).DataInizio.AddDays(-1);
                if (DateTime.Compare(data, temp.ElementAt(i - 1).DataFine) < 0)
                {
                    result += temp.ElementAt(i - 1) + " modificato con data fine portata a";
                    temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                    result += temp.ElementAt(i - 1).DataFine.ToString("dd/MM/yyyy") + "\n";
                }

                if (DateTime.Compare(data, temp.ElementAt(i - 1).DataFine) > 0)
                {
                    if (temp.ElementAt(i).DataFine < temp.ElementAt(i - 1).DataFine)
                    {
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                        result += temp.ElementAt(i - 1) + " modificato con data fine portata a" + temp.ElementAt(i - 1).DataFine.ToString("dd/MM/yyyy") + "\n";
                        
                    }
                    else
                    {
                        periodoTemp = new Periodo(temp.ElementAt(i - 1).DataFine.AddDays(1), temp.ElementAt(i).DataFine, temp.ElementAt(i - 1).Profilo);
                        temp.Add(periodoTemp);
                        temp.Sort(new PeriodoComparer());
                        i--;
                        result += "Inserito " + temp.ElementAt(i + 1) + " In " + temp.ElementAt(i) + "\n";//Problema nel scrivere chi viene inserito in chi
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                    }
                }
                i++;
            }
            return result;

        }

        /* public string TrySetPeriodi(List<Periodo> periodi)
         {
             string result = "";
             periodi.Sort(new PeriodoComparer());
             List<Periodo> temp =new List<Periodo>(periodi);
            
             if (Gss.Resort.DataInizioStagione != temp.ElementAt(0).DataInizio)
             {
                 result += temp.ElementAt(0) + " modificato con data d'inizio portata a " + Gss.Resort.DataInizioStagione.ToString("dd/MM/yyyy")+"\n";
                 temp.ElementAt(0).DataInizio = Gss.Resort.DataInizioStagione;
             }
             int i=1;
             while(i<periodi.Count)
             {
                 DateTime data = temp.ElementAt(i).DataInizio.AddDays(1);
                 if (data > temp.ElementAt(i - 1).DataFine)
                 {
                     result += temp.ElementAt(i - 1) + " modificato con data fine portata a";
                     temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                     result += temp.ElementAt(i - 1).DataFine.ToString("dd/MM/yyyy")+"\n";
                 }

                 if(temp.ElementAt(i).DataInizio<temp.ElementAt(i-1).DataFine)
                 {
                     if(temp.ElementAt(i).DataFine> temp.ElementAt(i-1).DataFine)
                     {
                         result += temp.ElementAt(i - 1) + " modificato con data fine portata a" + temp.ElementAt(i - 1).DataFine.ToString("dd/MM/yyyy")+"\n";
                         temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                     }
                     else
                     {
                         Periodo periodoTemp = new Periodo(temp.ElementAt(i).DataFine.AddDays(1), temp.ElementAt(i - 1).DataFine, temp.ElementAt(i - 1).Profilo);
                         temp.Add(periodoTemp);
                         result += "Inserito " + temp.ElementAt(i) + " In " + periodi.ElementAt(i - 1)+"\n";
                         temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                         temp.Sort(new PeriodoComparer());
                     }
                 }
                 i++;
             }
             return result;
         }*/
        
        public List<Periodo> GetAllPeriodi()
        {
            return this.Gss.GestorePeriodi.Periodi;
        }

        public PrezziRisorsa GetPrezzoRisorsaByData(Risorsa risorsa, DateTime data)
        {
            PrezziRisorsa prezzi = Gss.GestorePeriodi.getPrezzoRisorsaByData(risorsa, data);
            if (prezzi == null)
            {
                throw new Exception("Non esistono prezzi della risorsa per la data specificata");
            }
            return prezzi;
        }



        public ProfiloPrezziRisorse GetProfiloByNome(string nomeProfilo)
        {
            ProfiloPrezziRisorse profilo = Gss.ProfiliPrezziRisorse.GetProfiloPrezziRisorseByNome(nomeProfilo);
            if (profilo == null)
                throw new Exception("Non esiste il profilo per il nome specificato");
            return profilo;
        }

        public ProfiliPrezziRisorse GetProfili()
        {
            return Gss.ProfiliPrezziRisorse;
        }

        public void SetPrezzoRisorsa(Risorsa risorsa, ProfiloPrezziRisorse profilo, PrezziRisorsa prezzi)
        {
            if (risorsa == null || profilo == null || prezzi == null)
                throw new Exception("Inseriti parametri sbagliati");
            if (!this.Gss.ProfiliPrezziRisorse.Profili.Contains(profilo))
                throw new Exception("Il profilo inserito non esiste nel sistema");
            ProfiloPrezziRisorse p = this.Gss.ProfiliPrezziRisorse.GetProfiloPrezziRisorseByNome(profilo.Nome);
            p.PrezziRisorsa.Add(risorsa, prezzi);
        }

        public void SetPrezzoRisorsa(Risorsa risorsa, string nomeProfilo, PrezziRisorsa prezzi)
        {
            if (risorsa == null || nomeProfilo == null || prezzi == null)
                throw new Exception("Inseriti parametri sbagliati");
            ProfiloPrezziRisorse p = this.Gss.ProfiliPrezziRisorse.GetProfiloPrezziRisorseByNome(nomeProfilo);
            if (p == null)
                throw new Exception("Il profilo inserito non esiste nel sistema");
            p.PrezziRisorsa.Add(risorsa, prezzi);
        }

        public double GetPrezzoRisorsaByProfilo(Risorsa risorsa, ProfiloPrezziRisorse profilo)
        {
            double result = 0;
            ProfiloPrezziRisorse prof = GetProfiloByNome(profilo.Nome);
            result = prof.GetPrezziRisorsa(risorsa).Prezzo;
            if (result == null || result == 0)
                throw new Exception("Prezzo della risorsa non impostato per il profilo richiesto");
            return result;
        }

        public double GetPrezzoSpecificoRisorsaByProfilo(Risorsa risorsa, ProfiloPrezziRisorse profilo, TipologiaPrezzo tipologia)
        {
            double result = 0;
            ProfiloPrezziRisorse prof = GetProfiloByNome(profilo.Nome);
            List<PrezzoSpecifico> prezziSpecifici = prof.GetPrezziRisorsa(risorsa).PrezziSpecifici;
            foreach (PrezzoSpecifico ps in prezziSpecifici)
            {
                if (ps.Tipologia == tipologia)
                {
                    result = ps.Valore;
                    break;
                }
            }
            if (result == null || result == 0)
                throw new Exception("Non è specificato il prezzo specifico per la tipologia desiderata");
            return result;
        }

        public void AddProfilo(ProfiloPrezziRisorse profilo)
        {
            if (this.Gss.ProfiliPrezziRisorse.Profili.Contains(profilo))
                throw new Exception("Aggiunto Profilo già esistente");
            this.Gss.ProfiliPrezziRisorse.Add(profilo);
        }

        public void SetProfilo(ProfiloPrezziRisorse profilo, string nomeProfiloPrimaDelleModifiche)
        {
            ProfiloPrezziRisorse profiloDaModificare= GetProfiloByNome(nomeProfiloPrimaDelleModifiche);
            if (profilo.PrezziRisorsa.Count == profiloDaModificare.PrezziRisorsa.Count)
            {
                if (!ProfiloIsChanged(profilo, profiloDaModificare))
                    throw new Exception("Il profilo non è stato modificato");
            }
            Gss.ProfiliPrezziRisorse.Remove(profiloDaModificare);
            Gss.ProfiliPrezziRisorse.Add(profilo);
            //this.Gss.ProfiliPrezziRisorse.Profili.Remove();
        }

        private static bool ProfiloIsChanged(ProfiloPrezziRisorse p1, ProfiloPrezziRisorse p2)
        {
            if (p1.Nome != p2.Nome)
                return true;
            foreach(Risorsa r in p1.PrezziRisorsa.Keys)
            {
                if (!p2.PrezziRisorsa[r].Equals(p1.PrezziRisorsa[r]))
                    return true;
            }
            return false;
        }

        public void RemoveProfilo(ProfiloPrezziRisorse profilo)
        {
            if (!this.Gss.ProfiliPrezziRisorse.Remove(profilo))
                throw new Exception("Profilo non rimosso");
        }
            
        
    }
}
