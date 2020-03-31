using MyStacks.Classes;
using StacksAndQueues.Classes;
using System;

namespace PseudoQueue.Classes
{
    public class MyPseudoQueue
    {
        public MyStack<int> FirstStack { get; set; } = null;
        public MyStack<int> SecondStack { get; set; } = null;

        public void PseudoQueue()
        {
            FirstStack = new MyStack<int>();
            SecondStack = new MyStack<int>();
        }

        /// <summary>
        /// inserts value into the PseudoQueue, using a first-in, first-out approach.
        /// </summary>
        /// <param name="value"></param>
        public MyStack<int> PseudoQueueEnqueue(int value)
        {
            if (FirstStack.IsEmpty())
            {
                FirstStack.Push(value);
            }
            else
            {
                while(!(FirstStack.IsEmpty()))
                {
                    SecondStack.Push(FirstStack.Pop());
                }

                FirstStack.Push(value);

                while (!(SecondStack.IsEmpty()))
                {
                    FirstStack.Push(SecondStack.Pop());
                }
            }
            return FirstStack;
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