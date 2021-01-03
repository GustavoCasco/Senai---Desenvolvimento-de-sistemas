using System;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero limite");
            double n1 = double.Parse(Console.ReadLine());

        for (int i = 0; i < n1; i++)
        {
            if (i %2 != 0)
            {
                System.Console.WriteLine($"Os numeros impares são: {i}");
            }
        }
            
        }
    }
}
