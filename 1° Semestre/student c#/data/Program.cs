using System;

namespace data
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            int idade;
            

           

           do
           {
              Console.WriteLine("Diga qual ano você nasceu ?");
            ano = int.Parse(Console.ReadLine());
                if ((ano > 2022) || (ano <0))
                {
                    
                }
               
           } while ((ano > 2019)  || (ano < 0));
           
            idade = 2019 - ano;
         

            

           if (idade < 3)
           {
                Console.WriteLine("Voce tem " + idade + " anos ");
               Console.WriteLine("Recém nascido");
           } else if ((idade >= 3) && (idade <= 11)) {
                Console.WriteLine("Voce tem " + idade + " anos ");
               Console.WriteLine("Criança");

           } else if ((idade >=12) && (idade <= 19))
           {
                Console.WriteLine("Voce tem " + idade + " anos ");
               Console.WriteLine("adolescente");
           } else if ((idade >=20) && (idade <=65))
           {
                Console.WriteLine("Voce tem " + idade + " anos ");
               Console.WriteLine("Voce é um adulto");

           } else if (idade > 65) {
                Console.WriteLine("Voce tem " + idade + " anos ");
               Console.WriteLine("Voce é um idoso");
           } else
           {
               
           }
            
            
           
             
             
            
                      
           
           
              
        
        
        
          
           
           }   
        }
    }


