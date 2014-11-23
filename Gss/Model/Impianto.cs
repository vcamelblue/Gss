using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class Impianto : Risorsa
    {
        private string _nome;
        private string _versante;
        private List<Pista> _piste;

        public Impianto(string codice, string nome, string versante) 
            : base(codice)
        {
            _nome = nome;
            _versante = versante;
            _piste = new List<Pista>();
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Versante
        {
            get { return _versante; }
            set { _versante = value; }
        }

        internal List<Pista> Piste
        {
            get { return _piste; }
            set { _piste = value; }
        }

        public int NumeroPiste() 
        {
            return _piste.Count;
        }

        public List<Alpina> GetPisteAlpine()
        {
            List<Alpina> result = new List<Alpina>();
            foreach (Pista p in Piste)
            {
                if (p is Alpina)
                {
                    Alpina pistaAlpina = (Alpina)p;
                    result.Add(pistaAlpina);
                }
            }
            return result;
        }

        public List<Fondo> GetPisteFondo()
        {
            List<Fondo> result = new List<Fondo>();
            foreach (Pista p in Piste)
            {
                if (p is Fondo)
                {
                    Fondo pistaFondo = (Fondo)p;
                    result.Add(pistaFondo);
                }
            }
            return result;
        }

        public List<SnowPark> GetPisteSnowPark()
        {
            List<SnowPark> result = new List<SnowPark>();
            foreach (Pista p in Piste)
            {
                if (p is SnowPark)
                {
                    SnowPark pistaSnowPark = (SnowPark)p;
                    result.Add(pistaSnowPark);
                }
            }
            return result;
        }

        public void Add(Pista pista)
        {
            Piste.Add(pista);
        }

        public bool Remove(Pista pista)
        {
            return Piste.Remove(pista);
        }

        public override bool Equals(object obj)
        {
            Impianto impianto = null;
            if (base.Equals(obj) && obj is Impianto)
            {
                impianto = (Impianto)obj;
            }
            else 
                return false;

            if (impianto.Piste.Count != this.Piste.Count)
                return false;

            List<Pista> temp =impianto.Piste.ToList<Pista>();
            bool trovato = false;

            foreach(Pista p in this.Piste)
            {
                foreach(Pista pObj in impianto.Piste)
                {
                    if(p.Equals(pObj))
                    {
                        temp.Remove(pObj);
                        trovato = true;
                        break;
                    }
                }
                if (!trovato)
                    return false;
                else
                    trovato = false;
            }
            return true;
        }

        public override string ToString()
        {
            string result = "";
            result += this._nome + " " + this._versante + " \n";
            foreach(Pista p in this._piste)
            {
                result += p.ToString() + "\Sn";
            }
            return result;
        }
    }
}
