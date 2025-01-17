﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProjectEuler
{
    public static class _006
    {
        // TITLE: Sum square difference

        // DESCRIPTION: The sum of the squares of the first ten natural numbers is,
        //      12 + 22 + ... + 102 = 385
        //      The square of the sum of the first ten natural numbers is,
        //      (1 + 2 + ... + 10)2 = 552 = 3025
        //      Hence the difference between the sum of the squares of the first ten 
        //      natural numbers and the square of the sum is 3025 − 385 = 2640.

        // OBJECTIVE: Find the difference between the sum of the squares of the first 
        //      one hundred natural numbers and the square of the sum.

        public static void DoWork(int topValue)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            long sumOfSquares = 0;
            long squareOfSums = 0;

            for (int i = topValue; i > 0; i--)
            {
                sumOfSquares += (i * i);
                squareOfSums += i;
            }

            squareOfSums = (squareOfSums * squareOfSums);

            watch.Stop();

            Console.WriteLine($"006: {squareOfSums - sumOfSquares} in {watch.Elapsed}");
        }
    }
}
