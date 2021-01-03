using System;
using System.Collections.Generic;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite a palavra: ");
            string verbo = Console.ReadLine();
            verbo = verbo.ToLower();

            bool Conj = verbo.EndsWith("ar");
            bool Conj2 = verbo.EndsWith("er");
            bool Conj3 = verbo.EndsWith("ir");

            if (Conj)
            {
                System.Console.WriteLine("1° conjunção");
            }else if (Conj2)
            {
                System.Console.WriteLine("2° conjunção");
            }else if (Conj3)
            {
                System.Console.WriteLine("3° conjunção");
            }
            
        }
    }
}
