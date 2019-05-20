using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class _001
    {
        // TITLE: Multiples of 3 and 5

        // DESCRIPTION: If we list all the natural numbers below 10 that are 
        //      multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

        // OBJECTIVE: Find the sum of all the multiples of 3 or 5 below 1000.

        public static void DoWork(int limit)
        {
            int sum = 0;

            for (int i = 0; i < limit; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }

                else if (i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"001: {sum}");
        }
    }
}
