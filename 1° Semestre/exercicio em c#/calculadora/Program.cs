using System;
namespace Calculadora
{
   class Program
   {
       static void Main(string[] args)
       {
           int num1;
           int num2;
           string oper ;
           double somar, subtrair, multiplicar, dividir, resto ;
           
           


           Console.WriteLine("Digite o 1º número:");
           num1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite o 2º número");
           num2 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite o operador:");
           oper = Console.ReadLine();
           

      

           switch(oper) {

               case "+":
                somar = num1 + num2;
                Console.WriteLine(somar);
               break;

            case "-":
             subtrair = num1 - num2;
             Console.WriteLine(subtrair);
            break;

            case "*":
            multiplicar = num1 * num2;
            Console.WriteLine(multiplicar);
            break;


            case "/":
            dividir = num1 / num2;
            Console.WriteLine(dividir);
            break;

            case "%":
            resto  = num1 % num2;
            Console.WriteLine(resto);
            break;

            default:
            Console.WriteLine ("operação invalida");
            break;
 
       }
       }
   }
}