using StacksAndQueues.Classes;
using System;
using System.Collections;


namespace MyStacks.Classes
{
    public class MyStack<T>
    {
        public Node<T> Top { get; set; }

        public int Size { get; set; }

        /// <summary>
        /// Push node on top of the stack
        /// </summary>
        /// <param name="node">Node</param>
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value, Top);
            Top = node;
            Size++;
        }

        /// <summary>
        /// Removes a node from the top of the stack, and returns node's value
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (Top == null)
            {
                throw new Exception("Nothing to pop from the top of stack.");
            }
            else
            {
                Node<T> temp = Top;
                Top = temp.Next;
                temp.Next = null;
                Size--;
                return temp.Value;
            }
        }

        /// <summary>
        /// Returns the value of the node located on top of the stack, without removing it from the stack.
        /// </summary>
        /// <param name="node"></param>
        public T Peek()
        {
            return Top != null ? Top.Value : throw new Exception("Nothing to peek from the top of stack.");
        }

        /// <summary>
        /// Returns a boolean if stack is empty or not.
        /// </summary>
        public bool IsEmpty()
        {
            return Top == null ? true : false;
        }
    }
}