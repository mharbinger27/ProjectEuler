using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class Utilities
    {
        public static bool EvaluatePrime(long numberToEvaluate)
        {
            bool isPrimeNumber = true;

            for (long i = 3; i <= Math.Sqrt(numberToEvaluate); i += 2)
            {
                if (numberToEvaluate % i == 0)
                {
                    isPrimeNumber = false;
                    break;
                }
            }

            return isPrimeNumber;
        }
    }
}
