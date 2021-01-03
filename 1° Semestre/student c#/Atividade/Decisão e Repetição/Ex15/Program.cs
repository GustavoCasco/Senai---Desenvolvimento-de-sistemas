using System;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("******************");
            System.Console.WriteLine(" Calendario       ");
            System.Console.WriteLine("******************");

            System.Console.WriteLine("Digite um numero : ");
            int mes = int.Parse(Console.ReadLine());


            switch (mes)
            {
                case 1:
                System.Console.Write("Esse mês é Janeiro");
                break;

                case 2:
                System.Console.Write("Esse mês é Fevereiro");
                break;

                case 3:
                System.Console.Write("Esse mês é Março");
                break;

                case 4:
                System.Console.Write("Esse mês é Abril");
                break;

                case 5:
                System.Console.Write("Esse mês é Maio");
                break;

                case 6:
                System.Console.Write("Esse mês é Junho");
                break;

                case 7:
                System.Console.Write("Esse mês é Julho");
                break;

                case 8:
                System.Console.Write("Esse mês é Agosto");
                break;

                case 9:
                System.Console.Write("Esse mês é Setembro");
                break;

                case 10:
                System.Console.Write("Esse mês é Outubro");
                break;

                case 11:
                System.Console.Write("Esse mês é Novembro");
                break;

                case 12:
                System.Console.Write("Esse mês é Dezembro");
                break;


                
            }
        }
    }
}
