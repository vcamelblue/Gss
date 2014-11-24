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

            if (Exist(clienteModificato))
            {
                throw new Exception("Il cliente modificato già esiste nel sistema");
            }

                cliente.Nome = clienteModificato.Nome;
                cliente.Cognome = clienteModificato.Cognome;
                cliente.CodiceFiscale = clienteModificato.CodiceFiscale;
                cliente.DataNascita = clienteModificato.DataNascita;
                cliente.Indirizzo = clienteModificato.Indirizzo;
                cliente.Email = clienteModificato.Email;
                cliente.Telefono = clienteModificato.Telefono;
        }

        public bool Exist(Cliente cliente)
        {
            return Gss.Clienti.ListaClienti.Contains(cliente);
        }

        public Clienti GetAllClienti()
        {
            return Gss.Clienti;
        }
    }
}
