using System;
using System.Collections.Generic;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<AgendaTelefonica> agenda = new List<AgendaTelefonica>();

            System.Console.WriteLine("******************");
            System.Console.WriteLine(" Agenda Telefonica");
            System.Console.WriteLine("******************");

            System.Console.WriteLine();
            System.Console.WriteLine(" 1 - Cadastrar agenda");
            int opc = int.Parse(Console.ReadLine());
            Console.Clear();
            


            switch (opc)
            {
                case 1:
                    Cadastro(ref agenda);
                    break;

            }


        }

        public static void Cadastro(ref List<AgendaTelefonica> agenda)
        {
            System.Console.WriteLine("Entre com o seu nome:");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Digite o numero de telefone:");
            string telefone = Console.ReadLine();

            System.Console.WriteLine("Digite sua data de nascimento");
            string data = Console.ReadLine();

            AgendaTelefonica cadastro = new AgendaTelefonica(nome, telefone, data);
            agenda.Add(cadastro);
            System.Console.WriteLine();

            Console.Clear();

            Console.WriteLine("Nome: " + cadastro.Nome);
            Console.WriteLine("Telefone: " + cadastro.Telefone);
            Console.WriteLine("Data de nascimento: " + cadastro.DataNascimento);
            System.Console.WriteLine();
            System.Console.WriteLine("Cadastrado com sucesso !");



        }


    }
}
