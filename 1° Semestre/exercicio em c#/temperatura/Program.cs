using System;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] temperatura = new double [12];
            double maior = 0;
            double menor = 0;

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"digite a temperatura do mês {i +1}: ");
                temperatura[i] = double.Parse(Console.ReadLine());
            }

            menor = temperatura[0];
            maior = temperatura[0];

            foreach (double _temp in temperatura)
            {
                if (_temp > maior)
                {
                    maior = _temp;

                }else if (_temp < menor)
                {
                    menor = _temp;
                }            
                
            }

            Console.WriteLine ($"Sua maior temperatura é:  {maior}");
            Console.WriteLine ($"Sua menor temperatura é:  {menor}");

        }
    }
}
