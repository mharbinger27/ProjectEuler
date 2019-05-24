using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class _014
    {
        // TITLE: Largest Collatz sequence

        // DESCRIPTION: The following iterative sequence is defined for the set of positive integers:
        //      n → n/2 (n is even)
        //      n → 3n + 1 (n is odd)
        //      Using the rule above and starting with 13, we generate the following sequence:
        //      13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        //      It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. 
        //      Although it has not been proved yet (Collatz Problem), it is thought that all starting 
        //      numbers finish at 1.

        // OBJECTIVE: Which starting number, under one million, produces the longest chain?
        //      NOTE: Once the chain starts the terms are allowed to go above one million.

        public static void DoWork(int limit)
        {
            int startingNumber = 0;
            int changingNumber = 0;
            int chainLength = 0;
            int n;

            Dictionary<int, int> calculatedValues = new Dictionary<int, int>();

            for (int i = 2; i < int.MaxValue; i++)
            {
                startingNumber = i;
                changingNumber = 1;

                for (int j = 1; j < int.MaxValue; j ++)
                {
                    if (calculatedValues.ContainsKey(i))
                    {
                        int existingKey = ;
                        int existingValue = ;
                    }

                    else if (changingNumber == 1)
                    {


                        calculatedValues.Add(i, j);

                        if (j > chainLength)
                        {
                            startingNumber = i;
                            chainLength = j;
                        }
                        break;
                    }
                    else if (changingNumber % 2 == 0)
                    {
                        changingNumber /= 2;
                    }
                    else
                    {
                        changingNumber = (3 * changingNumber) + 1;
                    }
                }
            }

            Console.WriteLine($"001: {startingNumber}");
        }
    }
}
