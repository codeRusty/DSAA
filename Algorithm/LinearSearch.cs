using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.Algorithm
{
    public static class LinearSearch
    {
        public static int[] GetInputs(int count)
        {
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Please provide a [only] number to add to the SearchArray");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            return array;
        }

        public static void Execute()
        {
            int index = -1;
            int[] array = GetInputs(10);
            Console.WriteLine("Please provide the number to Search");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine("Found at index : " + index);

        }


    }
}
