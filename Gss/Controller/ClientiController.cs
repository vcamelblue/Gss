﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Controller
{
    public class ClientiController : MyController
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
            if (cliente.Identic(clienteModificato)) 
                throw new Exception("Non sono state apportate modifiche al cliente");

            if (Exist(clienteModificato) && !clienteModificato.Equals(cliente))
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

        public Cliente GetClienteByCF(string codiceFiscale)
        {
            Cliente cliente = Gss.Clienti.GetClienteByCF(codiceFiscale);
            if (cliente == null)
                throw new Exception("Il cliente ricercato non è presente nel sistema");
            return cliente;
        }

        public void RemoveCliente(Cliente cliente)
        {
            if (HavePrenotazioni(cliente))
                throw new Exception("Il cliente non può essere rimosso perchè ha prenotazioni salvate nel sistema");
            if (!this.Gss.Clienti.Remove(cliente))
                throw new Exception("Il cliente non può essere rimorso perchè non presente nel sistema");
        }

        private bool HavePrenotazioni(Cliente cliente)
        {
            if (this.Gss.Prenotazioni.GetPrenotazioniByCliente(cliente).ListaPrenotazioni.Count != 0)
                return true;
            return false;
        }
    }
}
