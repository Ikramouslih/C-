using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    abstract internal class Devise :IDevise
    {
        private double valeur;
        private string symbole;

        abstract public Devise convert_to(string symbole);
        
        public Devise(double valeur, string  symbole)
        {
            this.valeur = valeur;
            this.symbole = symbole;
        }
        public Devise()
        {}

        public double convert_help(double taux)
        {
            return this.valeur * taux;
        }

        public override string ToString()
        {
            string s = this.valeur + " " + this.symbole;
            return s;
        }
        public static bool operator >=(Devise m, double v)
        {
            return m.valeur >= v;
        }
        public static bool operator <=(Devise m, double v)
        {

            return m.valeur <= v;
        }

        public static Devise operator +(Devise m, Devise v)
        {
            m.valeur += v.valeur;
            return m;
        }

        public static Devise operator -(Devise m, Devise v)
        {
            m.valeur -= v.valeur;
            return m;
        }
        public static bool operator >=(Devise m, Devise v)
        {

            return m.valeur >= v.valeur;
        }
        public static bool operator <=(Devise m, Devise v)
        {
            return m.valeur <= v.valeur;
        }
    }
}
