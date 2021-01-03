using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
           string _oper;
           double altura;
           double gmbase;
            int menor;
            int id;
           
            double pi = 3.14;
            
            do
            {
                
            Console.WriteLine("quadrado --q");
            Console.WriteLine("triangulo --t");
            Console.WriteLine("circulo --c");
            Console.WriteLine("trapezio --tr");
            Console.WriteLine("retangulo --r");
            Console.WriteLine("losango --l");
            _oper = Console.ReadLine();

            switch (_oper)
            {
                case "q":
                Console.Write ("Voce deseja cacular a area de um quadrado ?!");

                Console.WriteLine ("Digite a largura");
                gmbase = double.Parse(Console.ReadLine ());

                Console.WriteLine ("Digite a largura");
                gmbase = double.Parse(Console.ReadLine ());

                double area = gmbase * gmbase;
                Console.WriteLine(area);
                break;

                case "t":
                
               

                Console.WriteLine ("Digite a altura");
                altura = double.Parse(Console.ReadLine ());

                Console.WriteLine ("Digite a base");
                gmbase = double.Parse(Console.ReadLine ());

                area = gmbase * altura;
                Console.WriteLine(area);
                break;

                case "c":
                Console.WriteLine ("Voce deseja cacular a area de um quadrado ?!");

                Console.WriteLine ("Digite a altura");
                altura = double.Parse(Console.ReadLine ());

                Console.WriteLine ("Digite a base");
                gmbase = double.Parse(Console.ReadLine ());

                area = pi * altura;
                Console.WriteLine(area);
                break;

                case "tr":

                Console.WriteLine ("Voce deseja cacular a area de um trapezio ?!");

                Console.WriteLine ("Digite a base maior");
                altura = double.Parse(Console.ReadLine ());

                Console.WriteLine ("Digite a base menor");
                id = int.Parse(Console.ReadLine ());

                Console.WriteLine ("Digite a altura");
                menor = int.Parse(Console.ReadLine ());


                    area = ((id + menor) * altura / 2);
                    Console.WriteLine(area);
                    break;

                 case "r":

                Console.WriteLine ("Voce deseja cacular a area de um retangulo ?!");

                Console.WriteLine ("Digite altura");
                altura = double.Parse(Console.ReadLine ());

                Console.WriteLine ("Digite a base ");
                gmbase = double.Parse(Console.ReadLine ());

               


                area = gmbase * altura;
                Console.WriteLine(area);

                break;

                 case "l":

                Console.WriteLine ("Voce deseja cacular a area de um trapezio ?!");

                Console.WriteLine ("Digite a base maior");
                altura = double.Parse(Console.ReadLine ());

                Console.WriteLine ("Digite a base menor");
                gmbase = double.Parse(Console.ReadLine ());

                Console.WriteLine ("Digite a altura");
                gmbase = double.Parse(Console.ReadLine ());


               area = gmbase*gmbase  / 2;
               Console.WriteLine (area);

                break;
            }    
            } while (_oper != "fim" ); 
            
                
            




            
        }     
    }
}

