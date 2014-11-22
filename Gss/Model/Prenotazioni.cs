using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class Prenotazioni
    {
        private List<Prenotazione> _listaPrenotazioni;

        public Prenotazioni(List<Prenotazione> prenotazioni)
        {
            _listaPrenotazioni = prenotazioni;
        }

        public Prenotazioni(){
            _listaPrenotazioni = new List<Prenotazione>();
        }

        public List<Prenotazione> ListaPrenotazioni
        {
            get { return _listaPrenotazioni; }
            set { _listaPrenotazioni = value; }
        }

    }
}
