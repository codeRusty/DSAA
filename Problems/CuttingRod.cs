using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.Problems
{
    public class CuttingRod
    {
        public static void Execute()
        {
            Console.WriteLine("Please provide the length of the rod in INT!");
            int rodLength = Convert.ToInt32(Console.ReadLine());

            int[] priceArray = new int[] { 12, 23, 34, 45, 46, 56, 67, 78, 84, 85, 92 };

            int[] totalCost = new int[priceArray.Length];

            for (int i = 0; i < rodLength; i++) {
                int currCost = priceArray[i] * rodLength;
                totalCost[i] = currCost;
            }

        }
    }
}
