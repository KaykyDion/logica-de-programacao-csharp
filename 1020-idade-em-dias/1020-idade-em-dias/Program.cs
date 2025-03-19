using System;

namespace _1020_idade_em_dias
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, months, years, days, rest;

            day = int.Parse(Console.ReadLine());

            years = day / 365;
            rest = day % 365;
            Console.WriteLine(years + " ano(s)");

            months = rest / 30;
            rest = rest % 30;
            Console.WriteLine(months + " mes(es)");

            days = rest;
            Console.WriteLine(days + " dia(s)");
        }
    }
}
