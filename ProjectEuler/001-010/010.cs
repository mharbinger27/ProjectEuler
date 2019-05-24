using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ProjectEuler
{
    public static class _010
    {
        // TITLE: Summation of primes

        // DESCRIPTION: The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

        // OBJECTIVE: Find the sum of all the primes below two million.

        public static void DoWork(int limit)
        {
            long sum = 2;

            for (int i = 3; i < limit; i += 2)
            {
                if (Utilities.EvaluatePrime(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine($"010: {sum}");
        }
    }
}
