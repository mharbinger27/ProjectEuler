﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ProjectEuler
{
    public static class _012alt
    {
        // TITLE: Highly divisible triangular number

        // DESCRIPTION: The sequence of triangle numbers is generated by adding the natural 
        //      numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28.
        //      The first ten terms would be: 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
        //      Let us list the factors of the first seven triangle numbers:
        //      1: 1
        //      3: 1,3
        //      6: 1,2,3,6
        //      10: 1,2,5,10
        //      15: 1,3,5,15
        //      21: 1,3,7,21
        //      28: 1,2,4,7,14,28
        //      We can see that 28 is the first triangle number to have over five divisors.

        // OBJECTIVE: What is the value of the first triangle number to 
        //      have over five hundred divisors?

        public static void DoWork(int limit)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            int iteration = 0;
            int runningSum = 0;

            for (int i = 0; iteration <= limit; i++)
            {
                if (i % 2 == 0)
                {
                    iteration = Count(i / 2) * Count(i + 1);
                }
                else
                {
                    iteration = Count(i) * Count((i + 1) / 2);
                }

                if (iteration > 500)
                {
                    iteration = i;
                    break;
                }
            }

            for (int i = 0; i <= iteration; i++)
            {
                runningSum += i;
            }

            Console.WriteLine($"012alt: {runningSum}");
            watch.Stop();
            Console.WriteLine($"Elapsed: {watch.Elapsed}");
        }

        public static int Count(int n)
        {
            int result = 0;

            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    result += 2;

                    if (n / i == i)
                    {
                        result--;
                    }
                }
            }

            return result;
        }
    }
}
