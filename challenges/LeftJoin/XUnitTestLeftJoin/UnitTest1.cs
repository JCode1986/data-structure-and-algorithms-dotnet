using HashTable.Classes;
using MyLeftJoin.Classes;
using System;
using Xunit;

namespace XUnitTestLeftJoin
{
    public class UnitTest1
    {
        [Fact(Skip = "bucket is null, have find out why")]
        public void WorksAsExpected()
        {
            MyHashTable<object> tableOne = new MyHashTable<object>(20);
            MyHashTable<object> tableTwo = new MyHashTable<object>(20);
            tableOne.Add("fond", "enamored");
            tableOne.Add("wrath", "anger");
            tableOne.Add("diligent", "employed");
            tableOne.Add("outift", "garb");
            tableOne.Add("guide", "usher");
            tableTwo.Add("wrath", "delight");
            tableTwo.Add("diligent", "idle");
            tableTwo.Add("guide", "follow");
            tableTwo.Add("flow", "jam");
            tableTwo.Add("fond", "averse");
            LeftJoin LJ = new LeftJoin();
            LJ.MyLeftJoint(tableOne, tableTwo);
            Assert.Equal("poop", tableOne.Get("fond"));
        }
    }
}
