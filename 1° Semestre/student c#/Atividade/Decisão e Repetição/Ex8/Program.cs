using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            System.Console.WriteLine("Digite a altura do triangulo");
            altura = int.Parse(Console.ReadLine());



            for (int i = altura; i >= 1; i--)
            {
                for (int k = 1; k <= i ; k++)
                {
                    System.Console.Write("*");
                   
                    
                }
                System.Console.WriteLine("");
                
            }
                System.Console.ReadKey();
            
      }
    }
}
