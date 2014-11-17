using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class Clienti
    {

        private List<Cliente> _clienti;

        public Clienti(List<Cliente> clienti)
        {
            _clienti = new List<Cliente>();
            _clienti = clienti;
        }

        public List<Cliente> ListaClienti
        {
            get { return _clienti; }
            set { _clienti = value; }
        }
       

        public void Add(Cliente cliente)
        {
            ListaClienti.Add(cliente);
        }

        public bool Remove(Cliente cliente)
        {
            return ListaClienti.Remove(cliente);
        }


        

    }
}
