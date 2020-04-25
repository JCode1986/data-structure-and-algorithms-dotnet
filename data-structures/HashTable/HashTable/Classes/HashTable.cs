using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable.Classes
{
    public class MyHashTable<T>
    {
        public int Size { get; set; }
        public LinkedList<Node>[] Table { get; set; }

        /// <summary>
        /// Instantiate hash table with with size of array
        /// </summary>
        /// <param name="size"></param>
        public MyHashTable(int size)
        {
            Size = size;
            Table = new LinkedList<Node>[size];
        }

        /// <summary>
        /// Hashes every character in string and returns an integer which will be the index
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>int</returns>
        public int Hash(string key)
        {
            int hashedKey = 0;

            foreach (char character in key.ToString())
            {
                hashedKey += Convert.ToInt32(character);
            }
            return (hashedKey * 599) % Table.Length;
        }

        /// <summary>
        /// Adds a key value in the hashtable
        /// </summary>
        /// <param name="key">T type to be hashed</param>
        /// <param name="value">T type</param>
        public void Add(string key, string value)
        {
            int hashedkey = Hash(key);

            //if this bucket is null, set head for collision traversal
            if (Table[hashedkey] == null)
            {
                Table[hashedkey] = new LinkedList<Node>();
            }

            //Inserts node key pair value at the end of the linked list in bucket
            Table[hashedkey].AddFirst(new Node(key, value));
        }
    }
}
