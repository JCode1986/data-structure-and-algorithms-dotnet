using System;
using System.Collections.Generic;
using System.Text;
using Tree.Classes;
using Trees.Classes;

namespace Tree
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; } = null;
        /// <summary>
        /// Return a list of values in a preorder traversal
        /// </summary>
         public List<T> PreOrder(Node<T> node, List<T> result)
        {
            if (node == null)
            {
                return null;
            }

            result.Add(node.Value);

            if (node.Left != null)
            {
                PreOrder(node.Left, result);
            }
            if (node.Right != null)
            {
                PreOrder(node.Right, result);
            }

            return result;
        }

        /// <summary>
        /// Return a result of values in a PostOrder traversal
        /// </summary>
        public List<T> InOrder(Node<T> node, List<T> result)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Left != null)
            {
                InOrder(node.Left, result);
            }

            result.Add(node.Value);

            if (node.Right != null)
            {
                InOrder(node.Right, result);
            }

            return result;
        }

        /// <summary>
        /// Return a result of values in a InOrder traversal
        /// </summary>
        public List<T> PostOrder(Node<T> node, List<T> result)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Left != null)
            {
                PostOrder(node.Left, result);
            }

            if (node.Right != null)
            {
                PostOrder(node.Right, result);
            }

            result.Add(node.Value);

            return result;
        }
    }
}
