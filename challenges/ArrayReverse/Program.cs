using System;
using System.Collections;

namespace ArrayReverse
{
    class Program
    {
        public static string GetNumbersInArray(int[] arr)
        {
            string str = "Array: { ";
            foreach (int num in arr)
            {
                str += $"{Convert.ToString(num)}, ";
            }
            return $"{str}}}";
        }

        public static void GetUserInputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Index {i}: Enter element: ");
                array[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(GetNumbersInArray(array));
            }
        }

        public static string ArrayReverse()
        {
            Console.WriteLine("Enter array size: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] arrayInput = new int[arraySize];
            GetUserInputArray(arrayInput);
            int[] result = new int[arraySize];
            int j = 0;
            for (int i = arrayInput.Length - 1; i >= 0; i--)
            {
                result[j] = arrayInput[i];
                j++;
            }
            return $"\nInput-->{GetNumbersInArray(arrayInput)}\nOutput-->{GetNumbersInArray(result)}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ArrayReverse());
        }
    }
}