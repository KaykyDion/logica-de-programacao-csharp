using System;
using System.Globalization;

namespace _1008_salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, hoursWorked;
            double hourlyRate, salary;

            id = int.Parse(Console.ReadLine());
            hoursWorked = int.Parse(Console.ReadLine());

            hourlyRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = hourlyRate * hoursWorked;

            Console.WriteLine("NUMBER = " + id);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
