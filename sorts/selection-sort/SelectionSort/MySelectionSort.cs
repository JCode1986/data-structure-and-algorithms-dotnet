using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSort
{
    public class MySelectionSort
    {
        /// <summary>
        /// Selection sort algorithm
        /// </summary>
        /// <param name="array">int[]</param>
        /// <returns>int[]</returns>
        public static int[] SSort(int[] array)
        {
            if (array.Length == 1) return array;

            int n = array.Length;

            for (int i = 0; i < n; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex]) minIndex = j;
                }
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
            return array;
        }
    }
}
