using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.Problems
{
    public enum FibonacciSolutionType
    {
        Dynamic,
        Normal
    }

    public class Fibonacci
    {

        public void Execute(FibonacciSolutionType solutionType)
        {
            switch (solutionType)
            {
                case FibonacciSolutionType.Dynamic:
                    GenerateDynamically();
                    break;
                default:
                    break;
            }

        }
        public static void GenerateDynamically()
        {


        }

        public int Fib(int num)
        {

        }

    }
}
