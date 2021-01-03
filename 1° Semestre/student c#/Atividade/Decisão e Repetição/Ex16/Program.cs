using System;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            
            Console.Write("Digite o seu peso: ");
            double P = double.Parse(Console.ReadLine());
            Console.Write("Digite o seu altura: ");
            double A = double.Parse(Console.ReadLine());
            double imc = (P / (A * A));

            System.Console.WriteLine(imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Peso abaixo do normal");
            }
            else if ((imc == 18.5) || (imc == 25))
            {
                Console.WriteLine("Peso normal");
            }
            if ((imc > 25) || (imc == 30))
            {
                Console.WriteLine("Sobre o Peso");
            }
            else if ((imc > 30) || (imc == 35))
            {
                Console.WriteLine("Grau de Obesidade I");
            }
            if ((imc > 35) || (imc == 40))
            {
                Console.WriteLine("Grau de Obesidade II");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Obesidade Grau III");
            }


        }
    }
}
