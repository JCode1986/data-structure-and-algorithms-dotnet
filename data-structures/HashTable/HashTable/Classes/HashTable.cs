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

            //iterate through every character in string and add to hashedkey
            foreach (char character in key)
            {
                hashedKey += character;
            }

            //return index
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
            Table[hashedkey].AddLast(new Node(key, value));
        }

        /// <summary>
        /// Returns boolean if node exists in hash table
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>boolean</returns>
        public bool contains(string key)
        {
            int hashedkey = Hash(key);
            if (Table[hashedkey] != null)
            {
                foreach(var node in Table[hashedkey])
                {
                    if (node.Key == key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Method that takes in a key as an argument and returns value in the Hash Table
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>string</returns>
        public string Get(string key)
        {
            int hashedkey = Hash(key);
            if (Table[hashedkey] != null)
            {
                foreach(var node in Table[hashedkey])
                {
                    if (node.Key == key)
                    {
                        return node.Value;
                    }
                }
            }
            return "Key not found";
        }
    }
}
