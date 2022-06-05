using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class DOL : Devise
    {
        private const double taux_EUR = 0.933;//10 DOL -> 9.33 EUR
        private const double taux_MAD = 9.878;//10 DOL -> 98.78 MAD

        public DOL(double v) : base(v, "DOL")
        {
        }
        public override Devise convert_to(string symbole)
        {
            if (symbole == "Banque.EUR")
            {
                return new EUR(this.convert_help(taux_EUR));
            }
            else if (symbole == "Banque.MAD")
            {
                return new MAD(this.convert_help(taux_MAD));
            }
            else
            {
                if (symbole != "Banque.DOL")
                    Console.WriteLine("Devise Invalide");
                return new DOL(this.convert_help(1));

            }

        }
        public override string ToString()
        {

            return base.ToString();
        }

    }
}
