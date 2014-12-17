using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class RisorsaComparer : EqualityComparer<Risorsa>
    {
        public override bool Equals(Risorsa x, Risorsa y)
        {
            return EqualityComparer<Risorsa>.Default.Equals(x, y);
        }

        public override int GetHashCode(Risorsa obj)
        {
            return obj.Codice.GetHashCode();
        }
    }
}
