using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class ProfiliPrezziRisorse //STATIC?!
    {
        private List<ProfiloPrezziRisorse> _profili;

        public ProfiliPrezziRisorse(List<ProfiloPrezziRisorse> profili)
        {
            _profili = new List<ProfiloPrezziRisorse>();
            _profili = profili;
        }

        public ProfiliPrezziRisorse()
        {
            _profili = new List<ProfiloPrezziRisorse>();
        }

        public List<ProfiloPrezziRisorse> Profili
        {
            get { return _profili; }
            set { _profili = value; }
        }

        public void Add(ProfiloPrezziRisorse profilo)
        {
            _profili.Add(profilo);
        }

        public bool Remove(ProfiloPrezziRisorse profilo)
        {
            return _profili.Remove(profilo);
        }

        public ProfiloPrezziRisorse GetProfiloPrezziRisorseByNome(string nomeProfilo)
        {
            ProfiloPrezziRisorse profilo=null;
            foreach(ProfiloPrezziRisorse p in _profili)
            {
                if(p.Nome==nomeProfilo)
                {
                    profilo = p;
                    break;
                }
            }
            return profilo; // trattare il caso nelle classi di sopra
        }
    }
}
