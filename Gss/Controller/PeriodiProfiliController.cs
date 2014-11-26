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


        public void AddPeriodi(List<Periodo> periodi)
        {
            periodi.Sort(new PeriodoComparer());
            if(Gss.Resort.DataInizioStagione != periodi.ElementAt(0).DataInizio)
            {
                periodi.ElementAt(0).DataInizio = Gss.Resort.DataInizioStagione;
                
            }
           
        }

        public string TryAddPeriodi(List<Periodo> periodi)
        {
            string result = "";
            periodi.Sort(new PeriodoComparer());
            List<Periodo> temp =new List<Periodo>(periodi);
            
            if (Gss.Resort.DataInizioStagione != temp.ElementAt(0).DataInizio)
            {
                temp.ElementAt(0).DataInizio = Gss.Resort.DataInizioStagione;
                result += temp.ElementAt(0) + " modificato con data d'inizio portata a " + Gss.Resort.DataInizioStagione; 
            }
            int i=1;
            while(i<periodi.Count)
            {
                Console.Out.WriteLine("!!!!!!!!!!!!");
                Console.Out.WriteLine(periodi.ElementAt(i).DataInizio);
                if(temp.ElementAt(i).DataInizio.AddDays(-1)> temp.ElementAt(i-1).DataFine)
                {
                    temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(1);
                    result += temp.ElementAt(i - 1) + " modificato con data fine portata a" + temp.ElementAt(i - 1).DataFine;
                }

                if(temp.ElementAt(i).DataInizio<temp.ElementAt(i-1).DataFine)
                {
                    if(temp.ElementAt(i).DataFine> temp.ElementAt(i-1).DataFine)
                    {
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                        result += temp.ElementAt(i - 1) + " modificato con data fine portata a" + temp.ElementAt(i - 1).DataFine;
                    }
                    else
                    {
                        Periodo periodoTemp = new Periodo(temp.ElementAt(i).DataFine.AddDays(1), temp.ElementAt(i - 1).DataFine, temp.ElementAt(i - 1).Profilo);
                        temp.Add(periodoTemp);
                        temp.ElementAt(i - 1).DataFine = temp.ElementAt(i).DataInizio.AddDays(-1);
                        result += "Inserito "+ temp.ElementAt(i)+" In "+ periodi.ElementAt(i-1);
                        temp.Sort(new PeriodoComparer());
                    }
                }
                i++;
            }
            return result;

        }
    }
}
