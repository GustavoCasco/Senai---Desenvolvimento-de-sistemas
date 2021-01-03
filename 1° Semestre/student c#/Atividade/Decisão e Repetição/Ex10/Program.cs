using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
                int i;

                System.Console.WriteLine("Digite o numero inteiro: ");
                i = int.Parse(Console.ReadLine());

                if (i %3 ==0)
                {
                    System.Console.WriteLine("É multiplo de 3");
                }else
                {
                    System.Console.WriteLine("Não é multiplo de 3");
                }
        }
    }
}