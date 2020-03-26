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
        /// <param name="value">node's value</param>
        public void Insert(int value)
        {
            Head = new Node(value, Head);
        }

        /// <summary>
        /// Returns boolean if node's value is present in linked list
        /// </summary>
        /// <param name="value">node's value</param>
        /// <returns></returns>

        public bool Includes(int value)
        {
            if (Head == null)
            {
                throw new Exception("No Head Value");
            }
            Node current = Head;
            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Returns all node values in linked list as a string
        /// </summary>
        /// <returns>string of all node's value</returns>

        public override string ToString()
        {
            if (Head == null)
            {
                throw new Exception("No Head Value");
            }
            string nodeValues = "";
            Node current = Head;
            while (current != null)
            {
                nodeValues += $"{{{current.Value}}}-->";
                current = current.Next;
            }
            return nodeValues += $"NULL";
        }

        /// <summary>
        /// Appends a node to the end of a linked list
        /// </summary>
        /// <param name="value">node's value</param>
        public void Append(int value)
        {
            if (Head == null)
            {
                Insert(value);
                return;
            }
            Node node = new Node(value);
            Node current = Head;
            while (current != null)
            {
                if (current.Next == null)
                {
                    current.Next = node;
                    node.Next = null;
                    Tail = node;
                }
                current = current.Next;
            }
        }

        /// <summary>
        /// Inserts a node before a specific node
        /// </summary>
        /// <param name="oldVal">node's value</param>
        /// <param name="newVal">new node's value</param>
        public void InsertBefore(int oldVal, int newVal)
        {
            if (Head == null)
            {
                throw new Exception("No Head Value");
            }
            if (Head.Value == oldVal && Head.Next == null)
            {
                Insert(newVal);
            }
            Node node = new Node(newVal);
            Node current = Head;
            while (current.Next != null && current != null)
            {
                if (current.Next.Value == oldVal)
                {
                    Node temp = current.Next;
                    current.Next = node;
                    node.Next = temp;
                    temp.Next = null;
                }
                if (current.Value == oldVal)
                {
                    Node temp = current.Next;
                    current.Next = node;
                    node.Next = temp;
                }
                current = current.Next;
            }
        }

        /// <summary>
        /// Inserts a node after a specific
        /// </summary>
        /// <param name="oldVal">node's value</param>
        /// <param name="newVal">new node's value</param>

        public void InsertAfter(int oldVal, int newVal)
        {
            if (Head == null)
            {
                throw new Exception("No Head Value");
            }
            if (Head.Value == oldVal && Head.Next == null)
            {
                Append(newVal);
            }
            Includes(newVal);
            Node current = Head;
            Node node = new Node(newVal);
            while (current != null)
            {
                if (current.Value == oldVal)
                {
                    Node temp = current.Next;
                    current.Next = node;
                    node.Next = temp;
                }
                if (Tail.Value == oldVal)
                {
                    Append(newVal);
                }
                current = current.Next;
            }
        }

        /// <summary>
        /// Return the node’s value that is k from the end of the linked list
        /// </summary>
        /// <param name="k">number that is k away from the end of a linked</param>
        public int KthFromEnd(int k)
        {
            if (k == 0)
            {
                return Tail.Value;
            }
            int counter = 0;
            Node current = Head;
            Node temp = Head;
            while (current.Next != null)
            {
                if (counter >= k)
                {
                    temp = temp.Next;
                }
                counter++;
                current = current.Next;
            }
            return counter < k ? throw new Exception("Argument is greater than linked list") : temp.Value;
        }
    }
}
