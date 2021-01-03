using System;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o primeiro numero");
            string n1 = Console.ReadLine();

            System.Console.WriteLine("Digite o segundo numero");
            string n2 = Console.ReadLine();

            System.Console.WriteLine("Digite o terceiro numero");
            string n3 = Console.ReadLine();


            System.Console.WriteLine(string.CompareOrdinal(n1, n2));
            System.Console.WriteLine(string.CompareOrdinal(n1, n3));



        }
    }
}
