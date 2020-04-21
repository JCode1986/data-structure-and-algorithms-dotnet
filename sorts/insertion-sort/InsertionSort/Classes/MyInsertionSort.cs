using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort.Classes
{
    public class MyInsertionSort
    {

        public static List<int> ISort(List<int> array)
        {
            for(int i = 1; i < array.Count; i++)
            {
                int j = i -1;
                int temp = array[i];

                while(j >= 0 && temp < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            return array;
        }
    }
}
