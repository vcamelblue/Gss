﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gss.Model
{
    public class Bungalow : Risorsa
    {
        private List<Stanza> _stanze;

        public Bungalow(string codice) 
            : base(codice)
        {
            _stanze = new List<Stanza>();
        }

        public List<Stanza> Stanze
        {
            get { return _stanze; }
            set { _stanze = value; }
        }

        public int PostiTotaliStandard()
        {
            int postiTotaliStandard = 0;
            foreach (Stanza s in Stanze)
            {
                postiTotaliStandard += s.NumeroPostiStandard;
            }
            return postiTotaliStandard;
        }

        public int PostiTotaliMax()
        {
            int postiTotaliMax = 0;
            foreach (Stanza s in Stanze)
            {
                postiTotaliMax += s.NumeroPostiMax;
            }
            return postiTotaliMax;
        }

        public int GetNumeroStanze()
        {
            return Stanze.Count;
        }

        public void Add(Stanza stanza)
        {
            Stanze.Add(stanza);
        }

        public bool Remove(Stanza stanza)
        {
            //if (Stanze.Count == 1) return false;
            //else 
            return Stanze.Remove(stanza);
        }

       public override bool Equals(object obj)
        {
            Bungalow bungalow = null;
            if (obj is Bungalow)
            {
                bungalow = (Bungalow)obj;
            }
            else
                return false;
            if (!base.Equals(obj))
                return false;
            if (bungalow.Stanze.Count != this.Stanze.Count)
                return false;

            List<Stanza> temp = bungalow.Stanze.ToList<Stanza>();
            bool trovato = false;

            foreach (Stanza s in this.Stanze)
            {
                foreach (Stanza sObj in bungalow.Stanze)
                {
                    if (s.Equals(sObj))
                    {
                        temp.Remove(sObj);
                        trovato = true;
                        break;
                    }
                }
                if (!trovato)
                    return false;
                else
                    trovato = false;
            }
            return true;   
        }

        /*public override bool Equals(object obj)
        {
            Bungalow bungalow = null;
            if (obj is Bungalow)
            {
                bungalow = (Bungalow)obj;
            }
            else
                return false;
            if (this.Codice == bungalow.Codice)
                return true;
            return false;
        }*/

        public override string ToString()
        {
            string result = Codice + " - Posti Standard: " + PostiTotaliStandard() + ", Posti Totali: " + PostiTotaliMax()+"  -  ";
           
            return result += ToStringStanze();
        }

        public string ToStringStanze()
        {
            string result = "  ";

            foreach (Stanza s in Stanze)
            {   
                if (result.Contains(s.ToString()))
                {
                    if (ContaOccorrenzeStanza(s) > 1)
                    {
                        string nuovaStringa = s.ToString().Remove(s.ToString().Length-1);
                        nuovaStringa += "e";
                        result = result.Replace(s.ToString(), ContaOccorrenzeStanza(s) + " " + nuovaStringa) + "  ";
                    }
                    else
                    {
                        result = result.Replace(s.ToString(), ContaOccorrenzeStanza(s) + " " + s.ToString()) + "  ";
                    }
                }
                else
                {
                    result += s.ToString() + " + ";
                }
            }

            return result;

           /* foreach (Stanza s in Stanze)
            {
                if (s.Equals(Stanze[Stanze.Count - 1]))
                {
                    result += s.ToString() + " ";
                }
                else
                {
                    result += s.ToString() + " + ";
                }
            }
            return result;*/
        }

        private int ContaOccorrenzeStanza(Stanza stanza)
        {
            int result = 0;
            foreach (Stanza s in Stanze)
            {
                if (s.NumeroPostiStandard == stanza.NumeroPostiStandard)
                {
                    result++;
                }
            }
            return result;
        }

        public override object Clone()
        {
            Bungalow clone;
            clone = new Bungalow(this.Codice);
            foreach (Stanza s in Stanze)
            {
                clone.Add((Stanza)s.Clone());
            }
            return clone;
        }
    }
}
