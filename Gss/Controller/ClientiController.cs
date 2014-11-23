using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Controller
{
    class ClientiController : Controller
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

        public bool EditCliente(Cliente cliente, Cliente clienteModificato)
        {

        }
    }
}
