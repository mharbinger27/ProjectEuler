using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class _016
    {
        // TITLE: Power digit sum

        // DESCRIPTION: 2^15 = 32768 and the sum of its 
        //      digits is 3 + 2 + 7 + 6 + 8 = 26.

        // OBJECTIVE: What is the sum of the digits of the number 2^1000?

        public static void DoWork(int power)
        {
            string accumulatingValue = "1";

            for (int i = 1; i <= power; i++)
            {
                char[] convertedValue = accumulatingValue.ToCharArray();

                // accumulatingValue *= 2;

                Console.WriteLine($"{i}: {accumulatingValue}");
            }

            // iterate i
            // convert string to char array
            // iterate through char array and convert values to ints
            // if value less than 5, double in place
            // if value greater than 5, double and carry a 1
            // save ints in new char array
            // convert char array to string

            Console.WriteLine($"016: {accumulatingValue}");
        }
    }
}
