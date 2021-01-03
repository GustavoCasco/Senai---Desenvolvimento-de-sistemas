using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string admlogin = "admin";
            string admsenha = "admin";

            Console.WriteLine ("Digite seu login");
            string login = Console.ReadLine ();

             Console.WriteLine ("Digite sua senha");
            string senha = Console.ReadLine ();


            if ((login == admlogin) && senha == admsenha)
            {
                Console.WriteLine("bem vindo admin");
            }else {
              Console.WriteLine("Olá usuário");
            }


        }
    }
}
