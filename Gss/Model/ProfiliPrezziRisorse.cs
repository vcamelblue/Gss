using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class ProfiliPrezziRisorse
    {
        private List<ProfiloPrezziRisorse> _profili;


        public ProfiliPrezziRisorse()
            : this(new List<ProfiloPrezziRisorse>())
        {

        }

        public ProfiliPrezziRisorse(List<ProfiloPrezziRisorse> profili)
        {
            _profili = profili;
        }


        public List<ProfiloPrezziRisorse> Profili
        {
            get { return _profili; }
            set { _profili = value; }
        }

        public bool Add(ProfiloPrezziRisorse profilo)
        {
            if (Profili.Contains(profilo))
                return false;

            Profili.Add(profilo);

            return true;
        }

        public bool Remove(ProfiloPrezziRisorse profilo)
        {
            return Profili.Remove(profilo);
        }

        public ProfiloPrezziRisorse GetProfiloPrezziRisorseByNome(string nomeProfilo)
        {

            foreach(ProfiloPrezziRisorse p in Profili)
            {
                if(p.Nome == nomeProfilo)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
