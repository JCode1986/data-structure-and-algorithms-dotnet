using SelectionSort;
using System;
using Xunit;

namespace XUnitTestSelectionSort
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 3, 2, 1, 6, 9, 8, 5, 4, 7 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [InlineData(new int[] { 3, 2 }, new int[] { 2, 3 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]

        public void Test1(int[] array, int[] expected)
        {
            int[] actual = MySelectionSort.SSort(array);
            Assert.Equal(expected, actual);
        }
    }
}
