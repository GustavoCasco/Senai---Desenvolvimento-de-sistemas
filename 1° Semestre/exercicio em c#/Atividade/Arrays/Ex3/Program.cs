using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Ex3
{
    class Program
    {

        static void Main(string[] args)
        {
            string nota100 = "Nota 100";
            string nota50 = "Nota 50";
            string nota20 = "Nota 20";
            string nota10 = "Nota 10";
            string nota5 = "Nota 5";
            Console.Write("Digite o valor do seu saque: ");
            int saque = int.Parse(Console.ReadLine());
            List<string> valor = new List<string>();
            if (saque % 5 == 0)
            {
                do
                {
                    if (saque >= 100)
                    {
                        saque -= 100;
                        valor.Add(nota100);
                        continue;
                    }
                    else if (saque >= 50)
                    {
                        saque -= 50;
                        valor.Add(nota50);
                        continue;
                    }
                    else if (saque >= 20)
                    {
                        saque -= 20;
                        valor.Add(nota20);
                        continue;
                    }
                    else if (saque >= 10)
                    {
                        saque -= 10;
                        valor.Add(nota10);
                        continue;
                    }
                    else if (saque >= 5)
                    {
                        saque -= 5;
                        valor.Add(nota5);
                        continue;
                    }
                } while (saque != 0);
                int n100 = 0;
                int n50 = 0;
                int n20 = 0;
                int n10 = 0;
                int n5 = 0;
                foreach (var item in valor)
                {
                    n100 = valor.Where(x => x.Equals(nota100)).Count();
                    n50 = valor.Where(x => x.Equals(nota50)).Count();
                    n20 = valor.Where(x => x.Equals(nota20)).Count();
                    n10 = valor.Where(x => x.Equals(nota10)).Count();
                    n5 = valor.Where(x => x.Equals(nota5)).Count();
                }
                if (n5 != 0)
                {
                    System.Console.WriteLine($"Notas de 5: {n5}");
                }
                if (n10 != 0)
                {
                    System.Console.WriteLine($"Notas de 10: {n10}");
                }
                if (n20 != 0)
                {
                    System.Console.WriteLine($"Notas de 20: {n20}");
                }
                if (n50 != 0)
                {
                    System.Console.WriteLine($"Notas de 50: {n50}");
                }
                if (n100 != 0)
                {
                    System.Console.WriteLine($"Notas de 100: {n100}");
                }
            }
            else
            {
                System.Console.WriteLine("Valor de saque inválido!");
            }
        }
    }
}