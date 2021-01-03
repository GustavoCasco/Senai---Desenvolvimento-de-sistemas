using System;
using System.Collections.Generic;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nome = new List<string>();
            bool quersair = true;
            do
            {
                System.Console.WriteLine("*********************");
                System.Console.WriteLine("      Lista          ");
                System.Console.WriteLine("*********************");

                System.Console.WriteLine("Digite o 1 para adicionar nomes");
                System.Console.WriteLine("Digite 2 para parar");
                int nome1 = int.Parse(Console.ReadLine());


                switch (nome1)
                {

                    case 1:
                        Console.Clear();

                        System.Console.WriteLine("Digite o nome: ");
                        string nome2 = Console.ReadLine();
                        nome.Add(nome2);
                        break;

                    case 2:
                        System.Console.WriteLine("Quer sair");
                        quersair = false;
                        Console.Clear();
                        
                        break;
                }

            } while (quersair);


            System.Console.WriteLine($"Foram adicionados {nome.Count} nomes");






        }
    }
}
