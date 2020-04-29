using System;
using System.Collections;
using System.Collections.Generic;
using Trees.Classes;

namespace Tree
{
    public class BinaryTree<T>
    {
        public MyNode Root { get; set; } = null;

        /// <summary>
        /// Adds nodes in level order
        /// </summary>
        /// <param name="value">string</param>
        public void Add(string value)
        {
            MyNode node = new MyNode(value);
            if (Root == null)
            {
                Root = node;
                return;
            }

            Queue Q = new Queue();
            Q.Enqueue(Root);

            while (Q.Count > 0)
            {
                MyNode current = (MyNode)Q.Dequeue();

                if (current.Left != null)
                {
                    Q.Enqueue(current.Left);
                }
                else
                {
                    current.Left = node;
                    return;
                }

                if (current.Right != null)
                {
                    Q.Enqueue(current.Right);
                }
                else
                {
                    current.Right = node;
                    return;
                }
            }
        }
    }
}