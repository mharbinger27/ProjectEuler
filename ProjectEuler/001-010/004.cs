using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class _004
    {
        // TITLE: Largest palindrome product

        // DESCRIPTION: A palindromic number reads the same both ways. The largest 
        // palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

        // OBJECTIVE: Find the largest palindrome made from the product of two 3-digit numbers.

        public static void DoWork(int lessThan)
        {
            int result = 0;
            int largestPalindrome = 0;
            int eightyPercent = (int)(lessThan * 0.8);

            for (int i = (lessThan - 1); i > eightyPercent; i--)       
            {
                for (int j = (lessThan - 1); j > eightyPercent; j--)
                {
                    result = i * j;
                    char[] convertedResult = result.ToString().ToCharArray();
                    if (CheckForPalindrome(convertedResult))
                    {
                        if (result > largestPalindrome)
                        {
                            largestPalindrome = result;
                        }
                    }
                }
            }

            Console.WriteLine($"004: {largestPalindrome}");
        }

        public static bool CheckForPalindrome(char[] inputArray)
        {
            bool isPalindrome = false;

            if (inputArray.Length == 6)
            {
                if (inputArray[0] == inputArray[5])
                {
                    if (inputArray[1] == inputArray[4])
                    {
                        if (inputArray[2] == inputArray[3])
                        {
                            isPalindrome = true;
                        }
                    }
                }
            }

            return isPalindrome;
        }
    }
}
