using System;
using System.Globalization;

namespace _1011_esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, volume;

            pi = 3.14159;
            int R = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = (4/3.0) * pi * Math.Pow(R, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
