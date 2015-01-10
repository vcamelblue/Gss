using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gss.Model
{
    public class GestorePeriodi
    {

        //Fields

        private static GestorePeriodi _gestorePeriodi;
        private List<Periodo> periodi;

       
        //Constructors

        private GestorePeriodi() 
        {
            periodi = new List<Periodo>();            
        }

        //Property

        public List<Periodo> Periodi
        {
            get { return periodi; }
            set { periodi = value; }
        }

        //Methods

        public static GestorePeriodi GetInstance()
        {
            if(_gestorePeriodi == null)
            {
                _gestorePeriodi = new GestorePeriodi();
            }
            return _gestorePeriodi;
        }


        public void Add(Periodo p)
        {
            this.Periodi.Add(p);
        }

        public bool Remove(Periodo p) 
        {
            return this.Periodi.Remove(p);
        }


        public Periodo getPeriodoByData(DateTime data)
        {
            //RIVEDERE DateTime e valori nulli!!!!!!
            //if( data == null)
            //    return null;
            
            foreach(Periodo p in Periodi)
            {
                if(p.IsDataInPeriodo(data))
                    return p;
            }
            return null;

        }

        public PrezziRisorsa getPrezzoRisorsaByData(Risorsa risorsa, DateTime data)
        {
            if (risorsa == null /*|| data == null*/)
                return null;

            Periodo periodo = getPeriodoByData(data);

            if (periodo != null) 
            {
                return periodo.Profilo.GetPrezziRisorsa(risorsa);
            }

            return null;
        }

        public string TrySetPeriodi(List<Periodo> periodi)
        {
            GSS Gss = GSS.GetInstance();

            string result = "";
            Periodo periodoTemp;
            List<Periodo> temp = new List<Periodo>();
            periodi.Sort(new PeriodoComparer());

            foreach (Periodo p in periodi)
            {
                if (!(p.DataFine.Date <= Gss.Resort.DataInizioStagione.Date ||
                     p.DataInizio.Date >= Gss.Resort.DataFineStagione.Date))
                {
                    temp.Add((Periodo)p.Clone());
                }
                else
                {
                    result += p.ToString() + " Eliminato in quanto non compatibile con le date della stagione! \n";
                }
            }


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
                    result += temp.ElementAt(i - 1) + " modificato con data fine portata a " + temp.ElementAt(i).DataInizio.AddDays(-1).ToShortDateString() + "\n";
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
            GSS Gss = GSS.GetInstance();

            Periodo periodoTemp;
            List<Periodo> temp = new List<Periodo>();
            periodi.Sort(new PeriodoComparer());

            foreach (Periodo p in periodi)
            {
                if(!(p.DataFine.Date <= Gss.Resort.DataInizioStagione.Date ||
                     p.DataInizio.Date >= Gss.Resort.DataFineStagione.Date    ))
                {
                    temp.Add(p);
                }
            }

            if (temp.Count == 0)
            {
                Gss.GestorePeriodi.Periodi = new List<Periodo>();
                return new List<Periodo>();
            }

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
            if (DateTime.Compare(temp.ElementAt(i).DataFine.Date, Gss.Resort.DataFineStagione.Date) != 0)
            {
                temp.ElementAt(i).DataFine = Gss.Resort.DataFineStagione;
            }
            temp.Sort(new PeriodoComparer());
            Gss.GestorePeriodi.Periodi = temp;
            return temp;
        }

        public string AllineaPeriodi()
        {
            string result = "";
            GSS Gss = GSS.GetInstance();

            if (Gss.GestorePeriodi.Periodi.Count == 0)
                return "";
            
            result=Gss.GestorePeriodi.TrySetPeriodi(Gss.GestorePeriodi.Periodi);
            Gss.GestorePeriodi.SetPeriodi(Gss.GestorePeriodi.Periodi);
            
            return result;
        }
    }

    
}
