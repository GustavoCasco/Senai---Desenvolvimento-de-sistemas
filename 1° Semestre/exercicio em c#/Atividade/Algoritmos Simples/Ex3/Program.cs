using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite a velocidade");
            double velo = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o tempo");
            double tempo = double.Parse(Console.ReadLine());
            System.Console.WriteLine();

            double distancia = tempo * velo;

            System.Console.Write($"A distancia a ser percorrida é de: {distancia}");
            

            System.Console.WriteLine();
            
            System.Console.WriteLine();

            double litros = distancia / 12;
            System.Console.Write($"A quantidade de litros gasta é de: {litros}");



        }
    }
}
