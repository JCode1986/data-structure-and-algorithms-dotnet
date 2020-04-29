using MyAwesomeTreeIntersection.Classes;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Tree;
using Xunit;
using Xunit.Sdk;

namespace XUnitTestTreeIntersection
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new object[] { "1", "2", "3", "4", "5" }, 
            new object[] { "1", "69", "3", "420", "5" }, 
            new object[] { "1", "5", "3" })]
        [InlineData(new object[] { "69", "2", "420" },
            new object[] { "1", "69", "3", "420", "5" },
            new object[] { "69", "420" })]
        [InlineData(new object[] { "No tree two root" },
            new object[] { },
            new object[] { })]
        [InlineData(new object[] { },
            new object[] { "No tree one root" },
            new object[] { })]
        [InlineData(new object[] { "Not the same values" },
            new object[] { "should return empty list =)" },
            new object[] { })]
        public void WorksAsExpected(object[] valuesOne, object[] valuesTwo, object[] expected)
        {
            MyTreeIntersection TI = new MyTreeIntersection();
            BinaryTree<string> treeOne = new BinaryTree<string>();
            BinaryTree<string> treeTwo = new BinaryTree<string>();
            foreach (string val in valuesOne)
            {
                treeOne.Add(val);
            }
            foreach (string val in valuesTwo)
            {
                treeTwo.Add(val);
            }
            List<string> actual = TI.TreeIntersection(treeOne.Root, treeTwo.Root);
            Assert.Equal(expected, actual);
        }
    }
}
