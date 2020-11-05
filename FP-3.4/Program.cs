using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care să determine ultima cifră pară 
            //a unui număr natural citit de la tastatură.
            int n,c;
            Console.WriteLine("introduceti un numar natural : ");            
            n=int.Parse(Console.ReadLine());
            c = 0;
            while (n > 0)
            {
                c = n % 10;
                n = n / 10;
                if (c % 2 == 0)
                {                   
                    Console.WriteLine("Ultima cifra para este : "+c);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
