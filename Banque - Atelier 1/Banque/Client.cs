using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class Client
    {
        private string nom;
        private string prenom;
        private string adresse;

        public Client(string n, string p, string ad)
        {
            this.nom = n;
            this.prenom = p;
            this.adresse = ad;
        }
        public override string ToString()
        {
            string s = "nom: " + this.nom + "\n" +
                      "prenom: " + this.prenom + "\n" +
                      "adresse: " + this.adresse + "\n";
            return s;
        }

    }
}
