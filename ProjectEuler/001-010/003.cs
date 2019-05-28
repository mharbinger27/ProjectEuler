using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ProjectEuler
{
    public static class _003
    {
        // TITLE: Largest prime factor

        // DESCRIPTION: The prime factors of 13195 are 5, 7, 13, and 29.
        
        // OBJECTIVE: What is the largest prime factor of 600,851,475,143 ?

        public static void DoWork(long targetNumber)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            List<long> potentialPrimes = new List<long>();
            long finalPrime = 0;

            for (long i = 3; i < targetNumber; i += 2)
            {
                if (targetNumber % i == 0)
                {
                    long numberOfInterest = targetNumber / i;

                    if (!potentialPrimes.Contains(numberOfInterest) && !potentialPrimes.Contains(i))
                    {
                        potentialPrimes.Add(numberOfInterest);
                        potentialPrimes.Add(i);
                    }
                    else
                    {
                        potentialPrimes.Sort();
                        potentialPrimes.Reverse();

                        break;
                    }
                }
            }

            foreach (long potentialPrime in potentialPrimes)
            {
                if (Utilities.EvaluatePrime(potentialPrime))
                {
                    finalPrime = potentialPrime;
                    break;
                }
            }

            watch.Stop();

            Console.WriteLine($"003: {finalPrime} in {watch.Elapsed}");

        }
    }
}
