using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class MAD
    {
        private double valeur;
        public MAD(double v)
        {
            this.valeur = v;
        }
        public override string   ToString()
        {
            string s =this.valeur + "MAD \n";
            return s;
        }
        public static bool operator>=(MAD m ,double v)
        {

            return m.valeur >= v;
        }
        public static bool operator<=(MAD m ,double v)
        {

            return m.valeur <= v;
        }

        public static MAD operator+(MAD m, MAD v)
        {
            MAD res = new MAD(m.valeur + v.valeur);
            return res;
        }
        public static MAD operator-(MAD m, MAD v)
        {
            MAD res = new MAD(m.valeur - v.valeur);
            return res;
        }

        public static bool operator >=(MAD m, MAD v)
        {

            return m.valeur >= v.valeur;
        }
        public static bool operator <=(MAD m, MAD v)
        {

            return m.valeur <= v.valeur;
        }

    }

}
