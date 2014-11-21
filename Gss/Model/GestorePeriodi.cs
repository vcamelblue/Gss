﻿using System;
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
        private List<Periodo> periodi = new List<Periodo>();


        //Constructors

        private GestorePeriodi() { }


        //Methods

        public GestorePeriodi GetInstance()
        {
            if(_gestorePeriodi==null)
            {
                _gestorePeriodi = new GestorePeriodi();
            }
            return _gestorePeriodi;
        }


        public void Add(Periodo p)
        {
            this.periodi.Add(p);
        }

        public bool Remove(Periodo p) 
        {
            return this.periodi.Remove(p);
        }

        public Periodo getPeriodoByData(DateTime data)
        {
            if( data == null)
                return null;
            
            foreach(Periodo p in periodi)
            {
                if(p.IsDataInPeriodo(data))
                    return p;
            }
            return null;

        }

        public PrezziRisorsa getPrezzoRisorsaByData(Risorsa risorsa, DateTime data)
        {
            if (risorsa == null || data == null)
                return null;

            Periodo periodo = getPeriodoByData(data);

            if (periodo != null) 
            {
                return periodo.Profilo.GetPrezziRisorsa(risorsa);
            }

            return null;
        }


        //Property

        public List<Periodo> Periodi 
        {
            get { return periodi; }
            set { periodi = value; }
        }
    }

    
}
