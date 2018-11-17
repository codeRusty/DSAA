using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.Problems
{
    public class PancakePackager
    {

        public static int MakePackage(int total)
        {
            int max = 0;

            int[] pack = new int[total];
            for (int x = 1; x < total; x++)
            {
                pack[x] = total % x;
            }
            for (int y = 1; y < pack.Length; y++)
            {
                if (pack[y] > max)
                    max = pack[y];
            }

            return max;
        }


        public static void Execute()
        {


            Console.WriteLine("Please provide the number of cases to Test");
            int noCases = Convert.ToInt32(Console.ReadLine());

            int[] cases = new int[noCases];

            for (int i = 0; i < noCases; i++)
            {
                Console.WriteLine("Please provide the number Pancakes to pack");
                cases[i] = Convert.ToInt32(Console.ReadLine());
            }



            for (int c = 0; c < noCases; c++)
            {
                Console.WriteLine("Package can be made for " + cases[c] + " is " + MakePackage(cases[c]));
            }

        }

    }
}
