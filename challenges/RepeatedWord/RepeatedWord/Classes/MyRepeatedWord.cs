using HashTable.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatedWord.Classes
{
    public class MyRepeatedWord
    {

        public MyHashTable<object> HT = new MyHashTable<object>(20);

        /// <summary>
        /// Method that returns first repeated word in sentence/paragraph.
        /// </summary>
        /// <param name="sentence">string</param>
        /// <returns>string</returns>
        public string MyWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            foreach(string word in words)
            {
                if(HT.Get(word) == "value here")
                {
                    return word;
                }
                HT.Add(word, "value here");
            }
            return null;
        }
    }
}
