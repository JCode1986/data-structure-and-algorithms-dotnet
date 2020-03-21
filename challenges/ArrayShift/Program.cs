using System;

namespace ArrayShift
{
    public class Program
    {
        /// <summary>
        /// Writes all the values in array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>string</returns>
        public static string GetNumbersInArray(int[] arr)
        {
            string str = "Array: { ";
            foreach (int num in arr)
            {
                str += $"{Convert.ToString(num)}, ";
            }
            return $"{str}}}";
        }
        /// <summary>
        /// Method that takes inserts a number in the middle of the array
        /// In: int[], int
        /// Out: int[]
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="num"></param>
        public static string Shift(int[] arr, int num)
        {
            int[] result = new int[arr.Length + 1];
            if (arr.Length == 1)
            {
                result[0] = arr[0];
                result[1] = num;
                return $"Array: {{ {result[0]}, {result[1]} }}";
            }

            //if length of array is even, middle will be 1 less, 1 more otherwise
            int middle = ((arr.Length / 2) % 2 == 1) ? (arr.Length / 2) - 1 : (arr.Length / 2);
            //keep track of index for result array
            int j = 0;

            //first loop from start to mid; inserting values from input array to result array
            for (int i = 0; i < middle; i++)
            {
                result[j] = arr[i];
                j++;
            }

            //insert input number to middle of array and increment by 1
            result[j] = num;
            j++;

            //second loop from mid to end;  
            for (int k = middle; k < arr.Length; k++)
            {
                result[j] = arr[k];
                j++;
            }
            string res = GetNumbersInArray(result);
            return res;
        }

        static void Main(string[] args)
        {
            int[] evenSizedArray = { 2, 4, 6, 8 };
            int[] oddSizedArray = { 2, 4, 6, 8, 10 };
            int[] three = { 1, 2, 3 };
            int dummyNum = 5;
            Console.WriteLine(Shift(three, dummyNum));
        }
    }
}
