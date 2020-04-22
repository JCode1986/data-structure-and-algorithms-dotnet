using System;
using Xunit;
using MergeSort.Classes;
using System.Collections;
using System.Collections.Generic;

namespace MergeSortTest
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsArrayIfLengthIsLessThanTwo()
        {
            List<int> list = new List<int>() { 99 };
            List<int> actual = MyMergeSort.MSort(list);
            Assert.Equal(list, actual);
        }
    }
}
