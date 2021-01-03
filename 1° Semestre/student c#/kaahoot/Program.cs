using System;

namespace kaahoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] n = { { 10, 15, 48},
                         {56 , 97, 77},
                        {2,100, 33}
    };
            int soma = 0;
            foreach (var item in n)
            {
                soma += item;
            }

            System.Console.WriteLine(soma);
        }
    }
}
