using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class GSS
    {
        private static GSS _gss;
        private static int _numeroPrenotazioni = 0;
        private static int _numeroSkiCards = 0;
        private static int _numeroSkiPass = 0;
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
        }

        public static GSS GetInstance()
        {
            if (_gss == null)
            {
                _gss = new GSS();
            }
            return _gss;
        }

        internal Resort Resort
        {
            get { return _resort; }
            set { _resort = value; }
        }

        internal Prenotazioni Prenotazioni
        {
            get { return _prenotazioni; }
            set { _prenotazioni = value; }
        }

        internal Direttore Direttore
        {
            get { return _direttore; }
            set { _direttore = value; }
        }

        internal Clienti Clienti
        {
            get { return _clienti; }
            set { _clienti = value; }
        }

        public GestorePeriodi GestorePeriodi
        {
            get { return _gestorePeriodi; }
            set { _gestorePeriodi = value; }
        }

        internal ProfiliPrezziRisorse ProfiliPrezziRisorse
        {
            get { return _profiliPrezziRisorse; }
            set { _profiliPrezziRisorse = value; }
        }
        
    }
}
