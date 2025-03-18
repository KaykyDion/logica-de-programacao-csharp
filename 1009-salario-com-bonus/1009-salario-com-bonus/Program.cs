using System;
using System.Globalization;

namespace _1009_salario_com_bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double sallary, salesAmount, commission, total;

            name = Console.ReadLine();
            sallary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salesAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            commission = salesAmount * 15 / 100;

            total = commission + sallary;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
