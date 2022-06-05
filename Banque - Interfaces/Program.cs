using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{        
    internal class Program
    {
        static void Main(string[] args)
        {
            MAD montant_m = new MAD(20000.00);
            EUR montant_e = new EUR(200.00);
            DOL montant_d = new DOL(200.00);
            
            MAD plafond_m = new MAD(30000.00);
            EUR plafond_e = new EUR(250.00);
            DOL plafond_d = new DOL(250.00);

            MAD sm = new MAD(100.00);
            EUR se = new EUR(100.00);
            DOL sd = new DOL(100.00);

            Client cl = new Client("n1","p1","adr1");
            Compte co_MAD = new Compte(cl, montant_m, plafond_m);
            Compte co_EUR = new Compte(cl, montant_e, plafond_e);
            Compte co_DOL = new Compte(cl, montant_d, plafond_d);

            
            /*Console.WriteLine("Compte MAD : \n");
            Console.WriteLine(co_MAD.ToString());
            co_MAD.debiter(se);
            Console.WriteLine(co_MAD.ToString());
            co_MAD.crediter(sd);
            Console.WriteLine(co_MAD.ToString()); 
           
            
           Console.WriteLine("----------------");


            Console.WriteLine("Compte EUR : \n");
            Console.WriteLine(co_EUR.ToString());
            co_EUR.debiter(sm);
            Console.WriteLine(co_EUR.ToString());
            co_EUR.crediter(sd);
            Console.WriteLine(co_EUR.ToString());


            Console.WriteLine("----------------");


            Console.WriteLine("Compte DOL : \n");
            Console.WriteLine(co_DOL.ToString());
            co_DOL.debiter(sm);
            Console.WriteLine(co_DOL.ToString());
            co_DOL.crediter(se);
            Console.WriteLine(co_DOL.ToString());

            Console.WriteLine("----------------");*/

            Console.WriteLine(co_MAD.ToString());
            Console.WriteLine(co_DOL.ToString());

            co_MAD.verser(co_DOL, se);

            Console.WriteLine(co_MAD.ToString());
            Console.WriteLine(co_DOL.ToString());



            Console.ReadKey();
        }

    }
}
