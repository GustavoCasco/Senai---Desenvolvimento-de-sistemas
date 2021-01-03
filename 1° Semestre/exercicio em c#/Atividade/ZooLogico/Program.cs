using System;
using System.Linq;
using ZooLogico.Interfaces;
using ZooLogico.Models.Animais;

namespace ZooLogico
{
    /**
     * ----------------------------------------------------------------------------------------------------
     * * _Aplicação: Zoo Lógico
     * * _Branch: master
     * * TEMA: INTERFACE E POLIMORFISMO
     * ----------------------------------------------------------------------------------------------------
     *   Objetivo: Exercitar o polimorfismo usando interfaces.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Variável de controle do Loop Principal
            var encerrouPrograma = false;
            Animal[] pasto = new Animal[3];
            Animal[] gaiola = new Animal[3];
            Animal[] arvore = new Animal[3];
            Animal[] cavernapedra = new Animal[3];
            Animal[] piscinagelada = new Animal[3];
            Animal[] piscina = new Animal[3];
            Animal[] aquario = new Animal[3];

            #region Loop Principal
            do
            {
                #region Menu Principal
                var codigo = 0;
                Console.Clear();
                System.Console.WriteLine("===============================");
                System.Console.WriteLine("|  Bem- vindo ao Zoo Lógico!  |");
                System.Console.WriteLine("===============================");
                // Gerar os itens do menu de forma automática
                foreach (var item in Arca.Animais.Values)
                {
                    System.Console.WriteLine($"{"",5}{++codigo}. {item.GetType().Name}");
                }
                #endregion
                System.Console.Write($"\n{"",2}Digite o código do animal: ");

                // Testando se o usuário digitou um código correto ou não
                try
                {
                    var opcaoUsuario = int.Parse(Console.ReadLine());
                    var animal = Arca.Animais[opcaoUsuario];
                    ClassificarAnimal(animal, pasto, gaiola, arvore, cavernapedra, piscina, aquario);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("Por favor, digite um código válido");
                    Console.ReadLine();

                }
            } while (!encerrouPrograma);
            #endregion
        }
        public static void ClassificarAnimal(Animal animal, Animal[] pasto, Animal[] gaiola, Animal[] arvore, Animal[] cavernapedra, Animal[] piscinagelada, Animal[] piscina, Animal[] aquario)
        {
            // Esse @ é para que possamos usar o nome interface para a variável, que é uma palavra reservada do C#!
            var classe = animal.GetType();
            var @interface = classe.GetInterfaces().FirstOrDefault();

            if ((typeof(IAquatico)).Equals(@interface))
            {
                int index = 0;
                foreach (var item in piscina)
                {
                    if (item == null)
                    {
                        System.Console.WriteLine($":::{classe.Name} pode ir para a Piscina:::");
                        piscina[index] = animal;
                        var remover = Arca.Animais.Remove(opcaoUsuario);

                    }
                }

            }
            else if ((typeof(IArboricula)).Equals(@interface))
            {
                int index = 0;
                foreach (var item in arvore)
                {
                    if (item == null)
                    {

                        System.Console.WriteLine($":::{classe.Name} pode ir para a Casa na Árvore:::");
                        arvore[index] = animal;
                        var remover = Arca.Animais.Remove(opcaoUsuario);

                    }
                }
            }
            else if ((typeof(IBranquiado)).Equals(@interface))
            {
                int index = 0;
                foreach (var item in aquario)
                {
                    if (item == null)
                    {

                        System.Console.WriteLine($":::{classe.Name} pode ir para o Aquário:::");
                        aquario[index] = animal;
                        var remover = Arca.Animais.Remove(opcaoUsuario);

                    }
                }
            }
            else if ((typeof(IQuionofilo)).Equals(@interface))
            {
                int index = 0;
                foreach (var item in piscinagelada)
                {
                    if (item == null)
                    {

                        System.Console.WriteLine($":::{classe.Name} pode ir para a Piscina Gelada:::");
                        piscinagelada[index] = animal;
                        var remover = Arca.Animais.Remove(opcaoUsuario);

                    }
                }
            }
            else if ((typeof(ITerrestre)).Equals(@interface))
            {
                int index = 0;
                foreach (var item in cavernapedra)
                {
                    if (item == null)
                    {

                        System.Console.WriteLine($":::{classe.Name} pode ir para os Pastos ou Caverna de Pedra:::");
                        cavernapedra[index] = animal;
                        var remover = Arca.Animais.Remove(opcaoUsuario);

                    }
                }
            }
            else if ((typeof(IVoador)).Equals(@interface))
            {
                int index = 0;
                foreach (var item in gaiola)
                {
                    if (item == null)
                    {

                        System.Console.WriteLine($":::{classe.Name} pode ir para a Gaiola:::");
                        gaiola[index] = animal;
                        var remover = Arca.Animais.Remove(opcaoUsuario);

                    }
                }
            }

            Console.ReadLine();

        }




    }
}
