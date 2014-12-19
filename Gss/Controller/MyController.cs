using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Controller
{
    public abstract class MyController
    {
        private GSS _gss;

        public MyController()
        {
            _gss = GSS.GetInstance();
        }

        public GSS Gss
        {
            get { return _gss; }
        }


        public bool IsStagioneImpostata()
        {
            return this.Gss.Resort.isStagioneImpostata();
        }

        public bool IsStagioneIniziata()
        {
            return this.Gss.Resort.isStagioneIniziata();
        }

        public bool thereIsAtLeastOneRisorsa()
        {
            return (Gss.Resort.Bungalows.ListaBungalow.Count > 0 || Gss.Resort.Impianti.ListaImpianti.Count > 0);
        }

        public bool thereIsAtLeastOneProfilo()
        {
            return Gss.ProfiliPrezziRisorse.Profili.Count > 0;
        }

        public bool thereIsAtLeastOnePeriodo()
        {
            return Gss.GestorePeriodi.Periodi.Count > 0;
        }
    }
}
