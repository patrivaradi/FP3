using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care citește numărul natural n și determină suma 2+4+...+2n.
            int n, s;
            Console.Write("Introduceti un numar natural n = ");
            n = int.Parse(Console.ReadLine());
            s = (n + 1) * n;
            Console.WriteLine("Suma este "+s);
            Console.ReadKey();
        }
    }
}
