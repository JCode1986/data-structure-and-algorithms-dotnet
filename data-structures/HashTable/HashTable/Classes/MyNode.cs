using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    public class Node
    {
        public string Key;
        public string Value;
        public Node Next;
        public Node(string key, string value, Node next = null)
        {
            Key = key;
            Value = value;
            Next = next;
        }
    }
}
