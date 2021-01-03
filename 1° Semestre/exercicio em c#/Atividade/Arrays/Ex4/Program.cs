using System;
using System.Collections.Generic;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numInt = new int[3, 3];
            Random numRandom = new Random();
            List<int> listArray = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    numInt[i, j] = numRandom.Next(0, 10);
                }
            }
            foreach (int item in numInt)
            {
                listArray.Add(item);
            }
            System.Console.Write("Itens: ");
            foreach (int item in listArray)
            {
                System.Console.Write($"{item} ");
            }
            int total = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    total += numInt[i, j];
                }
            }
            System.Console.WriteLine($"\nSoma total: {total}");


        }
    }
}
