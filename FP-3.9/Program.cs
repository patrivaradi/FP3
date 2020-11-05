using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FP_3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se citeste n si apoi n numere de la tastatura. Sa se determine cate dintre ele erau pare.
            int n, p, c;
            Console.Write("Introduceti n : ");
            n = int.Parse(Console.ReadLine());
            p = 0;
            for(int i=0;i<n;i++)
            {
                Console.Write("Introduceti un numar:");
                c = int.Parse(Console.ReadLine());
                if (c % 2 == 0)
                {
                    p++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Din numerele introduse {0} erau pare.",p);
            Console.ReadKey();
        }
    }
}
