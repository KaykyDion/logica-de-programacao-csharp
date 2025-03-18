using System;
using System.Globalization;

namespace _1015_distancia_entre_dois_pontos
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, distance;

            string[] vet1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet1[0]);
            y1 = double.Parse(vet1[1]);

            string[] vet2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet2[0]);
            y2 = double.Parse(vet2[1]);

            distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine(distance.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
