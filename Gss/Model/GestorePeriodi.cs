using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Controller; // ATTENZIONE PASSARE A CONTROLLER!!!

namespace Gss.Model
{
    public class GestorePeriodi
    {

        //Fields

        private static GestorePeriodi _gestorePeriodi;
        private List<Periodo> periodi;

        //private DizionarioPeriodi _dizionarioPeriodi;
        //Constructors

        private GestorePeriodi() 
        {
            periodi = new List<Periodo>();
            
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

       /* public List<Periodo> TryAdd(Periodo periodo)
        {
            if (_dizionarioPeriodi == null)
            {
                //DIZIONARIO NON INIZIALIZZATO
            }


            return _dizionarioPeriodi.TryAdd(periodo);

        }

        public bool Add(Periodo p)
        {
            if (_dizionarioPeriodi == null)
                return false;
            this._dizionarioPeriodi.Add(p);
            return true;
        }*/

        public bool Remove(Periodo p) 
        {
            return this.Periodi.Remove(p);
        }

       /* public void SetStagione(DateTime dataInizioStagione, DateTime dataFineStagione)
        {
            if (_dizionarioPeriodi == null)
                _dizionarioPeriodi = new DizionarioPeriodi(dataInizioStagione, dataFineStagione);
            //TODO!!!!

        }*/

        public Periodo getPeriodoByData(DateTime data)
        {
            if( data == null)
                return null;
            
            foreach(Periodo p in Periodi)
            {
                if(p.IsDataInPeriodo(data))
                    return p;
            }
            return null;

        }

        /*public PrezziRisorsa getPrezzoRisorsaByData(Risorsa risorsa, DateTime data)
        {
            if (risorsa == null || data == null)
                return null;
            ProfiloPrezziRisorse profilo=_dizionarioProfili.GetProfiloByData(data);
            if(profilo==null)
                return null;
            return profilo.GetPrezziRisorsa(risorsa);
        }*/

        //Property

        public List<Periodo> Periodi
        {
            get { return periodi; }
            set { periodi = value; }
        }
    }

    
}
