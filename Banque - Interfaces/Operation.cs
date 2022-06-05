using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class Operation
    {
        private readonly int numero;
        private static int cpt = 0;
        private string libelle;
        private Devise montant;
        private DateTime date;
        public Operation(string libelle, Devise m)
        {
            this.date = DateTime.Now;
            this.numero = ++cpt;
            this.libelle = libelle;
            this.montant = m;

        }
        public override string ToString()
        {
            string s = this.date + " | n° " + this.numero + " | " + this.libelle + this.montant.ToString();
            return s;
        }
    }
}
