using HashTable.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Xunit;
using Xunit.Sdk;

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

        [Theory]
        [InlineData("key")]
        [InlineData("boop")]
        [InlineData("pow")]
        public void ReturnsTrueIfKeyExistsInHashTable(string key)
        {
            MyHashTable<object> table = new MyHashTable<object>(50);
            table.Add(key, "value");
            bool actual = table.contains(key);
            Assert.True(actual);
        }

        [Theory]
        [InlineData("key")]
        [InlineData("boop")]
        [InlineData("pow")]
        public void ReturnsFalseIfKeyExistsInHashTable(string key)
        {
            MyHashTable<object> table = new MyHashTable<object>(50);
            table.Add(key, "value");
            bool actual = table.contains("False!!!!!");
            Assert.False(actual);
        }

        [Theory]
        [InlineData("key", "foo")]
        [InlineData("boop", "bar")]
        [InlineData("pow", "excellent")]
        public void CanProperlyGetAValueIfAKeyExistsInTheHashTable(string key, string value)
        {
            MyHashTable<object> table = new MyHashTable<object>(50);
            table.Add(key, value);
            string actual = table.Get(key);
            Assert.Equal(value, actual);
        }

        [Theory]
        [InlineData("key", "foo")]
        [InlineData("boop", "bar")]
        [InlineData("pow", "excellent")]
        [InlineData("yellow", "blue")]
        [InlineData("red", "black")]
        [InlineData("pink", "brown")]
        [InlineData("green", "white")]
        [InlineData("coffee", "is amazing")]
        public void CanGetValueWithCollisions(string key, string value)
        {
            MyHashTable<object> collisionTable = new MyHashTable<object>(1);
            for (int i = 0; i < 8; i++)
            {
                collisionTable.Add(key, value);
            }
            string actual = collisionTable.Get(key);
            Assert.Equal(value, actual);
        }
    }
}
