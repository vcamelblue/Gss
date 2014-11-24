using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class Direttore
    {
        private String _password;
        private bool _isAutenticato;

        public Direttore(String password)
        {
            _password = password;
            _isAutenticato = false;
        }

        public bool Autenticazione(String password)
        {
            if (password == _password)
            {
                _isAutenticato = true;
                return true;
            }
            return false;
        }

        public void Logout()
        {
            _isAutenticato = false;
        }

        public bool IsAutenticato()
        {
            return _isAutenticato;
        }    
    }
}
