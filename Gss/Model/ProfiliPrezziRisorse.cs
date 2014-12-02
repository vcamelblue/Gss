using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class ProfiliPrezziRisorse //STATIC?!
    {
        private List<ProfiloPrezziRisorse> _profili;

        public ProfiliPrezziRisorse(List<ProfiloPrezziRisorse> profili)
        {
            _profili = profili;
        }

        public ProfiliPrezziRisorse()
            : this(new List<ProfiloPrezziRisorse>())
        {

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
