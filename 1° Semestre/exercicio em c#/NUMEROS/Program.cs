using System;

namespace NUMEROS
{
    class Program
    {
        static void Main(string[] args)
        {
            int _inteiro = 1;

          

           
             while (_inteiro  != 0)
             {
             
            Console.WriteLine("Digite seu número inteiro");
            _inteiro = int.Parse(Console.ReadLine());

            


            if (_inteiro %2 == 0)
            {
                Console.WriteLine("Seu numero é par");
            } else {
               Console.WriteLine("Seu numero é impar"); 
            }

            }
           
        }
    }
}
