using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a base para fazer o triangulo");
            double Base = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado para fazer o triangulo");
            double lado1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o outro lado para fazer o triangulo");
            double lado2 = double.Parse(Console.ReadLine());

            if (lado2 + lado1 < Base)
            {
                System.Console.WriteLine("Esses numeros não podem fazer parte do triangulo");
            }
            else
            {
                System.Console.WriteLine("Esses numeros servem para fazer o triangulo");
            }

        }
    }
}
