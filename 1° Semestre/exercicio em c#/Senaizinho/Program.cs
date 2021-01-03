using System;


namespace Senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int limitealuno = 10;
            int limitesalas = 10;
            Aluno[] alunos = new Aluno[100];
            Sala[] salas = new Sala[10];
            int alunoscadastrado = 0;
            int salascadastrada = 0;
            int total = 100;



            do
            {
                Console.Clear();
                System.Console.WriteLine("******************************");
                System.Console.WriteLine("       Senaizinho  ");
                System.Console.WriteLine("******************************");

                System.Console.WriteLine(" 1 - Cadastrar Aluno");
                System.Console.WriteLine(" 2 - Cadastrar Sala");
                System.Console.WriteLine(" 3 - Alocar Aluno");
                System.Console.WriteLine(" 4 - Remover Aluno");
                System.Console.WriteLine(" 5 - Verificar aluno");
                System.Console.WriteLine(" 6 - Verificar Sala");
                System.Console.WriteLine(" 0 - Sair");
                int menu = int.Parse(Console.ReadLine());


                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        System.Console.WriteLine("Cadastrar Aluno");
                        CadastrarAluno(alunos, total, ref alunoscadastrado);


                        break;

                    case 2:
                        Console.Clear();

                        System.Console.WriteLine();
                        System.Console.WriteLine("Cadastrar Sala");
                        CadastrarSala(salas, total, ref salascadastrada);
                        break;

                    case 3:
                        Console.Clear();
                        System.Console.WriteLine();
                        System.Console.WriteLine("Alocar Aluno");

                        break;

                    case 4:
                        Console.Clear();
                        System.Console.WriteLine();
                        System.Console.WriteLine("Remover Aluno");

                        break;

                    case 5:
                        Console.Clear();
                        System.Console.WriteLine();
                        System.Console.WriteLine("Verificar sala");

                        break;

                    case 6:
                        Console.Clear();
                        System.Console.WriteLine();
                        System.Console.WriteLine("Verificar Aluno");

                        break;








                }


            } while (true);

        }



        public static void CadastrarAluno(Aluno[] alunos, int total, ref int alunoscadastrado)
        {
            if (alunoscadastrado < total)
            {
                System.Console.WriteLine("Cadastro de alunos");
                System.Console.WriteLine();
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Data de nascimento: ");
                DateTime DataNascimento = DateTime.Parse(Console.ReadLine());

                Aluno novoaluno = new Aluno();
                novoaluno.Nome = nome;
                novoaluno.DataNascimento = DataNascimento;

                int index = 0;
                foreach (Aluno aluno in alunos)
                {
                    if (aluno != null)
                    {

                        index++;
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Erro");
                    }



                }
                alunos[index] = novoaluno;
                alunoscadastrado++;
            }
        }

        public static void CadastrarSala(Sala[] salas, int total, ref int salascadastrada)
        {

            int index = 0;
            if (salascadastrada < 10)
            {
                System.Console.WriteLine("Cadastro de salas: ");
                System.Console.WriteLine();
                System.Console.Write("Sala: ");
                int nsala = int.Parse(Console.ReadLine());

                Sala sala1 = new Sala(nsala, 10);

                foreach (Sala sala in salas)
                {
                    if (sala != null)
                    {
                        index++;
                        break;
                    }
                }
                salas[index] = sala1;

                salascadastrada++;
                System.Console.WriteLine("Sala cadastrada");

            }
            else
            {
                System.Console.WriteLine("Capacidade de alunos nessa escola");
            }

        }




        public void AlocarAluno()
        {

        }


        public void RemoverAluno()
        {









        }
        public void VerificarAula()
        {

        }

        public void VerificarSala()
        {

        }



    }
}

