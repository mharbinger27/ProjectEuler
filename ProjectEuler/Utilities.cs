using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class Utilities
    {
        public static bool EvaluatePrime(long numberToEvaluate)
        {
            if (numberToEvaluate < 2)
            {
                return false;
            }

            switch (numberToEvaluate)
            {
                case 3:
                    return true;
                case 5:
                    return true;
                case 7:
                    return true;
                case 9:
                    return false;
                default:
                    break;
            }

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
