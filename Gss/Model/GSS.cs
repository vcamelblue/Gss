using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class GSS
    {
        private static GSS _gss;

        private Resort _resort;
        private Prenotazioni _prenotazioni;
        private Clienti _clienti;
        private GestorePeriodi _gestorePeriodi;
        private ProfiliPrezziRisorse _profiliPrezziRisorse;

        private int _numeroPrenotazioni;
        private int _numeroSkiPass;
        private  int _numeroSkiCards;


        private GSS() 
        {
            _resort = new Resort();
            _clienti = new Clienti();
            _prenotazioni = new Prenotazioni();
            _gestorePeriodi = GestorePeriodi.GetInstance();
            _profiliPrezziRisorse = new ProfiliPrezziRisorse();

            _numeroPrenotazioni = 0;
            _numeroSkiCards = 0;
            _numeroSkiPass = 0;
        }

        public static GSS GetInstance()
        {
            if (_gss == null)
            {
                _gss = new GSS();
            }
            return _gss;
        }

        public Resort Resort
        {
            get { return _resort; }
            set { _resort = value; }
        }

        public Prenotazioni Prenotazioni
        {
            get { return _prenotazioni; }
            set { _prenotazioni = value; }
        }

        public Clienti Clienti
        {
            get { return _clienti; }
            set { _clienti = value; }
        }

        public GestorePeriodi GestorePeriodi
        {
            get { return _gestorePeriodi; }
            set { _gestorePeriodi = value; }
        }

        public ProfiliPrezziRisorse ProfiliPrezziRisorse
        {
            get { return _profiliPrezziRisorse; }
            set { _profiliPrezziRisorse = value; }
        }


        //TODO, FARE REFACTOR DI QUESTI METODI PER OTTENERE IL NUMERO GIUSTO ANCHE SE SI ANNULLA LA PRENOTAZIONE
        public int ProssimoNumeroPrenotazione
        {
            get
            {
                _numeroPrenotazioni++;
                return _numeroPrenotazioni;
            }
        }

        public int ProssimoNumeroSkiCard
        {
            get
            {
                _numeroSkiCards++;
                return _numeroSkiCards;
            }
        }

        public int ProssimoNumeroSkiPass
        {
            get
            {
                _numeroSkiPass++;
                return _numeroSkiPass;
            }
        }
    }
}
