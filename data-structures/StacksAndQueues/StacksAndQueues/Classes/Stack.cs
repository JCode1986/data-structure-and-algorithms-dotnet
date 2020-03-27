using LinkList.Classes;
using System;
using System.Collections;

namespace MyStacks.Classes
{
    public class MyStack
    {
        public static Node Top { get; set; }

        public static int Size { get; set; }

        /// <summary>
        /// Push node on top of the stack
        /// </summary>
        /// <param name="node">Node</param>
        public static void Push(int value)
        {
            Node node = new Node(value, Top);
            Top = node;
            Size++;
        }

        /// <summary>
        /// Removes a node from the top of the stack, and returns node's value
        /// </summary>
        /// <returns></returns>
        public static int Pop()
        {
            if (Top != null)
            {
                Node temp = Top;
                Top = temp.Next;
                temp.Next = null;
                Size--;
                return temp.Value;
            }
            throw new Exception("Nothing to pop from the top of stack.");
        }

        /// <summary>
        /// Returns the value of the node located on top of the stack, without removing it from the stack.
        /// </summary>
        /// <param name="node"></param>
        public static int Peek()
        {
            return Top != null ? Top.Value : throw new Exception("Nothing to peek from the top of stack.");
        }

        /// <summary>
        /// Returns a boolean if stack is empty or not.
        /// </summary>
        public static bool IsEmpty()
        {
            return Top == null ? true : false;
        }
    }
}