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

            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {
                int middle = (min + max) / 2;
                return value == array[middle] ? middle : (value < array[middle]) ? max = middle - 1 : max = middle - 1;
            }
            return -1;
        }
    }
}
