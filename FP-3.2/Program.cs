using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care să determine numărul de cifre ale unui număr natural citit de la tastatură.
            long n;
            Console.Write("Introduceti un numar natural : ");
            n = long.Parse(Console.ReadLine());
            int s = 0;
            while (n != 0)
            {
                s = s+1;    
                n = n / 10;
            }
            Console.WriteLine("" + s);
            Console.ReadKey();
        }
    }
}
