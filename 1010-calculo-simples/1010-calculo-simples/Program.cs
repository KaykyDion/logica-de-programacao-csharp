using System;
using System.Globalization;

namespace _1010_calculo_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');

            double firstPrice = double.Parse(firstLine[2], CultureInfo.InvariantCulture);
            double secondPrice = double.Parse(secondLine[2], CultureInfo.InvariantCulture);

            int firstAmount = int.Parse(firstLine[1]);
            int secondAmount = int.Parse(secondLine[1]);

            double fullPrice = firstPrice * firstAmount + secondPrice * secondAmount;
            
            Console.WriteLine("VALOR A PAGAR: R$ " + fullPrice.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
