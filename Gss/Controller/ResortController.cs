using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Controller
{
    class ResortController : MyController
    {
        public ResortController()
            : base()
        {

        }

        public void AddImpianto(Impianto impianto)
        {
            if (CercaCodice(impianto))
            {
                throw new Exception("Codice Risorsa già presente");
            }

            if (!(Gss.Resort.Impianti.Add(impianto)))
            {
                throw new Exception("Impianto già presente");
            }
        }

        private bool CercaCodice(Risorsa risorsa)
        {
            foreach (Impianto i in Gss.Resort.Impianti.ListaImpianti)
            {
                if (risorsa.Equals(i))
                {
                    return true;
                }
            }
            foreach (Bungalow b in Gss.Resort.Bungalows.ListaBungalow)
            {
                if (risorsa.Equals(b))
                {
                    return true;
                }
            }
            return false;
        }


   
    }
}
