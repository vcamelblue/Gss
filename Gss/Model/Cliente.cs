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
        private string _telefono;
        private string _email;

        public Cliente(string nome, string cognome, string codiceFiscale, DateTime dataNascita, string telefono, string email)
        {
            _nome = nome;
            _cognome = cognome;
            _codiceFiscale = codiceFiscale;
            _dataNascita = dataNascita;
            _email = email;
            _telefono = telefono;
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

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Cliente cliente = null;
            if (obj is Cliente)
                cliente = (Cliente)obj;
            else
                return false;
            if (cliente.CodiceFiscale.Equals(this.CodiceFiscale) &&
                cliente.Cognome.Equals(this.Cognome) && cliente.DataNascita.Equals(this.DataNascita) &&
                cliente.Email.Equals(this.Email))
                return true;
            else return false;
        }

        public override string ToString()
        {
            return this.Nome + " " + this.Cognome + " " + this.DataNascita.ToShortDateString() + " " + this.CodiceFiscale + " " + this.Email;
        }
    }
}
