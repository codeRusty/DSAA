using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.Algorithm
{
    public class BinarySearch
    {
        public static int[] GetInputs(int count)
        {
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                //Console.WriteLine("Please provide a [only] number to add to the SearchArray");
                array[i] = i * 3;
            }

            return array;
        }

        public static void Execute()
        {
            int index = -1;
            int[] array = GetInputs(10);
            Console.WriteLine("Please provide the number to Search using Binary Search");

            int number = Convert.ToInt32(Console.ReadLine());
            index = Operate(array, number);


            Console.WriteLine("Found at index : " + index);

        }

        public static int Operate(int[] array, int number)
        {
            int returnValue = -1;
            int curr_index = array.Length / 2;
            if (array[curr_index] == number)
                returnValue = curr_index;
            else if (array[curr_index] > number)
                returnValue = Operate(array.Take(curr_index).ToArray(), number);
            else if (array[curr_index] < number)
                returnValue = Operate(array.Skip(curr_index).ToArray(), number);
            return returnValue;
        }
    }
}
