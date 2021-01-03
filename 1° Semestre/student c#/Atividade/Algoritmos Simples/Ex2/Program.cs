using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            double F;

            System.Console.WriteLine("Digite o grau");
            double grau = double.Parse(Console.ReadLine());

            F = (grau  * 9) / 5 + 32;
            System.Console.WriteLine(F);





        }
    }
}
