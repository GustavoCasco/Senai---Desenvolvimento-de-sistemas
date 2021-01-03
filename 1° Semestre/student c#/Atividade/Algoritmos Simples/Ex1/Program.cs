using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {


            double area;
            double perimetro;
            double diagonal;
            double _altura;


            Console.WriteLine("Voce deseja cacular a area de um retangulo ?!");

            Console.WriteLine("Digite altura");
            _altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a base ");
            double Base = double.Parse(Console.ReadLine());


            System.Console.WriteLine();

            System.Console.Write("O perimetro desse retangulo é: ");
            perimetro = Base + Base + _altura + _altura;
            System.Console.WriteLine(perimetro);

            System.Console.WriteLine();
            System.Console.Write("A area desse triangulo é: ");
            area = Base * _altura;
            Console.WriteLine(area);

            System.Console.WriteLine();
            System.Console.Write("A diagonal desse retangulo é: ");
            diagonal = Base * Base + _altura * _altura;
            diagonal = Math.Sqrt(diagonal);
            
            System.Console.WriteLine(diagonal);


        }
    }
}
