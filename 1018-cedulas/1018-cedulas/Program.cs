using System;

namespace _1018_cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, hundred, fifty, twenty, ten, five, two, one;

            N = int.Parse(Console.ReadLine());

            hundred = N / 100;
            fifty = (N % 100) / 50;
            twenty = (N % 100) % 50 / 20;
            ten = ((N % 100) % 50) % 20 / 10;
            five = (((N % 100) % 50) % 20) % 10 / 5;
            two = ((((N % 100) % 50) % 20) % 10) % 5 / 2;
            one = (((((N % 100) % 50) % 20) % 10) % 5) % 2 / 1;

            Console.WriteLine(N.ToString());
            Console.WriteLine(hundred + " nota(s) de R$ 100,00");
            Console.WriteLine(fifty + " nota(s) de R$ 50,00");
            Console.WriteLine(twenty + " nota(s) de R$ 20,00");
            Console.WriteLine(ten + " nota(s) de R$ 10,00");
            Console.WriteLine(five + " nota(s) de R$ 5,00");
            Console.WriteLine(two + " nota(s) de R$ 2,00");
            Console.WriteLine(one + " nota(s) de R$ 1,00");
        }
    }
}
