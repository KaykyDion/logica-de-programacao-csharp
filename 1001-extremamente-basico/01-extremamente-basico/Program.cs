﻿using System;

namespace _01_extremamente_basico
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, X;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            X = A + B;
            Console.WriteLine("X = " + X);
        }
    }
}
