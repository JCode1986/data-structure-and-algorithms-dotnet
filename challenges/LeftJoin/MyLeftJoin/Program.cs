using HashTable.Classes;
using MyLeftJoin.Classes;
using System;

namespace MyLeftJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
        }
    }
}
