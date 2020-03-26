using System;
using System.Collections.Generic;
using System.Text;

namespace LinkList.Classes
{
    public class Node
    {
        public int Value;
        public Node Next;
        public Node(int data, Node next = null)
        {
            Value = data;
            Next = next;
        }
    }
}
