using System;
using System.Globalization;

namespace _1021_notas_e_moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, money, rest;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTAS:");

            money =  N / 100;
            rest =  N % 100;
            Console.WriteLine((int) money + " nota(s) de R$ 100.00");

            money = rest / 50;
            rest = rest % 50;
            Console.WriteLine((int) money + " nota(s) de R$ 50.00");

            money = rest / 20;
            rest = rest % 20;
            Console.WriteLine((int) money + " nota(s) de R$ 20.00");

            money = rest / 10;
            rest = rest % 10;
            Console.WriteLine((int) money + " nota(s) de R$ 10.00");

            money = rest / 5;
            rest = rest % 5;
            Console.WriteLine((int) money + " nota(s) de R$ 5.00");

            money = rest / 2;
            rest = rest % 2;
            Console.WriteLine((int) money + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");

            money = rest / 1;
            rest = rest % 1;
            Console.WriteLine((int) money + " moeda(s) de R$ 1.00");

            money = rest / 0.5;
            rest = rest % 0.5;
            Console.WriteLine((int) money + " moeda(s) de R$ 0.50");

            money = rest / 0.25;
            rest = rest % 0.25;
            Console.WriteLine((int) money + " moeda(s) de R$ 0.25");

            money = rest / 0.10;
            rest = rest % 0.10;
            Console.WriteLine((int) money + " moeda(s) de R$ 0.10");

            money = rest / 0.05;
            rest = rest % 0.05;
            Console.WriteLine((int) money + " moeda(s) de R$ 0.05");

            money = rest / 0.01;
            Console.WriteLine((int) (money + 0.5) + " moeda(s) de R$ 0.01");
        }
    }
}
