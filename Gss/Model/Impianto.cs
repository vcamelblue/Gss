﻿using System;
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

        public List<Pista> Piste
        {
            get { return _piste; }
            set { _piste = value; }
        }

        public int numeroPiste() 
        {
            return _piste.Count;
        }

        public List<Alpina> getPisteAlpine()
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

        public List<Fondo> getPisteFondo()
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

        public List<SnowPark> getPisteSnowPark()
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

        public void add(Pista pista)
        {
            Piste.Add(pista);
        }

        public bool remove(Pista pista)
        {
            return Piste.Remove(pista);
        }
    }
}