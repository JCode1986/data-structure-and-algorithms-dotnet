using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 0)]
        [InlineData(16, 8)]
        [InlineData(20, 10)]
        [InlineData(11, 5)]
        [InlineData(4, 1)]
        [InlineData(99, -1)]

        public void ReturnsMiddleIndexIfTargetNumberIsinMiddle(int target, int expected)
        {
            int[] array = { 2, 4, 6, 8, 10, 11, 12, 14, 16, 18, 20 };
            int actual = Program.ArrayBinarySearch(array, target);
            Assert.Equal(expected, actual);
        }
    }
}
