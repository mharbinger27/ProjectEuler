using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProjectEuler
{
    public static class _007
    {
        // TITLE: 10,001st prime

        // DESCRIPTION: By listing the first six prime numbers: 2, 3, 5, 7, 11, 
        //      and 13, we can see that the 6th prime is 13.

        // OBJECTIVE: What is the 10,001st prime number?

        public static void DoWork(int limit)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            List<long> primesList = new List<long>();
            long currentValue = 1;

            primesList.Add(2);

            while (primesList.Count < limit)
            {
                currentValue += 2;

                if (Utilities.EvaluatePrime(currentValue))
                {
                    primesList.Add(currentValue);
                }
            }

            watch.Stop();

            Console.WriteLine($"007: {primesList[limit - 1]} in {watch.Elapsed}");
        }

        
    }
}
