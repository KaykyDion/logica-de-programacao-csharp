﻿using System;

namespace _1004_produto_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, PROD;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            PROD = A * B;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}
