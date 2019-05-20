using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class _005
    {
        // TITLE: Smallest multiple

        // DESCRIPTION: 2520 is the smallest number that can be divided by each 
        // of the numbers from 1 to 10 without any remainder.

        // OBJECTIVE: What is the smallest positive number that is evenly divisible
        // by all of the numbers from 1 to 20?

        public static void DoWork(int limit)
        {
            int smallestMultiple = 0;
            int multipleToCheck = 0;

            do
            {
                multipleToCheck += 20;

                for (int i = 19; i > 0; i--)
                {
                    if (multipleToCheck % i == 0)
                    {
                        if (i == 1)
                        {
                            smallestMultiple = multipleToCheck;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            } while (smallestMultiple == 0);

            Console.WriteLine($"005: {smallestMultiple}");
        }
    }
}
