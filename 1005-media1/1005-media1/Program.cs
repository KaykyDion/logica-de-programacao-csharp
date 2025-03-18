using System;
using System.Globalization;

namespace _1005_media1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, heightA, heightB, average;
            heightA = 3.5;
            heightB = 7.5;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            average = ((A * heightA) + (B * heightB)) / (heightA + heightB);

            Console.WriteLine("MEDIA = " + average.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
