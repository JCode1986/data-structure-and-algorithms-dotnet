using System;
using System.Collections.Generic;
using Xunit;
using InsertionSort.Classes;

namespace InsertionSortTest
{
    public class UnitTest1
    {
        [Fact]
    public void InsertionSortWorksAsExpected()
        {
            List<int> unsortedNumbers = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            List<int> expected = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> actual = MyInsertionSort.ISort(unsortedNumbers);
            Assert.Equal(expected, actual);
        }
    }
}
