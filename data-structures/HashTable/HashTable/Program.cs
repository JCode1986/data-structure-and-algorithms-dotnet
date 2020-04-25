using HashTable.Classes;
using System;
using System.Linq;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyHashTable<object> hash = new MyHashTable<object>(1);
            hash.Add("poop", "poopy");
            var poop = hash.Table[0].ToList();
            foreach (var i in poop)
            {
                Console.WriteLine(i.Value);
            }
            Console.WriteLine(hash.Table.First());
        }
    }
}
