using MyQueues;
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

        /// <summary>
        /// Return a result of values in a breadth birst / level order traversal
        /// </summary>
        /// <param name="node"></param>
        /// <returns>list</returns>
        public List<Node<T>> BreadthFirst()
        {
            if (Root == null)
            {
                return null;
            }

            List<Node<T>> result = new List<Node<T>>();
            MyQueue<Node<T>> Q = new MyQueue<Node<T>>();
            Q.Enqueue(Root);

            while (!Q.IsEmpty())
            {
                Node<T> current = Q.Dequeue();
                result.Add(current);

                if (current.Left != null)
                {
                    Q.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    Q.Enqueue(current.Right);
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public void Add(T value)
        {
            Node<T> node = new Node<T>(value); 
            if (Root == null)
            {
                Root = node;
                return;
            }

            MyQueue<Node<T>> Q = new MyQueue<Node<T>>();
            Q.Enqueue(Root);

            while (!Q.IsEmpty())
            {
                Node<T> current = Q.Dequeue();

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
