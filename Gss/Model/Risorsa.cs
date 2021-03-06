﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public abstract class Risorsa : ICloneable, IEquatable<Risorsa>
    {
        private string _codice;

        public Risorsa(string codice)
        {
            _codice = codice;
        }

        public string Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        public PrezziRisorsa GetPrezzoFor(DateTime data)
        {
            Periodo periodo = GSS.GetInstance().GestorePeriodi.getPeriodoByData(data);
            
            return periodo == null ? null : periodo.Profilo.GetPrezziRisorsa(this);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Risorsa risorsa;

            if (obj is Risorsa)
                risorsa = (Risorsa)obj;
            else
                return false;

            return (risorsa.Codice == this.Codice);
        }

        public override string ToString()
        {
            return this.Codice;
        }

        public abstract object Clone();

        public bool Equals(Risorsa other)
        {
            if (other == null)
                return false;

           

            return (other.Codice == this.Codice);
        }

        public override int GetHashCode()
        {
            return this.Codice.GetHashCode();
        }
    }
}
