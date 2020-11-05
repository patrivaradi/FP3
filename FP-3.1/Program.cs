using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care să determine suma cifrelor unui număr natural citit de la tastatură.
            int n,s;
            Console.Write("Introduceti un numar natural : ");
            n=int.Parse(Console.ReadLine());
            s = 0;
            while (n != 0)
            {
                s = s + n % 10;
                n = n / 10;
            }
            Console.WriteLine("Suma cifrelor numarului dat este : "+s);
            Console.ReadKey();
        }
    }
}
