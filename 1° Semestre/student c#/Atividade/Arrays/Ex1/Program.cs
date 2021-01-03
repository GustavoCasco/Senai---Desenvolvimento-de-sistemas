using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite a quantidade de posição");
            int np = int.Parse(Console.ReadLine());

            int [] posicao  = new int [np];

            System.Console.WriteLine($"Digite {np} numeros que deseja: "); 
            
            for (int i = 0; i < np; i++)
            {
                int n = int.Parse(Console.ReadLine());
                posicao[i] = n;
            }

            Console.Clear();
            

            foreach (var item in posicao)
            {
                System.Console.Write("Os numeros que voce digitou foi: ");
                System.Console.WriteLine($"{item}");
            }
            

        }
    }
}
