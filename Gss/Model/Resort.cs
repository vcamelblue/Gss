﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class Resort
    {
        private string _nome;
        private string _indirizzo;
        private string _email;
        private string _telefono;
        private Impianti _impianti;
        private Bungalows _bungalows;
        private DateTime _dataInizioStagione;
        private DateTime _dataFineStagione;


        public Resort(string nome, string indirizzo, string email, string telefono)
        {
            _nome = nome;
            _indirizzo = indirizzo;
            _email = email;
            _telefono = telefono;
            _impianti = new Impianti();
            _bungalows = new Bungalows();
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Indirizzo
        {
            get { return _indirizzo; }
            set { _indirizzo = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        internal Impianti Impianti
        {
            get { return _impianti; }
            set { _impianti = value; }
        }

        internal Bungalows Bungalows
        {
            get { return _bungalows; }
            set { _bungalows = value; }
        }

        public DateTime DataInizioStagione
        {
            get { return _dataInizioStagione; }
            set { _dataInizioStagione = value; }
        }

        public DateTime DataFineStagione
        {
            get { return _dataFineStagione; }
            set { _dataFineStagione = value; }
        }

        public void AddBungalow(Bungalow bungalow)
        {
            Bungalows.Add(bungalow);
        }

        public void AddImpianto(Impianto impianto)
        {
            Impianti.Add(impianto);
        }

        public bool RemoveBungalow(Bungalow bungalow)
        {
            return Bungalows.Remove(bungalow);
        }

        public bool RemoveImpianto(Impianto impianto)
        {
            return Impianti.Remove(impianto);
        }
    }
}
