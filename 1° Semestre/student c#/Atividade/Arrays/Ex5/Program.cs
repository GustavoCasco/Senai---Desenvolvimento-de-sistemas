using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int menor = 0;
            int maior = 0;
            int posicao_maior = 0;
            int posicao_menor = 0;

            int[] n = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                n[i] = random.Next(0, 100);

                if (i == 0)
                {
                    maior = n[i];
                    menor = n[i];
                }

                if (n[i] < menor)
                {
                    menor = n[i];
                    posicao_menor = i;
                }

                if (n[i] >  maior)
                {
                    maior = n[i];
                    posicao_maior = i;
                }
            }
        System.Console.WriteLine("O menor numero é: " + menor);
        System.Console.WriteLine("A posição do menor numero é: " + posicao_menor);
        System.Console.WriteLine("O maior numero é: " + maior);
        System.Console.WriteLine("a posição do maior é: " + posicao_maior);
        }


    }
}

