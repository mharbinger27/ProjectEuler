using System;
using System.Collections.Generic;
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

        public static void DoWork()
        {
            int pathCount = 0;
            string binary;

            long limit = (long)Math.Pow(2, 40);

            for (long i = 1048575; i < limit; i++)
            {
                binary = Convert.ToString(i, 2);

                //if (Convert.ToInt32(CountStringOccurrences(binary, "1")) == 20)
                //{
                //    pathCount++;
                //}
            }

            Console.WriteLine($"015: {pathCount}");
        }

        public static int CountStringOccurrences(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }
    }
}
