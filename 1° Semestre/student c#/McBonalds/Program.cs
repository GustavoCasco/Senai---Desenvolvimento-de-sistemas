using System;

namespace McBonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Hebert Richard","55 11 70707070", "email@gmail.com");
            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Telefone " + cliente1.Telefone);
            Console.WriteLine("Email: " + cliente1.Email);
        }
    }
}
