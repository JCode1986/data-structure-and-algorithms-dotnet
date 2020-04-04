using System;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node<int> Root { get; set; } = null;

        /// <summary>
        /// Adds a node to a binary search tree
        /// </summary>
        /// <param name="value"></param>
        public void Add(int value)
        {
            Node<int> node = new Node<int>(value);
            if (Root == null)
            {
                Root = node;
                return;
            }

            Node<int> current = Root;

            while (true)
            {
                if (value < current.Value)
                {
                    if (current.Left == null)
                    {
                        current.Left = node;
                        return;
                    }
                    current = current.Left;
                }
                if (value > current.Value)
                {
                    if (current.Right == null)
                    {
                        current.Right = node;
                        return;
                    }
                    current = current.Right;
                }
            }
        }

        public bool Contains(int value)
        {
            Node<int> current = Root;
            while (current != null)
            {
                if (value == current.Value)
                {
                    return true;
                }
                if (value < current.Value)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return false;
        }
    }
}
