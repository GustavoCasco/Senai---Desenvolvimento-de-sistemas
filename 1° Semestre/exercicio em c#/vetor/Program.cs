using System;

namespace vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6];
            int i;
            int par = 0, impar = 0;


            for (i = 0; i <= 5; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º Numero: ");
                vetor[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }


            foreach (int num in vetor)
            {

                if (num % 2 == 0)
                {
                    ++par;
                }
                else
                {
                    ++impar;
              
                }
            }

            Console.WriteLine(par + " Numero par ");
            Console.WriteLine(impar + " Numero impar ");
        }
    }
}