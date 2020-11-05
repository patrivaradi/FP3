using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_3._5
{
    class Program
    {
        static void Main(string[] args)
        {//????????
            //Se dau numerele naturale n și k, unde k este o cifră. 
            //Să se verifice dacă toate cifrele lui n sunt mai mici sau egale decât k.

            Console.Write("Introcduceti un numar natural n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o cifra k=");
            int k = int.Parse(Console.ReadLine());
            int v = n;
            while (v > 0)
            {
                v = v % 10;
                if (v > k)
                {
                    Console.WriteLine("NU");
                    break;
                }

            }
            if (n<=k)
            {
                Console.WriteLine("DA");
            }
            Console.ReadKey();
        }
    }
}
