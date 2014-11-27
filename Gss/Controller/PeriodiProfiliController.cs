using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Controller
{
    public class PeriodiProfiliController :MyController
    {
        public PeriodiProfiliController():base()
        {

        }


        

        public List<Periodo> SetPeriodi(List<Periodo> periodi)
        {
            Periodo periodoTemp;
            periodi.Sort(new PeriodoComparer());
            List<Periodo> temp =new List<Periodo>(periodi);
            
            if (Gss.Resort.DataInizioStagione != temp.ElementAt(0).DataInizio)
            {
                
                temp.ElementAt(0).DataInizio = Gss.Resort.DataInizioStagione;
            }
            int i=1;
            while(i<temp.Count)
            {
                DateTime data = temp.ElementAt(i).DataInizio.AddDays(-1);
                if (DateTime.Compare(data , temp.ElementAt(i - 1).DataFine)<0)
                {
                    temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                }

                if(DateTime.Compare(data,temp.ElementAt(i-1).DataFine)>0)
                {
                    if(temp.ElementAt(i).DataFine< temp.ElementAt(i-1).DataFine)
                    {
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                    }
                    else
                    {
                        periodoTemp = new Periodo(temp.ElementAt(i-1).DataFine.AddDays(1), temp.ElementAt(i).DataFine, temp.ElementAt(i - 1).Profilo);
                        temp.Add(periodoTemp);
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                        temp.Sort(new PeriodoComparer());
                        i--;
                    }
                }
                i++;
            }
            GSS.GetInstance().GestorePeriodi.Periodi = temp;
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
                        result += temp.ElementAt(i - 1) + " modificato con data fine portata a" + temp.ElementAt(i - 1).DataFine.ToString("dd/MM/yyyy") + "\n";
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                    }
                    else
                    {
                        periodoTemp = new Periodo(temp.ElementAt(i - 1).DataFine.AddDays(1), temp.ElementAt(i).DataFine, temp.ElementAt(i - 1).Profilo);
                        temp.Add(periodoTemp);
                        temp.Sort(new PeriodoComparer());
                        i--;
                        result += "Inserito " + temp.ElementAt(i+1) + " In " + temp.ElementAt(i) + "\n";//Problema nel scrivere chi viene inserito in chi
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

        public PrezziRisorsa GetPrezzoRisorsaByData(Risorsa risorsa,DateTime data)
        {
            PrezziRisorsa prezzi= Gss.GestorePeriodi.getPrezzoRisorsaByData(risorsa, data);
            if(prezzi==null)
            {
                throw new Exception("Non esistono prezzi della risorsa per la data specificata");
            }
            return prezzi;
        }

        

        public ProfiloPrezziRisorse GetProfiloByNome(string nomeProfilo)
        {
            ProfiloPrezziRisorse profilo=Gss.ProfiliPrezziRisorse.GetProfiloPrezziRisorseByNome(nomeProfilo);
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

        public void SetPrezzoRisorsa(Risorsa risorsa,string nomeProfilo, PrezziRisorsa prezzi)
        {
            if (risorsa == null || nomeProfilo == null || prezzi == null)
                throw new Exception("Inseriti parametri sbagliati");    
            ProfiloPrezziRisorse p = this.Gss.ProfiliPrezziRisorse.GetProfiloPrezziRisorseByNome(nomeProfilo);
            if(p==null)
                throw new Exception("Il profilo inserito non esiste nel sistema");
            p.PrezziRisorsa.Add(risorsa, prezzi);
        }
    }
}
