using System;
using System.Collections.Generic;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                n[i] = random.Next(0, 100);
            }

            List<int> par = new List<int>();
            List<int> impar = new List<int>();

            foreach (int item in n)
            {

                if (item % 2 != 0)
                {
                    impar.Add(item);
                }
                else
                {
                    par.Add(item);
                }
            }

            foreach (int item in par)
            {
                System.Console.WriteLine($"Esses são os numeros par: {item}");
            }

            foreach (int item in impar)
            {
                System.Console.WriteLine($"Esses são os numeros impar: {item}");
            }
        }

    }
}
