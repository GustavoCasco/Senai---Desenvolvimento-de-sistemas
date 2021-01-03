using System;
using MataODragao.Models;
using System.Collections.Generic;



namespace MataODragao
{
    class Program
    {
        static void Main(string[] args)
        {

            bool JogadorNaoDesistiu = true;

            do
            {



                Console.Clear();
                System.Console.WriteLine("******************************");
                System.Console.WriteLine("        Mata o Dragão! ");
                System.Console.WriteLine("******************************");

                System.Console.WriteLine(" 1 - Iniciar Jogo");
                System.Console.WriteLine(" 0 - Sair do Jogo");

                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador)
                {
                    case "1":
                        Console.Clear();

                        Guerreiro guerreiro = CriarGuerreiro();
                        Dragao dragao = CriarDragao();



                        //*Incio - Primeiro Dialogo */
                        CriarDialogo(guerreiro.Nome, $"{dragao.Nome}, seu louco! Vim-lhe derrotar-lhe");


                        CriarDialogo(dragao.Nome, $"{guerreiro.Nome}, Humano tolinho. Quem pensas que és!");

                        FinalizarDialogo();
                        //*fim - Primeiro Dialogo */

                        //*INICIO -segundo dialogo */
                        CriarDialogo(guerreiro.Nome, $"Eu sou { guerreiro.Nome}!  sua criatura morfética.");
                        CriarDialogo(guerreiro.Nome, $" Vim de {guerreiro.CidadeNatal}! para derrotar-te e mostrar meu valor!");
                        CriarDialogo(dragao.Nome, $"Quem ? De onde ? Bom, que seja... fritar-te-ei e devorar-te-ei, primata insolente");
                        System.Console.WriteLine("BAMBAM: tá na hora do show!");

                        FinalizarDialogo();


                        //*FIM - segundo dialogo */


                        bool JogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderAtaque = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        bool JogadorNaoCorreu = true;

                        if (JogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine("*** Turno do Jogador***");
                            System.Console.WriteLine("Escolha uma ação: ");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaodeBatalhaJogador = Console.ReadLine();

                            switch (opcaodeBatalhaJogador)
                            {
                                case "1":
                                    Random GeradorNumeroAleatorio = new Random();
                                    int NumeroAleatorioJogador = GeradorNumeroAleatorio.Next(0, 5);
                                    int NumeroAleatorioDragao = GeradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, largato Maldito, hijo de puta");
                                        dragao.Vida -= (poderAtaque + 5);
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro {guerreiro.Vida}");

                                    }
                                    else { System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errrooouuuuu"); }
                                    break;

                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Mete macha");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG E2");
                                    JogadorNaoCorreu = false;
                                    break;
                            }
                        }

                        FinalizarDialogo();

                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && JogadorNaoCorreu)
                        {
                            System.Console.WriteLine("*** Turno Dragão ***");
                        
                            

                            Random GeradorNumeroAleatorio = new Random();
                            int NumeroAleatorioJogador = GeradorNumeroAleatorio.Next(0, 5);
                            int NumeroAleatorioDragao = GeradorNumeroAleatorio.Next(0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                            if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                            {
                                System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Toma essa, Humano safado");
                                guerreiro.Vida -= dragao.Forca;
                                System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                System.Console.WriteLine($"HP Guerreiro {guerreiro.Vida}");

                            }
                            else { System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Grrrr, Dragon hijo de puta"); }


                            FinalizarDialogo();

                            Console.Clear();

                            System.Console.WriteLine("*** Turno do jogador***");
                            System.Console.WriteLine("Escolha uma ação: ");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaodeBatalhaJogador = Console.ReadLine();

                            switch (opcaodeBatalhaJogador)
                            {
                                case "1":

                                    NumeroAleatorioJogador = GeradorNumeroAleatorio.Next(0, 5);
                                    NumeroAleatorioDragao = GeradorNumeroAleatorio.Next(0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, largato Maldito, hijo de puta");
                                        dragao.Vida -= (poderAtaque + 5);
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro {guerreiro.Vida}");

                                    }
                                    else { System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errrooouuuuu"); }
                                    break;

                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Mete macha");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG E2");
                                    JogadorNaoCorreu = false;
                                    break;
                            }



                        }

                        if (guerreiro.Vida <= 0)
                        {
                            System.Console.WriteLine("Você perdeu");
                        }

                        if (dragao.Vida <= 0)
                        {
                            System.Console.WriteLine("Você venceu");
                        }
                        break;

                    case "0":
                        JogadorNaoDesistiu = false;
                        System.Console.WriteLine("Se fu***");
                        break;

                    default:
                        System.Console.WriteLine("Comando Inválido!");
                        break;
                }
            } while (JogadorNaoDesistiu);




        }

        public static void CriarDialogo(string nome, string frase)
        {

            System.Console.WriteLine($"{nome.ToUpper()}; \n {frase}");
        }

        public static void FinalizarDialogo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte o ENTER para prosseguir");
            Console.ReadLine();
            Console.Clear();

        }

        public static Guerreiro CriarGuerreiro()
        {
            Guerreiro guerreiro = new Guerreiro();
            guerreiro.Nome = "Hebert";
            guerreiro.Sobrenome = "Richard";
            guerreiro.CidadeNatal = "Nárnia";
            guerreiro.DatadeNascimento = DateTime.Parse("07/07/1447");
            guerreiro.FerramentadeProtecao = "Escudo";
            guerreiro.FerramentadeAtaque = "Espadinha mixuruca";
            guerreiro.Forca = 20;
            guerreiro.Destreza = 15;
            guerreiro.Inteligencia = 18;
            guerreiro.Vida = 100;

            return guerreiro;
        }

        public static Dragao CriarDragao()
        {
            Dragao dragao = new Dragao();
            dragao.Nome = "Dragonite";
            dragao.Forca = 5;
            dragao.Destreza = 1;
            dragao.Inteligencia = 3;
            dragao.Vida = 300;

            return dragao;
        }
        
    }
}
