using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

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
            Stopwatch watch = new Stopwatch();
            watch.Start();

            long changingNumber;
            int longestChain = 0;
            int startingNumberWithLongestChain = 1;
            int recordedChainLength;

            Dictionary<long, int> calculatedValues = new Dictionary<long, int>();

            for (int startingNumber = 2; startingNumber < limit; startingNumber++)
            {
                changingNumber = startingNumber;

                for (int chainLength = 0; chainLength < int.MaxValue; chainLength++)
                {
                    if (changingNumber == 1)
                    {
                        calculatedValues.Add(startingNumber, chainLength);

                        if (chainLength > longestChain)
                        {
                            startingNumberWithLongestChain = startingNumber;
                            longestChain = chainLength;
                        }
                        break;
                    }
                    else if (changingNumber % 2 == 0)
                    {
                        changingNumber /= 2;

                        if (changingNumber < startingNumber)
                        {
                            calculatedValues.TryGetValue(changingNumber, out recordedChainLength);

                            if (recordedChainLength != 0)
                            {
                                int newKey = startingNumber;
                                int newValue = chainLength + recordedChainLength + 1;

                                if (newValue > longestChain)
                                {
                                    longestChain = newValue;
                                    startingNumberWithLongestChain = startingNumber;
                                }

                                calculatedValues.Add(newKey, newValue);
                                break;
                            }
                        }                                               
                    }
                    else
                    {
                        changingNumber = (3 * changingNumber) + 1;
                    }
                }
            }

            watch.Stop();

            Console.WriteLine($"014: {startingNumberWithLongestChain} in {watch.Elapsed}");
        }
    }
}
