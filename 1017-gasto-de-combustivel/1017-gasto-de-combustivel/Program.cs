using System;
using System.Globalization;

namespace _1017_gasto_de_combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursSpent, speed, kmPerLiter;
            kmPerLiter = 12;

            hoursSpent = int.Parse(Console.ReadLine());
            speed = int.Parse(Console.ReadLine());

            double result = (double) hoursSpent * speed / kmPerLiter;
            Console.WriteLine(result.ToString("F3", CultureInfo.InvariantCulture)); 
        }
    }
}
