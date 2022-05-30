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
            Client cl = new Client("n1","p1","adr1");
            MAD montant = new MAD(1000);
            MAD plafond = new MAD(5000);
            Compte co = new Compte(cl, montant, plafond);

            MAD deb_cred = new MAD(2000);


            Console.WriteLine(co.ToString()); 
            Console.WriteLine();

            co.crediter(deb_cred);
            Console.WriteLine(co.ToString());

            co.debiter(deb_cred);
            Console.WriteLine(co.ToString());

            Console.ReadKey();
        }

    }
}
