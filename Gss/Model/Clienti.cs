using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class Clienti
    {
        private List<Cliente> _clienti;

        public Clienti(List<Cliente> clienti)
        {
            _clienti = new List<Cliente>();
            _clienti = clienti;
        }

        public Clienti()
        {
            _clienti = new List<Cliente>();
        }

        public List<Cliente> ListaClienti
        {
            get { return _clienti; }
            set { _clienti = value; }
        }

       

        public bool Add(Cliente cliente)
        {
            if (ListaClienti.Contains(cliente))
                return false;
            else
            {
                ListaClienti.Add(cliente);
                return true;
            }
        }

        public bool Remove(Cliente cliente)
        {
            return ListaClienti.Remove(cliente);
        }

        public override string ToString()
        {
            string result="";
            foreach(Cliente c in this.ListaClienti)
            {
                result += c.ToString() + " ";
            }
            return result;
        }
        

    }
}
