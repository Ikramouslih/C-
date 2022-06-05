using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    internal class MAD : Devise
    {
        private const double taux_EUR = 0.0945;//100 MAD -> 9.45 EUR 
        private const double taux_DOL = 0.1013;//100 MAD -> 10.13 DOL 
        
        public MAD(double v):base(v,"MAD")
        {
        }
        public override Devise convert_to(string symbole)
        {
            if (symbole == "Banque.DOL")
            {
                return new DOL(this.convert_help(taux_DOL));
            }
            else if(symbole == "Banque.EUR")
            {
                return new EUR(this.convert_help(taux_EUR));
            }
            else
            {
                if (symbole != "Banque.MAD")
                    Console.WriteLine("Devise Invalide");
                return new MAD(this.convert_help(1));
                
            }

        }
        public override string ToString()
        {
           
            return base.ToString();
        }



    }

}
