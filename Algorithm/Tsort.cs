using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.Algorithm
{
    public class Tsort
    {
        /// <summary>
        /// /12/312/312/3123/12/3123/12/3
        /// 
        /// </summary>


        public static void Execute()
        {


            Console.WriteLine("Please enter the max length of Array");

            int max = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[max];

            Console.WriteLine("Please provide the Numbers one at a time");
            for (int i = 0; i < max; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(" ");
            Console.WriteLine("... Sorting ...");
            Console.WriteLine(" ");

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length-1; j++)
                {
                    if (array[i] > array[j])
                    {
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
              
            }

            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(array[i]);
            }

        }

        public static void sort(int[] array)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    var temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }

        }


    }
}
