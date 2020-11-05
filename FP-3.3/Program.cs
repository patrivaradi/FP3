using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care să determine oglinditul unui număr natural citit de la tastatură.
            int n, o;
            Console.Write("Introduceti un numar natural = ");
            n = int.Parse(Console.ReadLine());
            o = 0;
            while(n!=0)
            {
                o = o * 10 + n % 10;
                n = n / 10;
            }
            Console.WriteLine("Oglinditul numarului este = {0}",o);
            Console.ReadKey();
        }
    }
}
