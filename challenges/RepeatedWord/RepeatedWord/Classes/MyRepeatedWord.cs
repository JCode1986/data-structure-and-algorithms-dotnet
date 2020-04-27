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
                if(HT.Get("index") == word)
                {
                    return HT.Get("index");
                }
                HT.Add("index", word);
            }
            return null;
        }
    }
}
