using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Returns index of int value passed it; Divide and Conquer approach
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>

        public static int ArrayBinarySearch(int[] array, int value)
        {
            //have a start and endpoint
            int min = 0;
            int max = array.Length - 1;

            //loop if start is less than or equal to end 
            while (min <= max)
            {
                //get middle of array
                int middle = (min + max) / 2;

                //return index if we find a match
                if (value == array[middle])
                {
                    return middle;
                }
                //if target value is less than middle value in array, set enpoint to middle - 1
                else if (value < array[middle])
                {
                    max = middle - 1;
                }
                //if target value is greater than middle value in array, set start to middle + 1
                else if (value > array[middle])
                {
                    min = middle + 1;
                }

            }
            return -1;
        }
    }
}