using System;
using System.Globalization;

namespace _1013_o_maior
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, ABSum, biggest;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            ABSum = (A + B + Math.Abs(A - B)) / 2;

            biggest = (ABSum + C + Math.Abs(ABSum - C)) / 2;

            Console.WriteLine(biggest + " eh o maior");
        }
    }
}
