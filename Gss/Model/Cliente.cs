using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class Cliente
    {
        private string _nome;
        private string _cognome;
        private string _codiceFiscale;
        private DateTime _dataNascita;
        private List<Contatto> _contatti;

        public Cliente(string nome, string cognome, string codiceFiscale, DateTime dataNascita, Contatto contatto)
        {
            _nome = nome;
            _cognome = cognome;
            _codiceFiscale = codiceFiscale;
            _dataNascita = dataNascita;
            _contatti = new List<Contatto>();
            _contatti.Add(contatto);
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        public string CodiceFiscale
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value; }
        }

        public DateTime DataNascita
        {
            get { return _dataNascita; }
            set { _dataNascita = value; }
        }

        public List<Contatto> Contatti
        {
            get { return _contatti; }
            set { _contatti = value; }
        }

        public void add(Contatto contatto)
        {
            Contatti.Add(contatto);
        }

        public bool remove(Contatto contatto)
        {
            if (Contatti.Count == 1) return false;
            else return Contatti.Remove(contatto);
        }


    }
}
