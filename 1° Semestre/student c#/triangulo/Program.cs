using System;

namespace dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura, quantidade;

            Console.WriteLine("Qual a altura do seu Triângulo?");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos Triângulos você deseja?");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int b=0; b <= quantidade; b++ ) {

                for (int k=0; k <= altura; k++) {

                    for (int a=1; a <= altura-k;a++ ){
                        Console.Write("");

                    }
                    for (int i = 1; i <= k; i++) {
                        Console.Write("*");
                    }
                        Console.WriteLine();
                }
            }
        }
    }
}
