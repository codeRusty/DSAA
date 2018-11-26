using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.Problems
{
    public class Palindrome
    {
        public static void Execute()
        {
            Console.WriteLine("Enter the string to find the Largest Palindrome");
            string sample = Console.ReadLine();
            string palindrome = GetLargestPalindrome(sample);
            Console.WriteLine("found :" + palindrome);

        }

        private static string GetLargestPalindrome(string test)
        {
            int strLength = test.Length;

            List<string> holder = new List<string>();
            int maxYet = 0;
            for (int i = 0; i < strLength; i++)
            {
                for (int j = strLength - i; j > 1; j--)
                {
                    string toTest = test.Substring(i, j);
                    if (maxYet < toTest.Length)
                        continue;
                    if (IsPalindrome(toTest))
                    {
                        maxYet = toTest.Length;
                        holder.Add(toTest);
                    }
                }
            }

            return holder.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
        }

        private static bool IsPalindrome(string str)
        {
            char[] a = str.ToCharArray();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return a.SequenceEqual(charArray);
        }
    }
}
