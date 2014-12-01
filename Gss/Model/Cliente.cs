using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class Cliente
    {
        private string _nome;
        private string _cognome;
        private string _codiceFiscale;
        private DateTime _dataNascita;
        private string _indirizzo;
        private string _telefono;
        private string _email;

        public Cliente(string nome, string cognome, string codiceFiscale, DateTime dataNascita, string indirizzo, string telefono, string email)
        {
            _nome = nome;
            _cognome = cognome;
            _codiceFiscale = codiceFiscale;
            _dataNascita = dataNascita;
            _indirizzo = indirizzo;
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

        public string Indirizzo 
        { 
            get { return _indirizzo; }
            set { _indirizzo = value; }
        }

        public string Telefono //aggiungere return "" se nullo
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
            if (cliente.CodiceFiscale.Equals(this.CodiceFiscale) && cliente.Nome.Equals(this.Nome) &&
                cliente.Cognome.Equals(this.Cognome) && cliente.DataNascita.Equals(this.DataNascita))
                return true;
            else return false;
        }

        public override string ToString()
        {
            return this.Nome + " " + this.Cognome + " " + this.DataNascita.ToShortDateString() + " " + this.CodiceFiscale + " " + this.Indirizzo + " " + this.Email + " " + this.Telefono ;
        }

        public bool Identic(Cliente cliente)
        {
            if (this.Equals(cliente) && this.Indirizzo == cliente.Indirizzo && this.Telefono == cliente.Telefono && this.Email == cliente.Email)
                return true;
            return false;
        }
    }
}
