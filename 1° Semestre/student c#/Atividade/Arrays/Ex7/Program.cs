using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {


            System.Console.WriteLine("Digite a quantidade de posição");
            int np = int.Parse(Console.ReadLine());

            int[] vetora = new int[np];
            Random random = new Random();

            int[] vetorb = new int[np];
        
            int[] vetorc = new int[np];

            for (int i = 0; i < np; i++)
            {
                vetora[i] = random.Next(0, 100);
                vetorb[i] = random.Next(0,100);
                vetorc[i] = vetora[i] + vetorb[i];
            }

            System.Console.Write("Os valores do vetor a são : ");

            foreach (var item in vetora)
            {
                System.Console.Write($"{item} ");
            }

            System.Console.Write("Os valores do vetor b são : ");

            foreach (var item in vetorb)
            {
                System.Console.Write($"{item} ");
            }

            System.Console.Write("Os valores do vetor c são : ");

            foreach (var item in vetorc)
            {
                System.Console.Write($"{item} ");
            }
        }



    }
}

