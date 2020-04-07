using System;
using System.Collections.Generic;
using System.Text;
using Tree;
using Tree.Classes;
using Trees.Classes;

namespace FizzBuzzTree.Classes
{
    public class MyFizzBuzzTree
    {
        
        public void FBTree(Node<int> node)
        {
            BinaryTree<string> BT = new BinaryTree<string>();

            if (node == null)
            {
                return;
            }

            if (node.Left != null)
            {
                FBResults(node.Left);
            }

            if (node.Right != null)
            {
                FBResults(node.Right);
            }
        }

        /// <summary>
        /// Helper function to calculate fizzbuzz
        /// </summary>
        /// <param name="value">int</param>
        /// <returns>string</returns>
        public static string FBResults(Node<int> node)
        {
            string str = "";
            if (node.Value % 3 == 0)
            {
                str += "Fizz";
            }
            if (node.Value % 3 == 0)
            {
                str += "Buzz";
            }
            else
            {
                str += Convert.ToString(node.Value);
            }
            return str;
        }
    }
}
