using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string nome2;

            System.Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            System.Console.WriteLine("Digite outro nome:");
            nome2 = Console.ReadLine();

            int comparacao = string.Compare(nome, nome2);

            if (comparacao < 0)
            {
                System.Console.WriteLine($"1°{nome} e 2°{nome2}");
            }
            else
            {
                System.Console.WriteLine($"{nome2} e {nome}");
            }

        }
    }
}
