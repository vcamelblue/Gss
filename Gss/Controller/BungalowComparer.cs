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
                return mx - my;
            if(sx == 0 && sy != 0)
                return -1;
            if (sx != 0 && sy == 0)
                return 1;
            return Max(sx, sy);

            

        }

        private int Max(int x, int y)
        {
            if (x < 0 && y > 0)
                return -1;
            if (x > 0 && y < 0)
                return 1;
            int ax = Math.Abs(x);
            int ay = Math.Abs(y);
            if (ax < ay)
                return -1;
            if (ax > ay)
                return 1;
            return 0;
        }
    }
}
