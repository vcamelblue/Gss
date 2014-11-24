using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Controller
{
    class BungalowComparer : IComparer<Bungalow>
    {
        private int _numeroPersone;

        public BungalowComparer(int numeroPersone):base()
        {
            _numeroPersone = numeroPersone;
        }

        public int Compare(Bungalow x, Bungalow y)
        {
            int sx = x.PostiTotaliStandard() - _numeroPersone;
            int mx = x.PostiTotaliMax() - _numeroPersone;
            int sy = y.PostiTotaliStandard() - _numeroPersone;
            int my = y.PostiTotaliMax() - _numeroPersone;
            if (sx == sy)
                return my - mx;
            if (mx == my)
                return sx - sy;
            if(sx<0 && sy<0)
                return sx - sy;
            return sy - sx;
        }
    }
}
