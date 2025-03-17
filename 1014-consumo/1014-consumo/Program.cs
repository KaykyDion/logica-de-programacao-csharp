using System;
using System.Globalization;

namespace _1014_consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceTraveled = int.Parse(Console.ReadLine());
            double spentFuel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumption = distanceTraveled / spentFuel;

            Console.WriteLine(consumption.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
