using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FaktoriálisBiginteger
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Számok faktoriálisa 20-30 között");
            for (int szám = 20; szám <= 10000; szám++)
            {
                BigInteger faktor = 1;
                for (int i = 2; i <= szám; i++)
                {
                    faktor = faktor * i;
                }
                Console.WriteLine($"{szám}!={faktor}");
            }

            Console.ReadKey();
        }
    }
}
