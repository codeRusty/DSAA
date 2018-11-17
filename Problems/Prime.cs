using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BackToSuccess.Problems
{
    public class Prime
    {

        public static Queue<int> GetPrime(int from, int till)
        {

            Queue<int> primeNumbers = new Queue<int>();
            int c = 0;
            for (int i = from; i <= till; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                    continue;
                for (int j = from; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                        c++;
                }

                if (c == 1)
                {
                    primeNumbers.Enqueue(i);
                }
                c = 0;
            }

            return primeNumbers;
        }




        public static void Execute(int from, int till)
        {

            Queue<int> primeNumbers = GetPrime(from, till);


            while (primeNumbers.Count > 0)
            {
                Console.WriteLine(primeNumbers.Dequeue());
            }
        }

    }
}
