using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care citește numărul natural n și determină valoarea lui n!=1*2*3*...*n.
            int n,i;
            Console.Write("Introduceti n : ");
            n = int.Parse(Console.ReadLine());
            int f = 1;
            for (i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("{0}! = {1}", n, f);
            Console.ReadKey();
        }
    }
}
