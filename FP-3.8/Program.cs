﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care citește numărul natural n și determină suma S=1*2-2*3+3*4-...±n*(n+1).
            int n, i;
            Console.Write("Introduceti n : ");
            n = int.Parse(Console.ReadLine());
            int s = 0;
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    s = s - i * (i + 1);
                }
                else
                {
                    s = s + i * (i + 1);
                }
            }
            Console.WriteLine("Suma este " + s);
            Console.ReadKey();
        }
    }
}
