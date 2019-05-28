using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProjectEuler
{
    public static class _009
    {
        // TITLE: Special Pythagorean triplet

        // DESCRIPTION: A Pythagorean triplet is a set of three natural numbers, 
        //      a < b < c, for which, a^2 + b^2 = c^2.  For example, 
        //      3^2 + 4^2 = 9 + 16 = 25 = 5^2.

        // OBJECTIVE: There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        //      Find the product abc.

        public static void DoWork(int limit)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            int a = 0;
            int b = 0;
            int c = 0;
            int solution = 0;

            for (int i = 3; i <= limit; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    for (int k = 1; k < j; k++)
                    {
                        if (i + k + j == 1000)
                        {
                            if (Math.Pow(j, 2) + Math.Pow(k, 2) == Math.Pow(i, 2))
                            {
                                a = j;
                                b = k;
                                c = i;

                                solution = a * b * c;
                                break;
                            }
                        }
                    }
                }
            }

            watch.Stop();

            Console.WriteLine($"009: {a * b * c} in {watch.Elapsed}");
        }
    }
}
