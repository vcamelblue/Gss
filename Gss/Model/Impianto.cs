﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class Impianto : Risorsa, ICloneable
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

        public List<Pista> Piste
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
            if (obj == null)
                return false;

            Impianto otherImpianto = null;

            if (obj is Impianto)
                otherImpianto = (Impianto)obj;
            else
                return false;

            if (this.Codice != otherImpianto.Codice)
                return false;
            
            if (otherImpianto.Piste.Count != this.Piste.Count)
                return false;

            foreach (Pista p in this.Piste)
            {
                if (!otherImpianto.Piste.Contains(p))
                    return false;
            }

            return true;

            /*
            List<Pista> temp =otherImpianto.Piste.ToList<Pista>();
            bool trovato = false;

            foreach(Pista p in this.Piste)
            {
                foreach(Pista pObj in otherImpianto.Piste)
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
            */
        }

        public override string ToString()
        {
            return Codice+ " - " + Nome + ",  Versante: " + Versante + " ";
        }

        public override object Clone()
        {

            string codice = this.Codice;
            string nome = this.Nome;
            string versante = this.Versante;

            Impianto clone = new Impianto(codice, nome, versante);

            foreach (Pista p in Piste)
            {
                clone.Add((Pista)p.Clone());
            }

            return clone;
        }
    }
}
