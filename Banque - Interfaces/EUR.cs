using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class EUR : Devise
    {
        private const double taux_DOL = 1.072;//10 EUR ->  10.72 DOL
        private const double taux_MAD = 10.589;//10 EUR -> 105.89 MAD

        public EUR(double v) : base(v, "EUR")
        {
        }
        public override Devise convert_to(string symbole)
        {
            if (symbole == "Banque.DOL")
            {
                return new DOL(this.convert_help(taux_DOL));
            }
            else if (symbole == "Banque.MAD")
            {
                return new MAD(this.convert_help(taux_MAD));
            }
            else
            {
                if (symbole != "Banque.EUR")
                    Console.WriteLine("Devise Invalide");
                return new EUR(this.convert_help(1));

            }

        }
        public override string ToString()
        {

            return base.ToString();
        }
    }
}
