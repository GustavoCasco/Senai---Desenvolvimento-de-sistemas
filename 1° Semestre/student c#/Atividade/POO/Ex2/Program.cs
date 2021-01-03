using System;
using System.Collections.Generic;


namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AgendaTelefonica> agenda = new List<AgendaTelefonica>();
            bool quersair = false;

            do
            {
                Console.Clear();

                System.Console.WriteLine("******************");
                System.Console.WriteLine(" Agenda Telefonica");
                System.Console.WriteLine("******************");

                System.Console.WriteLine();
                System.Console.WriteLine(" 1 - Cadastrar agenda");
                System.Console.WriteLine(" 2 - Altere seu cadastro");
                System.Console.WriteLine(" 3 - Remover agenda  ");
                System.Console.WriteLine(" 4 - Buscar agenda   ");
                System.Console.WriteLine(" 5 - Lista           ");
                System.Console.WriteLine(" 0 - Sair            ");

                int opc = int.Parse(Console.ReadLine());
                Console.Clear();



                switch (opc)
                {
                    case 1:
                        Console.Clear();

                        Cadastro(ref agenda);
                        break;

                    case 2:
                        Console.Clear();

                        Atualizar(ref agenda);
                        break;

                    case 3:
                        Console.Clear();

                        Remover(ref agenda);
                        break;

                    case 4:
                        Console.Clear();

                        Procurar(ref agenda);
                        break;


                    case 5:
                        Console.Clear();

                        Lista(ref agenda);
                        break;

                    case 0:
                        quersair = true;
                        break;

                }


            } while (!quersair);
        }


        public static void Cadastro(ref List<AgendaTelefonica> agenda)
        {
            Console.Clear();

            System.Console.WriteLine("Entre com o seu nome:");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Digite o numero de telefone:");
            string telefone = Console.ReadLine();

            System.Console.WriteLine("Digite o seu e-mail");
            string email = Console.ReadLine();


            bool vapo = true;

            foreach (var item in agenda)
            {
                if (email == item.Email)
                {
                    vapo = false;
                    break;

                }
            }
            if (vapo)
            {
                System.Console.WriteLine("Digite sua data de nascimento");
                string data = Console.ReadLine();

                AgendaTelefonica cadastro = new AgendaTelefonica(nome, telefone, data, email);
                agenda.Add(cadastro);
                System.Console.WriteLine();

                Console.Clear();

                Console.WriteLine("Nome: " + cadastro.Nome);
                Console.WriteLine("Telefone: " + cadastro.Telefone);
                Console.WriteLine("Data de nascimento: " + cadastro.DataNascimento);
                System.Console.WriteLine("E-mail: " + cadastro.Email);
                System.Console.WriteLine();
                System.Console.WriteLine("Cadastrado com sucesso !");



            }
            else
            {
                System.Console.WriteLine("E-mail já existente");
                Console.ReadLine();

            }

            Console.ReadLine();


        }


        public static void Atualizar(ref List<AgendaTelefonica> agenda)
        {
            Console.Clear();

            System.Console.WriteLine("Digite seu nome: ");
            string nome1 = Console.ReadLine();



            System.Console.WriteLine(" Digite o telefone: ");
            string telefone1 = Console.ReadLine();

            System.Console.WriteLine("Digite seu e-mail: ");
            string email = Console.ReadLine();



            bool _vapo = false;

            foreach (var item in agenda)
            {
                if (nome1 == item.Nome && email == item.Email)
                {
                    System.Console.WriteLine("Altere seu nome: ");
                    nome1 = Console.ReadLine();
                    item.Nome = nome1;
                    
                    System.Console.WriteLine("altere seu telefone: ");
                    telefone1 = Console.ReadLine();
                    item.Telefone = telefone1;



                    System.Console.WriteLine("Altere seu e-mail: ");
                    email = Console.ReadLine();
                    item.Email = email;


                    _vapo = true;
                }

            }

            if (_vapo)
            {
                System.Console.WriteLine("ALTERADA COM SUCESSO !!");
            }
            else
            {
                System.Console.WriteLine("Agenda não encontrada");
                Console.ReadLine();
            }

            Console.ReadLine();



        }

        public static void Remover(ref List<AgendaTelefonica> agenda)
        {
            Console.Clear();

            System.Console.WriteLine("Entre com o seu nome:");
            string nome = Console.ReadLine();

            bool papo = false;

            foreach (var cadastro in agenda)
            {

                if (nome == cadastro.Nome)
                {
                    agenda.Remove(cadastro);
                    papo = true;
                    break;
                }
            }
            if (papo)
                System.Console.WriteLine("Agenda removida");

            else
            {
                System.Console.WriteLine("Agenda não encontrada");
            }
        }

        public static void Procurar(ref List<AgendaTelefonica> agenda)
        {
            System.Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            bool papo = false;

            foreach (var item in agenda)
            {
                if (nome == item.Nome)
                {

                    papo = true;
                    break;
                }

            }
            if (papo)
            {
                System.Console.WriteLine($"Nome: {nome} ");
            }
            else
            {
                System.Console.WriteLine("agenda não encontrada");
            }

            Console.ReadLine();

        }

        public static void Lista(ref List<AgendaTelefonica> agenda)
        {
            Console.Clear();

            foreach (var item in agenda)
            {

                System.Console.Write($"Nome: {item.Nome} / Telefone: {item.Telefone} / Data de nascimento: {item.DataNascimento} / Email: {item.Email} ");
                System.Console.WriteLine();
            }
            Console.ReadLine();



        }


    }
}
