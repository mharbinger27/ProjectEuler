using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProjectEuler
{
    public static class _015
    {
        // TITLE: Lattice Paths

        // DESCRIPTION: Starting in the top left corner of a 2×2 grid, and 
        //      only being able to move to the right and down, there are exactly 
        //      6 routes to the bottom right corner.

        // OBJECTIVE: How many such routes are there through a 20×20 grid?

        public static void DoWork(int gridSize)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            double pathCount;
            double outputValue;
            double numerator = 0;
            double denomenator = 0;

            for (int i = 1; i <= (gridSize * 2); i++)
            {
                outputValue = Factorial((double)i);

                if (i == gridSize)
                {
                    denomenator = outputValue;
                }
                else if (i == (gridSize * 2))
                {
                    numerator = outputValue;
                }
            }

            denomenator = Math.Pow(denomenator, 2);
            pathCount = numerator / denomenator;

            watch.Stop();

            Console.WriteLine($"015: {pathCount} in {watch.Elapsed}");
        }

        public static double Factorial(double inputValue)
        {
            if (inputValue == 1)
                return 1;
            else
                return inputValue * Factorial(inputValue - 1);
        }
    }
}
