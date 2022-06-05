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
        private readonly Client titulaire;
        private Devise solde;
        private Devise plafond;
        private List<Operation> Historique;
        public Compte(Client c, Devise s, Devise p)
        {
            this.num_c = ++cpt;
            this.titulaire = c;
            this.solde = s;
            this.plafond = p;
            this.Historique = new List<Operation>();
        }

        public Compte()
        {
           
        }

        public string type_solde()
        {
            return this.solde.GetType().ToString();//returns string ex: Banque.MAD
        }
        public bool crediter(Devise m)
        {            
            if (m >= 0)
            {                
                m = m.convert_to(type_solde());//polymorphisme
                this.solde = this.solde + m;
                Operation op = new Operation("+", m);
                this.Historique.Add(op);
                return true;
            }
            return false;
        }
        public bool debiter(Devise m)
        {
            m = m.convert_to(type_solde());//polymorphisme
            if (this.solde >= m && m <= this.plafond)
            {
                this.solde = this.solde - m;
                Operation op = new Operation("-", m);
                this.Historique.Add(op);
                return true;
            }
            return false;
        }
        public bool verser(Compte c , Devise m)
        {
            if (this.debiter(m) == true)
            {
                c.crediter(m);
                return true;
            }
            return false;

        }
        public override string ToString()
        {
            string s = "Numero de Compte: " + this.num_c + "\n" +
                      "Client: " + this.titulaire.ToString()+
                      "Solde: " + this.solde.ToString() + "\n";
            return s;
        }

        public void afficher_historique()
        {
            Console.WriteLine(this.ToString());
            foreach(Operation o in this.Historique)
            {
                Console.WriteLine(o.ToString());
            }
        }

    }
}
