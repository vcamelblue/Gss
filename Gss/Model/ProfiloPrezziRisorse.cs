using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class ProfiloPrezziRisorse : ICloneable
    {
        private string _nome;
        private Dictionary<Risorsa, PrezziRisorsa> _prezziRisorsa;

        public ProfiloPrezziRisorse(string nome)
        {
            _nome = nome;
            _prezziRisorsa = new Dictionary<Risorsa, PrezziRisorsa>();
        }

        public ProfiloPrezziRisorse()
            : this(null)
        {

        }

        public Dictionary<Risorsa, PrezziRisorsa> PrezziRisorse
        {
            get { return _prezziRisorsa; }
            set { _prezziRisorsa = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
      

        public void Add(Risorsa risorsa, PrezziRisorsa prezziRisorsa)
        {
            _prezziRisorsa.Add(risorsa, prezziRisorsa);
        }

        public bool Remove(Risorsa risorsa)
        {
            return _prezziRisorsa.Remove(risorsa);
        }

        public PrezziRisorsa GetPrezziRisorsa(Risorsa risorsa)
        {
            if (_prezziRisorsa.Keys.Contains(risorsa))
                return _prezziRisorsa[risorsa];
            
            return null;
        }

        public override string ToString()
        {
            return this.Nome;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            ProfiloPrezziRisorse profilo;

            if (obj is ProfiloPrezziRisorse)
                profilo = (ProfiloPrezziRisorse)obj;
            else
                return false;

            return (this.Nome == profilo.Nome);
        }

        public object Clone()
        {
            ProfiloPrezziRisorse result = new ProfiloPrezziRisorse(this.Nome);

            result.PrezziRisorse = new Dictionary<Risorsa, PrezziRisorsa>();

            foreach(Risorsa risorsa in this.PrezziRisorse.Keys){

                Risorsa risClone = (Risorsa) risorsa.Clone();
                PrezziRisorsa prezziRisClone = (PrezziRisorsa) this.PrezziRisorse[risorsa].Clone();

                result.Add(risClone, prezziRisClone);
            }
            return result;
        }
    }
}
