using System;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node<int> Root { get; set; } = null;
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
    }
}
