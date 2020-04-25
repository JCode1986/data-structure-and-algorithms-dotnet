using HashTable.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitTestHashTable
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateHashTableWithSize()
        {
            MyHashTable<object> table = new MyHashTable<object>(50);
            Assert.Equal(50, table.Size);
        }

        [Theory]
        [InlineData("Hello", 36)]
        [InlineData("Foo", 2)]
        [InlineData("Bar", 37)]
        [InlineData("1234", 7)]
        [InlineData("FooBar", 39)]
        public void CanHashAKey(string key, int expected)
        {
            MyHashTable<object> table = new MyHashTable<object>(41);
            int actual = table.Hash(key);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Hello", "Foo")]
        [InlineData("Bar", "Hello")]
        [InlineData("You", "There?")]
        [InlineData("Key", "Value")]
        [InlineData("Value", "Key")]
        public void CanAddToHashTable(string key, string value)
        {
            MyHashTable<object> table = new MyHashTable<object>(1);
            table.Add(key, value);
            var bucket = table.Table[0].ToList();
            List<string> NodeValue = new List<string>();
            foreach (var node in bucket)
            {
                NodeValue.Add(node.Value);
            }
            Assert.Equal(value, NodeValue[0]);
        }
    }
}
