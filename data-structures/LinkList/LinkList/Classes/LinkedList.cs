using LinkList.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class Linklist
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        /// <summary>
        /// Inserts a new node to be the new head.
        /// In: int type
        /// Out: void
        /// </summary>
        /// <param name="value"></param>
        public void Insert(int value)
        {
            Head = new Node(value, Head);
        }

        /// <summary>
        /// Returns boolean if node's value is present in linked list
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>

        public bool Includes(int value)
        {
            if (Head == null)
            {
                throw new Exception("No Head Value");
            }
            Node Current = Head;
            while (Current != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            return false;
        }

        /// <summary>
        /// Returns all node values in linked list as a string
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            if (Head == null)
            {
                throw new Exception("No Head Value");
            }
            string nodeValues = "";
            Node Current = Head;
            while (Current != null)
            {
                nodeValues += $"{{{Current.Value}}}-->";
                Current = Current.Next;
            }
            return nodeValues += $"NULL";
        }
    }
}
