using LinkList.Classes;
using MyStacks.Classes;
using System;

namespace MyQueues
{
    public class MyQueue
    {
        public static Node Front { get; set; }
        public static Node Rear { get; set; }

        public static int Size { get; set; }

        /// <summary>
        /// Adds a new node with that value to the back of the queue 
        /// </summary>
        /// <param name="node"></param>
        public static void Enqueue(int value)
        {
            Node node = new Node(value);
            if (Front == null)
            {
                Front = node;
                return;
            }
            Node current = Front;
            while(current.Next != null)
            {
                current = current.Next;
            }
            Size++;
            current.Next = node;
        }

        /// <summary>
        /// Removes the node from the front of the queue, and returns the node’s value
        /// </summary>
        public static int Dequeue()
        {
            if (Front == null)
            {
                throw new Exception("Nothing to dequeue");
            }
            else
            {
                Node temp = Front;
                Front = temp.Next;
                temp.Next = null;
                Size--;
                return temp.Value;
            }
        }

        /// <summary>
        /// Returns the value of the node located in the front of the queue, without removing it from the queue.
        /// </summary>
        public static int Peek()
        {
            return Front != null ? Front.Value : throw new Exception("Nothing to peek from queue.");
        }

        /// <summary>
        /// Returns a boolean if Queue is empty or not.
        /// </summary>
        public static bool IsEmpty()
        {
            return Front == null ? true : false;
        }
    }
}