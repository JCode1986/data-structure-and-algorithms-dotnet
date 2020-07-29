using BubbleSort;
using System;
using Xunit;

namespace XUnitTestBubbleSort
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] a = new int[] { 5, 4, 3, 2, 1 };
            int[] expected = new int[] { 1, 2, 3, 4, 5 };
            int[] actual = MyBubbleSort.BubbleSortSolution(a);
            Assert.Equal(expected, actual);
        }
    }
}
