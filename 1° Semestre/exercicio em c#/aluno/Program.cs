using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
           Aluno aluno1 = new Aluno("Cascão",  "516285508-13");
           Aluno aluno2 = new Aluno("Hebert Richard", "Dev", "516285508-13");
           Console.WriteLine("Nome: " + aluno1.Nome);
           Console.WriteLine("curso: " + aluno1.Curso);
           Console.WriteLine ("Cpf: " + aluno1.Cpf);

         Console.WriteLine();

         Console.WriteLine("Nome: " + aluno2.Nome);
         Console.WriteLine("curso: " + aluno2.Curso);
         Console.WriteLine ("Cpf: " + aluno2.Cpf);

         Console.Write("Entre com o seu nome: ");
         string nome = Console.ReadLine();

         Console.Write("Digite seu cpf: ");
         string cpf = Console.ReadLine();

         Console.Write("Entre com o curso: ");
         string curso = Console.ReadLine();

         Console.Write("Entre com a nota: ");
         int nota = int.Parse(Console.ReadLine());

         Console.Write("Entre com o bimestre: ");
         int bimestre = int.Parse(Console.ReadLine());
         
         Aluno aluno3 = new Aluno(nome, cpf , curso);
         aluno3.setNotas(bimestre, nota);

        Console.WriteLine("Nome: " + aluno3.Nome);
        Console.WriteLine("curso: " + aluno3.Curso);
        Console.WriteLine ("Cpf: " + aluno3.Cpf);
        Console.WriteLine("Notas: ");

        foreach (int N in aluno3.getNotas())
        {
            Console.Write(N + " ");
        }
       
        }
    }
}
