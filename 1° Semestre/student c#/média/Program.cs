using System;

namespace média
{
class Program
   {
       static void Main(string[] args)
       {
           double nota1= 0;
           double nota2 = 0;
           double nota3 = 0;
           double nota4 = 0;
           double média;
           
        Console.WriteLine("Digite a sua 1° nota:");
        nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine ("Digite a sua 2° nota:");
        nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine ("Digite a sua 3° nota:");
        nota3 = double.Parse(Console.ReadLine());
        Console.WriteLine ("Digite a sua 4° nota:");
        nota4 = double.Parse(Console.ReadLine());

        média = (nota1 + nota2 + nota3 + nota4) / 4   ;

        Console.WriteLine("Sua média é: " + média);

        if ( média >= 7){


         Console.WriteLine("Aprovado");

        }else {

         Console.WriteLine("Reprovado");
        }

       }
    
           
       }
   }




