using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Controller
{
    class ClientiController : MyController
    {
        public ClientiController()
            : base()
        {

        }

        public void AddCliente(Cliente cliente)
        {
            if (!(Gss.Clienti.Add(cliente)))
            {
                throw new Exception("Cliente già registrato");
            }
        }

        public void EditCliente(Cliente cliente, Cliente clienteModificato)
        {
            if (cliente.Equals(clienteModificato)) 
                throw new Exception("Non sono state apportate modifiche al cliente");

            //Verifico che il cliente edited non esesta gia -> funzione publica apposita
            // copio i parametri nel cliente originale, siccome ho gia il riferimento!

            foreach (Cliente c in Gss.Clienti.ListaClienti)
            {
                if (cliente.Equals(c))
                {
                    c.Nome = clienteModificato.Nome;
                    c.Cognome = clienteModificato.Cognome;
                    c.CodiceFiscale = clienteModificato.CodiceFiscale;
                    c.DataNascita = clienteModificato.DataNascita;
                    c.Indirizzo = clienteModificato.Indirizzo;
                    c.Email = clienteModificato.Email;
                    c.Telefono = clienteModificato.Telefono;
                    break;
                }
            }
        }

        public Clienti GetAllClienti()
        {
            return Gss.Clienti;
        }
    }
}
