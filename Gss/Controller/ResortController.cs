using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;
using Gss.Filtra;

namespace Gss.Controller
{
    public class ResortController : MyController
    {
        private IFiltra _filtro;

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

        public bool RemoveImpianto(Impianto impianto)
        {
            return Gss.Resort.Impianti.Remove(impianto);
            
        }

        public Impianti GetImpianti()
        {
            return Gss.Resort.Impianti;
        }

        public Impianto GetImpiantoByCodice(string codice)
        {
            Impianto impianto = Gss.Resort.Impianti.GetImpiantoByCodice(codice);
            if (impianto == null)
            {
                throw new Exception("L'impianto cercato non esiste");
            }
            return impianto;
        }

        public void EditImpianto(Impianto impianto, Impianto impiantoModificato)
        {
            if (impianto.Equals(impiantoModificato)) 
                throw new Exception("Non sono state apportate modifiche all'impianto");
            
            if(Exist(impiantoModificato))
            {
                throw new Exception("L'impianto modificato già esiste nel sistema");
            }

            impianto.Nome = impiantoModificato.Nome;
            impianto.Versante = impiantoModificato.Versante;
           
        }

        public bool Exist(Impianto impianto)
        {
            return Gss.Resort.Impianti.ListaImpianti.Contains(impianto);
        }

        public void AddPistaAdImpianto(string codice, Pista pista)
        {
            Impianto impianto = Gss.Resort.Impianti.GetImpiantoByCodice(codice);
            impianto.Add(pista);
        }

        public void RemovePistaAdImpianto(string codice, Pista pista)
        {
            Impianto impianto = Gss.Resort.Impianti.GetImpiantoByCodice(codice);

            if (!(impianto.Remove(pista)))
            {
                throw new Exception("Pista non  presente nell'impianto");
            }
        }

        public void AddBungalow(Bungalow bungalow)
        {
            if (CercaCodice(bungalow))
            {
                throw new Exception("Codice Risorsa già presente");
            }

            if (!(Gss.Resort.Bungalows.Add(bungalow)))
            {
                throw new Exception("Bungalow già presente");
            }
        }

        public bool RemoveBungalow(Bungalow bungalow)
        {
            return Gss.Resort.RemoveBungalow(bungalow);
        }

        public Bungalow GetBungalowByCodice(string codice)
        {
            Bungalow bungalow = Gss.Resort.Bungalows.GetBungalowByCodice(codice);
            if (bungalow == null)
            {
                throw new Exception("Il bungalow cercato non esiste");
            }
            return bungalow;
        }

        public Bungalows GetBungalows()
        {
            return Gss.Resort.Bungalows;
        }

        public void AddStanzaABungalow(Bungalow bungalow, Stanza stanza)
        {
            if(!(checkStanza(stanza))){
                throw new Exception("Numero posti stanza non validi");
            }
            bungalow.Add(stanza);
        }

        public void EditStanzaABungalow(Stanza stanza, Stanza stanzaModificata)
        {
            if (!(checkStanza(stanzaModificata)))
            {
                throw new Exception("Numero posti stanza non validi");
            }
            stanza.NumeroPostiStandard = stanzaModificata.NumeroPostiStandard;
            stanza.NumeroPostiMax = stanzaModificata.NumeroPostiMax;
        }

        private bool checkStanza(Stanza stanza)
        {
            if ((stanza.NumeroPostiStandard == 0 || stanza.NumeroPostiMax == 0) || (stanza.NumeroPostiMax <= stanza.NumeroPostiStandard))
                return false;
            return true;
        }

        public void RemoveStanzaABungalow(string codice, Stanza stanza)
        {
            Bungalow bungalow = Gss.Resort.Bungalows.GetBungalowByCodice(codice);
            bungalow.Remove(stanza);
        }

        public void SetResortInfo(string nome, string indirizzo, string telefono, string email, DateTime dataInizioStagione, DateTime dataFineStagione)
        {

            if (Gss.Resort.DataInizioStagione < DateTime.Today)
            {
                throw new Exception("Impossibile modificare data, stagione in corso");
            }
            Gss.Resort.DataInizioStagione = dataInizioStagione;

            if (Gss.Resort.DataFineStagione < dataFineStagione)
            {
                Gss.Resort.DataFineStagione = dataFineStagione;
                //GestorePeriodi.AllineaPeriodi()
            }
            
            Gss.Resort.Nome = nome;
            Gss.Resort.Indirizzo = indirizzo;
            Gss.Resort.Telefono = telefono;
            Gss.Resort.Email = email;
        }

        public Impianti Filtra(Impianti impianti)
        {
            return new Impianti();
        }

        public IFiltra Filtro
        {
            get { return _filtro; }
            set { _filtro = value; }
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
