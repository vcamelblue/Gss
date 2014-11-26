using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    class PeriodoComparer:IComparer<Periodo>
    {
        public int Compare(Periodo x, Periodo y)
        {
            return x.DataInizio.CompareTo(y.DataInizio);
        }
    }
}
