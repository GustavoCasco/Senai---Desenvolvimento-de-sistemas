using System;
using System.Collections.Generic;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> agenda = new Dictionary<string, DateTime>();
            bool quersair = true;
            do
            {
                
                
                System.Console.WriteLine("******************");
                System.Console.WriteLine("  Aniversarios    ");
                System.Console.WriteLine("******************");

                System.Console.WriteLine("1 - Cadastro: ");
                System.Console.WriteLine("2 - Remover cadastro:  ");
                System.Console.WriteLine("3 - Buscar cadastro ");
                System.Console.WriteLine("4 - Lista");
                System.Console.WriteLine("0 - Sair");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        System.Console.WriteLine("Digite o nome: ");
                        string nome = Console.ReadLine();

                        System.Console.WriteLine("Digite a data de nascimento: ");
                        DateTime data = DateTime.Parse(Console.ReadLine());

                        agenda.Add(nome, data);
                        System.Console.WriteLine("Cadastro concluido");
                        break;

                    case 2:
                        System.Console.WriteLine("Digite o nome: ");
                        nome = Console.ReadLine();

                        System.Console.WriteLine("Digite a data de nascimento: ");
                        data = DateTime.Parse(Console.ReadLine());


                        if (agenda.ContainsKey(nome))
                        {
                            agenda.Remove(nome);

                        }
                        else
                        {
                            System.Console.WriteLine("Nome não encontrado");
                        }
                        break;

                    case 3:
                        

                        System.Console.WriteLine("Digite o nome: ");
                        nome = Console.ReadLine();

                        if (agenda.ContainsKey(nome))

                        {
                            System.Console.Write($"Nome: {nome} {agenda[nome]}");
                        }
                        else
                        {
                            System.Console.WriteLine("Pessoa não encontrada");
                        }

                        break;

                        case 4:
                        
                        foreach (var item in agenda)
                        {
                            System.Console.WriteLine($"{item} ");
                        }
                        break;

                        case 0:
                        quersair = false;
                        break;

                }

            } while (quersair);


        }
    }
}
