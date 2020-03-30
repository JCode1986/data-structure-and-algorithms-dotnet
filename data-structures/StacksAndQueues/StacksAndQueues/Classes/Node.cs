using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Next;
        public Node (T data, Node<T> next = null)
        {
            Value = data;
            Next = next;
        }
    }
}