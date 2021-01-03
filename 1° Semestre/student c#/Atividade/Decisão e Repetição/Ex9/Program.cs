using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quersair = true;
            do
            {

                System.Console.WriteLine("****************************");
                System.Console.WriteLine("PeSo NoS pLaNeTas           ");
                System.Console.WriteLine("****************************");


                System.Console.WriteLine("1 - Mercúrio");
                System.Console.WriteLine("2 - Vênus   ");
                System.Console.WriteLine("3 - Marte   ");
                System.Console.WriteLine("4 - Júpiter ");
                System.Console.WriteLine("5 - Saturno ");
                System.Console.WriteLine("6 - Urano   ");
                System.Console.WriteLine();
                double peso = double.Parse(Console.ReadLine());

                System.Console.WriteLine();

                double peson;
                switch (peso)
                {
                    case 1:
                        System.Console.Write("Digite o seu peso: ");
                        peso = double.Parse(Console.ReadLine());
                        peson = (peso / 10) * 0.37;
                        System.Console.WriteLine($"Seu peso em Mercúrio é: {peson} Kg");
                        
                        
                        break;

                    case 2:
                        System.Console.Write("Digite o seu peso: ");
                        peso = double.Parse(Console.ReadLine());
                        peson = (peso / 10) * 0.88;
                        System.Console.WriteLine($"Seu peso em Vênus é: {peson} Kg");
                        
                        
                        break;

                    case 3:
                        System.Console.Write("Digite o seu peso: ");
                        peso = double.Parse(Console.ReadLine());
                        peson = (peso / 10) * 0.38;
                        System.Console.WriteLine($"Seu peso em Marte é: {peson} Kg");
                    
                        
                        break;

                    case 4:
                        System.Console.Write("Digite o seu peso: ");
                        peso = double.Parse(Console.ReadLine());
                        peson = (peso / 10) * 2.64;
                        System.Console.WriteLine($"Seu peso em Júpiter é: {peson} Kg");
                        
                        
                        break;

                    case 5:
                        System.Console.Write("Digite o seu peso: ");
                        peso = double.Parse(Console.ReadLine());
                        peson = (peso / 10) * 1.15;
                        System.Console.WriteLine($"Seu peso em Saturno é: {peson} Kg");
                       
                        
                        break;

                    case 6:
                        System.Console.Write("Digite o seu peso: ");
                        peso = double.Parse(Console.ReadLine());
                        peson = (peso / 10) * 1.17;
                        System.Console.WriteLine($"Seu peso em Urano é: {peson} Kg");
                      
                        
                        break;

                        case 0:
                        quersair = false;
                        break;



            }
                } while (quersair);
        }
    }
}
