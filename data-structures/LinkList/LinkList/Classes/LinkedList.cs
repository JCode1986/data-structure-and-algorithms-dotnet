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
            Node node = new Node();
            node.Value = value;
            node.Next = Head;
            Head = node;
        }


        public bool Includes(int value)
        {
            return true;
        }

        public override string ToString()
        {
            return "";

        }
    }
}
