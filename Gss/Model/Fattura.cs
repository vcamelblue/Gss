using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model 
{

    public class Fattura 
    {

        //Fields

        private int numero;
        private DateTime dataFattura;

        private double totaleBungalow;
        private double totaleSkiCards;
        private double totaleFattura;


        //Constructors

        public Fattura(int numero, DateTime dataFattura, 
            double totaleBungalow, double totaleSkiCards, double totaleFattura) 
        {
            this.numero = numero;
            this.dataFattura = dataFattura;

            this.totaleBungalow = totaleBungalow;
            this.totaleFattura = totaleFattura;
            this.totaleSkiCards = totaleSkiCards;
        }

        public Fattura(int numero, DateTime dataFattura)
            : this(numero, dataFattura, 0.0, 0.0, 0.0) {

        }

        public Fattura() 
            : this(0, new DateTime(), 0.0, 0.0, 0.0)
        {

        }


        //Property

        public int Numero 
        {
            get { return numero; }
            set { numero = value; }
        }

        public DateTime DataFattura 
        {
            get { return dataFattura; }
            set { dataFattura = value; }
        }

        public double TotaleBungalow 
        {
            get { return totaleBungalow; }
            set { totaleBungalow = value; }
        }

        public double TotaleSkiCards 
        {
            get { return totaleSkiCards; }
            set { totaleSkiCards = value; }
        }

        public double TotaleFattura 
        {
            get { return totaleFattura; }
            set { totaleFattura = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Fattura fattura = null;
            if (obj is Fattura)
                fattura = (Fattura)obj;
            else
                return false;
            if (this.Numero.Equals(fattura.Numero))
                return true;
            else
                return false;
        }
    }
}
