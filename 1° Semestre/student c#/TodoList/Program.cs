using System;
using System.IO;
using System.Collections.Generic;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TodoItem> todolist = new List<TodoItem>();
            string fileName = "Todo.csv";
            string filePath = ".\\" + fileName;

            try
            {
                string[] todoFile = File.ReadAllLines(filePath);

                foreach (string line in todoFile)
                {
                    string[] itens = line.Split(",");
                    string titulo = itens[0].Replace("\"", "");
                    string nota = itens[1].Replace("\"", "");

                    TodoItem todoitem = new TodoItem(titulo, nota);
                    todolist.Add(todoitem);
                }
            }
            catch (IOException ioe)
            {
                System.Console.Write("Erro de acesso");
                System.Console.WriteLine(ioe.Message);

            }

            int opcao = 0;

            do
            {
                Console.Clear();
                System.Console.WriteLine("Todo List");
                System.Console.WriteLine();
                ListaItens(todolist);
                System.Console.WriteLine("Digite uma opção: ");
                System.Console.WriteLine("1 - Adicionar item");
                System.Console.WriteLine("2 - Remover item");
                System.Console.WriteLine("3 - Sair do programa");
                System.Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        /** 
                         * TODO: Metodo de adicionar item á lista
                        */
                        AddItem(todolist);

                        break;

                    case 2:
                        /** 
                       * TODO: Metodo de adicionar item á lista
                      */
                        RemoveItem(todolist);
                        break;


                    case 3:
                        System.Console.WriteLine("Tchau");
                        SaveItem(todolist, filePath);
                        break;

                    default:
                        System.Console.WriteLine("Opção invalida");
                        Console.ReadLine();
                        break;

                }

            } while (opcao != 3);
        }

        public static void ListaItens(List<TodoItem> todolist)
        {
            Console.Clear();
            int count = 1;
            System.Console.WriteLine("Todo list");
            System.Console.WriteLine();
            System.Console.WriteLine($"ID{"",2} titulo{"",12} Notas");
            foreach (TodoItem item in todolist)
            {
                System.Console.WriteLine($"{count,3}: {item.Titulo,-15} - {item.Nota}");
                count++;
            }

        }



        public static void AddItem(List<TodoItem> todolist)
        {
            Console.Clear();
            System.Console.WriteLine("Novo Item");
            System.Console.WriteLine();
            System.Console.WriteLine("titulo: ");
            string titulo = Console.ReadLine();
            System.Console.WriteLine("Nota: ");
            string nota = Console.ReadLine();
            TodoItem item = new TodoItem(titulo, nota);

            todolist.Add(item);
        }

        public static void RemoveItem(List<TodoItem> todolist)
        {
            int index = 0;

            do
            {
                Console.Clear();
                System.Console.WriteLine("Remove item");
                System.Console.WriteLine();
                ListaItens(todolist);
                System.Console.WriteLine();
                System.Console.WriteLine("Digite o ID para remover ou X para terminar");
                System.Console.WriteLine("ID:");
                string id = Console.ReadLine();


                if (id.ToLower() == "x")
                {
                    break;
                }
                else
                {
                    index = int.Parse(id) - 1;
                }

                if ((index < 0) || (index > todolist.Count - 1))
                {
                    System.Console.WriteLine("Id invalido");
                    System.Console.WriteLine("Pressione <center> para continuar");
                    Console.ReadLine();

                }
                else
                {
                    todolist.RemoveAt(index);
                }
            } while (true);
        }


        #region Gravar arquivo

        public static void SaveItem(List<TodoItem> lista, string filePath)
        {

            List<string> linhas = new List<string>();
            linhas.Add("titulo, nota");

            foreach (TodoItem item in lista)
            {
                string titulo = "\"" + item.Titulo + "\"";
                string Nota = "\"" + item.Nota + "\"";
                linhas.Add(titulo + "," + Nota);
            }
            string tryagain = "n";

            do
            {

                try
                {
                    File.WriteAllLines(filePath, linhas);
                    tryagain = "n";

                }
                catch (IOException e)
                {

                    System.Console.WriteLine("Erro na gravação do arquivo: ");
                    System.Console.WriteLine(e.Message);
                }
                do
                {
                    System.Console.WriteLine("Deseja tentar novamente (s/n)?");
                    tryagain = Console.ReadLine().ToLower();

                } while (tryagain == "s" || tryagain == "n");

            } while (tryagain != "n");
        }
        #endregion
    }
}
