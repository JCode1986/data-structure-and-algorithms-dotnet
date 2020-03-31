using MyStacks.Classes;
using StacksAndQueues.Classes;
using System;

namespace PseudoQueue.Classes
{
    public class PseudoQueue
    {
        public MyStack<int> FirstStack { get; set; }
        public MyStack<int> SecondStack { get; set; }

        public PseudoQueue()
        {
            FirstStack = new MyStack<int>();
            SecondStack = new MyStack<int>();
        }

        /// <summary>
        /// inserts value into the PseudoQueue, using a first-in, first-out approach.
        /// </summary>
        /// <param name="value"></param>
        public void PseudoQueueEnqueue(Node<int> value)
        {

        }

        /// <summary>
        /// extracts a value from the PseudoQueue, using a first-in, first-out approach.
        /// </summary>
        /// <param name="value"></param>
        public void PseudoQueueDenqueue(Node<int> value)
        {

        }
    }
}