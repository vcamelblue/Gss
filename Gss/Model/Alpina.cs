using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gss.Model;

namespace Gss.Model
{
    class Alpina : Pista
    {
        enum Difficolta {Bassa, Media, Alta};

        private Difficolta _difficolta;

        public Alpina(string nome, Difficolta difficolta) : base(nome) 
        {
            _difficolta = difficolta;
        }

        private Difficolta Difficolta
        {
            get { return _difficolta; }
            set { _difficolta = value; }
        }


    }
}
