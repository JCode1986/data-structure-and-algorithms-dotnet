using HashTable.Classes;
using System;
using Xunit;

namespace XUnitTestHashTable
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateHashTableWithSize()
        {
            MyHashTable<object> table = new MyHashTable<object>(50);
            Assert.Equal(50, table.Table.Length);
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
    }
}
