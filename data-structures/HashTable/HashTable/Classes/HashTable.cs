using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    public class MyHashTable<T>
    {
        public int Size { get; set; }
        public T[] Table { get; set; }

        /// <summary>
        /// Instantiate hash table with with size of array
        /// </summary>
        /// <param name="size"></param>
        public MyHashTable(int size)
        {
            Size = size;
            Table = new T[size];
        }

        /// <summary>
        /// Hashes every character in string and returns an integer which will be the index
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>int</returns>
        public int Hash(T key)
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
        /// <param name="key">int</param>
        /// <param name="value">string</param>
        public void Add(T key, T value)
        {

        }
    }
}
