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
        private int _numeroPrenotazioni;

        public int NumeroPrenotazioni
        {
            get 
            {
                _numeroPrenotazioni++;
                return _numeroPrenotazioni++; 
            }
        }
        private  int _numeroSkiCards;

        public int NumeroSkiCards
        {
            get 
            {
                _numeroSkiCards++;
                return _numeroSkiCards; 
            }
        }
        private int _numeroSkiPass;

        public int NumeroSkiPass
        {
            get 
            {
                _numeroSkiPass++;
                return _numeroSkiPass; 
            }
        }
        private Resort _resort;
        private Prenotazioni _prenotazioni;
        private Direttore _direttore;
        private Clienti _clienti;
        private GestorePeriodi _gestorePeriodi;
        private ProfiliPrezziRisorse _profiliPrezziRisorse;

        private GSS() 
        {
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

        public Direttore Direttore
        {
            get { return _direttore; }
            set { _direttore = value; }
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

        public bool SetStagione(DateTime dataInizioStagione, DateTime dataFineStagione)
        {
            //_gestorePeriodi.SetStagione(dataInizioStagione, dataInizioStagione);
            _resort.SetStagione(dataInizioStagione, dataFineStagione);
            return true;
            //TODO!!!!
        }
        
    }
}
