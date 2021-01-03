using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Digite seu numero inteiro");
           double inteiro = double.Parse(Console.ReadLine());

           if (inteiro %2 == 0)
           {
               System.Console.WriteLine("Seu numero é par");
           }else {
               System.Console.WriteLine("Seu numero é impar");
           }
           
        }
    }
}
