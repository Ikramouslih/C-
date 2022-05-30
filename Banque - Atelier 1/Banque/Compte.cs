using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Banque
{
    internal class Compte
    {
        private readonly int num_c;
        private static int cpt=0;
        private readonly Client C;
        private MAD solde;
        private MAD plafond;
        public Compte(Client c, MAD s, MAD p)
        {
            this.num_c = ++cpt;
            this.C = c;
            this.solde = s;
            this.plafond = p;
        }
       
        public bool crediter(MAD m)
        {
            //assert equivalant ?
            if (m >= 0)
            {
                this.solde = this.solde + m;
                return true;
            }
            return false;
        }
        public bool debiter(MAD m)
        {
            //assert equivalant ?
            if (this.solde >= m && m <= this.plafond)
            {
                this.solde = this.solde - m;
                return true;
            }
            return false;
        }
        public bool verser(Compte c , MAD m)
        {
            if (this.debiter(m) == true)
            {
                this.debiter(m);
                c.crediter(m);
                return true;
            }
            return false;

        }
        public override string ToString()
        {
            string s = "Numero de Compte: " + this.num_c + "\n" +
                      "Client: " + this.C.ToString() + "\n" +
                      "Solde: " + this.solde.ToString() + "\n";
            return s;
        }
    }
}
