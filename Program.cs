using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Client cl1 = new Client("tellat", "abdessamad", "Hay salam 772");
            Client cl2 = new Client("user", "root", "Addresse12");
        
            Comptes C = new Comptes(new MAD(5900), cl1, new MAD(42000));
            Comptes C2 = new Comptes(new MAD(5000) , cl2, new MAD(9200));

            C.Consulter();
            C2.Consulter();

            C.Verser(C2, new MAD(3000));
            Console.WriteLine("\n         Apres les virement:\n");
           
            C.Consulter();
            C2.Consulter();

            Console.ReadKey();

        }
    }
}
