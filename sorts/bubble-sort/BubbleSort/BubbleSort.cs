using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    public class MyBubbleSort
    {
        public static int[] BubbleSortSolution(int[] arr)
        {
            int temp;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
