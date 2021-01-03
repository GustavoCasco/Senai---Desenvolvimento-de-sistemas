using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
        // Variavéis 
        double reajuste = 30.0/100.0;
        double salario;

        Console.WriteLine("Qual seu salario ? ");
        salario = double.Parse(Console.ReadLine());

      
        if (salario < 500) {
            salario = salario + (salario * reajuste);
            Console.WriteLine  ( "Seu salario atual: "+ salario );
        }else {
            Console.WriteLine ( "Infelizmente essa opção não é valida"); 
            
        }


        {
            
        }
        }
    }
}
