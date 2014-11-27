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


        

        public List<Periodo> AddPeriodi(List<Periodo> periodi)
        {
            periodi.Sort(new PeriodoComparer());
            List<Periodo> temp =new List<Periodo>(periodi);
            
            if (Gss.Resort.DataInizioStagione != temp.ElementAt(0).DataInizio)
            {
                
                temp.ElementAt(0).DataInizio = Gss.Resort.DataInizioStagione;
            }
            int i=1;
            while(i<periodi.Count)
            {
                DateTime data = temp.ElementAt(i).DataInizio.AddDays(-1);
                if (temp.ElementAt(i).DataInizio > temp.ElementAt(i - 1).DataFine)
                {
                    temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                }

                if(temp.ElementAt(i).DataInizio<temp.ElementAt(i-1).DataFine)
                {
                    if(temp.ElementAt(i).DataFine> temp.ElementAt(i-1).DataFine)
                    {
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                    }
                    else
                    {
                        Periodo periodoTemp = new Periodo(temp.ElementAt(i).DataFine.AddDays(1), temp.ElementAt(i - 1).DataFine, temp.ElementAt(i - 1).Profilo);
                        temp.Add(periodoTemp);
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                        temp.Sort(new PeriodoComparer());
                    }
                }
                i++;
            }
            GSS.GetInstance().GestorePeriodi.Periodi = temp;
            return temp;

        }
        

        public string TryAddPeriodi(List<Periodo> periodi)
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
        }



    }
}
