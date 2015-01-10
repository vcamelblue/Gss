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
        //FIELDS

        private IFiltra _filtro;

        //CONSTRUCTORS

        public ResortController() : base()
        {

        }

        //PROPERTY

        public IFiltra Filtro
        {
            get { return _filtro; }
            set { _filtro = value; }
        }

        public Bungalows GetBungalows()
        {
            return Gss.Resort.Bungalows;
        }

        public Impianti GetImpianti()
        {
            return Gss.Resort.Impianti;
        }

        public Resort GetResort()
        {
            return Gss.Resort;
        }
        
        public void SetResort(Resort resort)
        {
            Gss.Resort = resort;
        }


        //RESORT METHODS

        public string SetResortInfo(string nome, string indirizzo, string telefono, string email, DateTime dataInizioStagione, DateTime dataFineStagione)
        {
            String result = "";

            if (nome == null || indirizzo == null || telefono == null || email == null)
            {
                throw new Exception("Impossibile impostare i dati del Resort, uno o più valori non sono validi");
            }
            
            Gss.Resort.Nome = nome;
            Gss.Resort.Indirizzo = indirizzo;
            Gss.Resort.Telefono = telefono;
            Gss.Resort.Email = email;
            
            //se la stagione è gia iniziata blocco l'inserimento di nuove date

            if (Gss.Resort.isStagioneIniziata() && (dataInizioStagione.Date!= Gss.Resort.DataInizioStagione.Date || dataFineStagione.Date != Gss.Resort.DataFineStagione.Date))
            {
                throw new Exception("Impossibile modificare le date della stagione, la stagione è già in corso");
            }

            //Rielliniare i periodi se la stagione non e' iniziata

            if (Gss.Resort.DataInizioStagione.Date != dataInizioStagione.Date || Gss.Resort.DataFineStagione.Date != dataFineStagione.Date)
            {
                Gss.Resort.DataInizioStagione = dataInizioStagione;
                Gss.Resort.DataFineStagione = dataFineStagione;

                result = Gss.GestorePeriodi.TrySetPeriodi(Gss.GestorePeriodi.Periodi);

                Gss.GestorePeriodi.SetPeriodi(Gss.GestorePeriodi.Periodi);
            }

            return result;
        }

        //RISORSE METHODS   
        public Risorsa GetRisorsaByCodice(string codice)
        {
            Risorsa risorsa = Gss.Resort.Impianti.GetImpiantoByCodice(codice);

            if (risorsa == null)
            {
                risorsa = Gss.Resort.Bungalows.GetBungalowByCodice(codice);
                if (risorsa == null)
                    throw new Exception("La risorsa cercata non esiste");
            }

            return risorsa;
        }

        //IMPIANTI METHODS

        public void AddImpianto(Impianto impianto)
        {
            if (codiceRisorsaGiaEsistente(impianto))
            {
                throw new Exception("Codice Risorsa già presente");
            }

            if (!(Gss.Resort.Impianti.Add(impianto)))
            {
                throw new Exception("Impianto già presente");
            }
        }

        public void RemoveImpianto(Impianto impianto)
        {
            if (!Gss.Resort.Impianti.Remove(impianto))
                throw new Exception("Impossibile Rimuovere L'Impianto Dal Sistema!");

        }

        public void EditImpianto(Impianto impianto, Impianto impiantoModificato)
        {
            if (impianto.Equals(impiantoModificato))
                throw new Exception("Non sono state apportate modifiche all'impianto!");

            impianto.Nome = impiantoModificato.Nome;
            impianto.Versante = impiantoModificato.Versante;
            impianto.Piste = impiantoModificato.Piste;

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


        //BUNGALOWS METHODS

        public void AddBungalow(Bungalow bungalow)
        {
            if (codiceRisorsaGiaEsistente(bungalow))
            {
                throw new Exception("Codice Risorsa già presente");
            }

            if (!(Gss.Resort.Bungalows.Add(bungalow)))
            {
                throw new Exception("Bungalow già presente");
            }
        }

        public void RemoveBungalow(Bungalow bungalow)
        {
            if (!(Gss.Resort.Bungalows.Remove(bungalow)))
            {
                throw new Exception("Impossibile rimuvoere il Bungalow dal sistema, rimozione non effettuata!");
            }
        }

        public void EditBungalow(Bungalow bungalow, Bungalow bungalowModificato)
        {
            foreach (Stanza s in bungalowModificato.Stanze)
            {
                if (!isStanzaValid(s))
                    throw new Exception("Impossibile modificare le stanze del bungalow! una o più stanze non sono valide!");
            }

            bungalow.Stanze = bungalowModificato.Stanze;
        }


        public void EditBungalow(Bungalow bungalow, List<Stanza> nuoveStanze)
        {
            foreach (Stanza s in nuoveStanze)
            {
                if (!isStanzaValid(s))
                    throw new Exception("Impossibile modificare le stanze del bungalow! una o più stanze non sono valide!");
            }
            bungalow.Stanze = nuoveStanze;
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


        //FILTRAGGIO

        public Impianti Filtra(Impianti impianti)
        {
            return Filtro.Filtra(impianti);
        }


        //PRIVATE METHODS

        private bool codiceRisorsaGiaEsistente(Risorsa risorsa)
        {
            if (risorsa is Impianto)
            {
                foreach (Impianto i in Gss.Resort.Impianti.ListaImpianti)
                {
                    if (risorsa.Codice == i.Codice)
                    {
                        return true;
                    }
                }
            }
            else
            {
                foreach (Bungalow b in Gss.Resort.Bungalows.ListaBungalow)
                {
                    if (risorsa.Codice == b.Codice)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private bool isStanzaValid(Stanza stanza)
        {
            if (stanza == null)
                return false;

            return (stanza.NumeroPostiStandard != 0 && stanza.NumeroPostiMax != 0 && stanza.NumeroPostiMax >= stanza.NumeroPostiStandard);
        }


    }
}
