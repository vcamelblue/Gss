using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class DizionarioProfili :SortedDictionary<DateTime,string>
    {
        private DateTime _dataInizioStagione;
        private DateTime _dataFineStagione;

        public DizionarioProfili(DateTime dataInizioStagione, DateTime dataFineStagione):base()
        {
            DateTime data = dataInizioStagione;
            while(data<dataFineStagione)
            {
                base.Add(data, "");
                data.AddDays(1);
            }
        }

        public bool Contains(DateTime data)
        {
            string p;
            if (!this.TryGetValue(data, out p))
                throw new Exception("Errore DizionarioPeriodi");
            if (p == "")
                return false;
            return true;
        }
        
        public bool Add(Periodo value)
        {
            if (value.Profilo.Nome == null)
                return false;
                //throw new Exception("Inserito periodo nullo nel dizionario");
            DateTime data = value.DataInizio.Date;
            while(data<value.DataFine)
            {
                this[data] = value.Profilo.Nome;
                data.AddDays(1);
            }
            return true;
        }

         public string TryAdd(Periodo value)
        {
             string result = "Verranno modificati il:";
             DateTime data = value.DataInizio.Date;
             while(data<value.DataFine)
             {

                 if (this[data] != "")
                     result += data;
                 data.AddDays(1);
             }
           
             return result;
        }

        public string GetProfiloByData(DateTime data)
         {
             if (!this.Contains(data))
                 return null;
             return this[data];
         }
    }
}
