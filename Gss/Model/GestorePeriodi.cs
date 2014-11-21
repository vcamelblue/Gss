using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class GestorePeriodi
    {
        private static GestorePeriodi _gestorePeriodi;

        private GestorePeriodi() { }

        public GestorePeriodi GetInstance()
        {
            if(_gestorePeriodi==null)
            {
                _gestorePeriodi = new GestorePeriodi();
            }
            return _gestorePeriodi;
        }

        
    }

    
}
