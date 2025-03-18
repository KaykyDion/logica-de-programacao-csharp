using System;
using System.Globalization;

namespace _1006_media2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, heightA, heightB, heightC, heightSum, average;

            heightA = 2;
            heightB = 3;
            heightC = 5;
            heightSum = heightA + heightB + heightC;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            average = ((A * heightA) + (B * heightB) + (C * heightC)) / heightSum;

            Console.WriteLine("MEDIA = " + average.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
