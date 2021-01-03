using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] VetorA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            int[] VetorB = { 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            int[] VetorC = new int[10];

            for (int i = 0; i < 10; i++)
            {
                VetorC[i] = VetorA[i] + VetorB[i];
            }

            System.Console.Write("Os valores de A são: ");
            System.Console.WriteLine();

            foreach (var item in VetorA)
            {
                System.Console.Write($"{item} ");
            }
            System.Console.WriteLine();
             System.Console.Write("Os valores de B são: ");
             System.Console.WriteLine();

            foreach (var item in VetorB)
            {
                System.Console.Write($"{item} ");
            }

            System.Console.WriteLine();
            System.Console.Write("Os valores de C são: ");
            System.Console.WriteLine();

            foreach (var item in VetorC)
            {
                System.Console.Write($"{item} ");
            }

        }
    }
}
