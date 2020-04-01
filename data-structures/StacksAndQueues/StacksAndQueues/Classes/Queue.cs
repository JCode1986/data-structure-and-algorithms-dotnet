using MyStacks.Classes;
using StacksAndQueues.Classes;
using System;

namespace MyQueues
{
    public class MyQueue<T>
    {
        public Node<T> Front { get; set; } = null;
        public Node<T> Rear { get; set; } = null;

        public int Size { get; set; }

        /// <summary>
        /// Adds a new node with that value to the back of the queue 
        /// </summary>
        /// <param name="node"></param>
        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            if (Front == null)
            {
                Front = node;
                Size++;
                return;
            }
            Node<T> current = Front;
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
        public T Dequeue()
        {
            if (Front == null)
            {
                throw new Exception("Nothing to dequeue");
            }
            else
            {
                Node<T> temp = Front;
                Front = temp.Next;
                temp.Next = null;
                Size--;
                return temp.Value;
            }
        }

        /// <summary>
        /// Returns the value of the node located in the front of the queue, without removing it from the queue.
        /// </summary>
        public T Peek()
        {
            return Front != null ? Front.Value : throw new Exception("Nothing to peek from queue.");
        }

        /// <summary>
        /// Returns a boolean if Queue is empty or not.
        /// </summary>
        public bool IsEmpty()
        {
            return Front == null ? true : false;
        }
    }
}