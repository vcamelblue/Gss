using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class Resort
    {
        private string _nome;
        private string _indirizzo;
        private string _email;
        private string _telefono;

        private Impianti _impianti;
        private Bungalows _bungalows;

        private DateTime _dataInizioStagione;
        private DateTime _dataFineStagione;


        public Resort()
            : this("", "", "", "", DateTime.MinValue, DateTime.MinValue)
        {

        }

        public Resort(string nome, string indirizzo, string email, string telefono)
        {
            _nome = nome;
            _indirizzo = indirizzo;
            _email = email;
            _telefono = telefono;

            _impianti = new Impianti();
            _bungalows = new Bungalows();
        }

        public Resort(string nome, string indirizzo, string email, string telefono,DateTime dataInizio, DateTime dataFine)
            : this(nome, indirizzo,email,telefono)
        {
            _dataInizioStagione = dataInizio;
            _dataFineStagione = dataFine;
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

        public Impianti Impianti
        {
            get { return _impianti; }
            set { _impianti = value; }
        }

        public Bungalows Bungalows
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

        public void SetStagione(DateTime dataInizioStagione, DateTime dataFineStagione)
        {
            this.DataInizioStagione = dataInizioStagione;
            this.DataFineStagione = dataFineStagione;
        }

        public bool isStagioneImpostata()
        {
            return (DataInizioStagione.Date != DateTime.MinValue.Date && DataFineStagione.Date != DateTime.MinValue.Date);
        }
        
        public bool isStagioneIniziata()
        {
            return (isStagioneImpostata() && 
                   (DataInizioStagione.Date <= DateTime.Now.Date && DateTime.Now.Date <= DataFineStagione.Date));
        }

    }
}
