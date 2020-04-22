using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;

namespace MergeSort.Classes
{
    public class MyMergeSort
    {

        public static List<int> MSort(List<int> array)
        {
            int n = array.Count();
            if (n <= 1)
            {
                return array;
            }

            int mid = n / 2;
            var left = array.Take(mid).ToList();
            var right = array.Skip(mid).Take(mid).ToList();

            MSort(left);
            MSort(right);
            MergeSort(left, right, array);

            return array;
        }

    public static void MergeSort(List<int> left, List<int> right, List<int> array)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Count && j < right.Count)
            {
                if(left[i] <= right[j])
                {
                    array[k] = left[i];
                    i += 1;
                }
                else
                {
                    array[k] = right[j];
                    j += 1;
                }
                k += 1;
            }

            if(i == left.Count)
            {
                while(j < right.Count)
                {
                    array[k] = right[j];
                    j += 1;
                    k += 1;
                }
            }
            else
            {
                while(i < left.Count)
                {
                    array[k] = left[i];
                    i += 1;
                    k += 1;
                }
            }
        }
    }
}
