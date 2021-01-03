using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o primeiro numero: ");
            double a = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o segundo numero");
            double b = double.Parse(Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine();
            a += b;
            b = a - b;
            a -= b;

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);

        }
    }
}
