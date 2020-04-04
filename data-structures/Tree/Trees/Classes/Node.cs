using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Left;
        public Node<T> Right;
        public Node(T data, Node<T> left = null, Node<T> right = null)
        {
            Value = data;
            Left = left;
            Right = right;
        }
    }
}
