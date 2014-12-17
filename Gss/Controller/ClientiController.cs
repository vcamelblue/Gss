using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Controller
{
    public class ClientiController : MyController
    {

        //Constructors

        public ClientiController()
            : base()
        {

        }


        //Public Methods

        public void AddCliente(Cliente cliente)
        {
            if (!(Gss.Clienti.Add(cliente)))
            {
                throw new Exception("Cliente già registrato");
            }
        }
        
        public void RemoveCliente(Cliente cliente)
        {
            if (HavePrenotazioni(cliente))
                throw new Exception("Il cliente non può essere rimosso perchè ha una o più prenotazioni salvate nel sistema");

            if (!this.Gss.Clienti.Remove(cliente))
                throw new Exception("Impossibile Rimuovere Il Cliente Selezionato Dal Sistema!");
        }

        public void EditCliente(Cliente cliente, Cliente clienteModificato)
        {
            if (cliente.Identic(clienteModificato)) 
                throw new Exception("Non sono state apportate modifiche al cliente!");
            
            foreach (Cliente c in Gss.Clienti.ListaClienti)
            {
                //salto il cliente originale e verifico se quello modificato esiste gia nel sistema!
                if (!c.Identic(cliente) && c.Equals(clienteModificato))
                    throw new Exception("Il cliente modificato corrisponde ad un cliente gia presente nel sistema! Modifiche non apportate");
            }

            cliente.Nome = clienteModificato.Nome;
            cliente.Cognome = clienteModificato.Cognome;
            cliente.CodiceFiscale = clienteModificato.CodiceFiscale;
            cliente.DataNascita = clienteModificato.DataNascita;
            cliente.Indirizzo = clienteModificato.Indirizzo;
            cliente.Email = clienteModificato.Email;
            cliente.Telefono = clienteModificato.Telefono;
        }


        public Cliente GetClienteByCF(string codiceFiscale)
        {
            Cliente cliente = Gss.Clienti.GetClienteByCF(codiceFiscale);

            if (cliente == null)
                throw new Exception("Il cliente cercato non è presente nel sistema");

            return cliente;
        }        

        public Clienti GetAllClienti()
        {
            return Gss.Clienti;
        }


        public bool Exist(Cliente cliente)
        {
            return Gss.Clienti.ListaClienti.Contains(cliente);
        }


        //Private Methods

        private bool HavePrenotazioni(Cliente cliente)
        {
            return (this.Gss.Prenotazioni.GetPrenotazioniByCliente(cliente).ListaPrenotazioni.Count != 0);
        }
    }
}
