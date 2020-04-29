using HashTable.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace MyAwesomeTreeIntersection.Classes
{
    public class MyTreeIntersection
    {
        public MyHashTable<object> HT = new MyHashTable<object>(20);
        public List<string> result = new List<string>();

        /// <summary>
        /// Method that takes in two tree roots, and returns all common values from both trees
        /// </summary>
        /// <param name="firstNode">Node</param>
        /// <param name="secondNode">Node</param>
        /// <returns>List of strings</returns>
        public List<string> TreeIntersection(MyNode firstNode, MyNode secondNode)
        {
            if (firstNode == null || secondNode == null)
            {
                return result;
            }
            AddtoHash(firstNode);
            CheckHash(secondNode);
            return result;
        }

        /// <summary>
        /// Helper function for tree one to add to hash table
        /// </summary>
        /// <param name="node">Node</param>
        private void AddtoHash(MyNode node)
        {
            if (node == null) return;

            HT.Add(node.Value, "true");

            if (node.Left != null)
            {
                AddtoHash(node.Left);
            }

            if (node.Right != null)
            {
                AddtoHash(node.Right);
            }
        }

        /// <summary>
        /// Helper for tree two to check if tree one node value is in the hash table. If it is, add to result list.
        /// </summary>
        /// <param name="node">Node</param>
        private void CheckHash(MyNode node)
        {
            if (node == null) return;

            if (HT.contains(node.Value))
            {
                result.Add(node.Value);
            }

            if (node.Left != null)
            {
                CheckHash(node.Left);
            }

            if (node.Right != null)
            {
                CheckHash(node.Right);
            }
        }
    }
}
