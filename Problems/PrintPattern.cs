using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.Problems
{
    public class PrintPattern
    {
        public static void Execute() 
        {

            for (int i = 5; i >=1; i--)
            {
                for (int j = 5; j >=1; j--)
                {
                    if (i <= j)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
