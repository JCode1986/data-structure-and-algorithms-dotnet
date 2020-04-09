using System;
using System.Collections.Generic;
using Tree;
using Tree.Classes;
using Trees.Classes;
using Xunit;

namespace TreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateAnEmptyBinarySearchTree()
        {
            BinarySearchTree Bst = new BinarySearchTree();
            Assert.Null(Bst.Root);
        }

        [Fact]
        public void CanAddANodeToARootOfABinarySearchTree()
        {
            BinarySearchTree Bst = new BinarySearchTree();
            Bst.Add(1);
            Assert.Equal(1, Bst.Root.Value);
        }

        [Fact]
        public void RootNodeHasDoesNotHaveALeftChild()
        {
            BinarySearchTree Bst = new BinarySearchTree();
            Bst.Add(1);
            Assert.Null(Bst.Root.Left);
        }

        [Fact]
        public void RootNodeHasDoesNotHaveARightChild()
        {
            BinarySearchTree Bst = new BinarySearchTree();
            Bst.Add(1);
            Assert.Null(Bst.Root.Right);
        }

        [Fact]
        public void CanAddNodeToLeftOfRoot()
        {
            BinarySearchTree Bst = new BinarySearchTree();
            Bst.Add(10);
            Bst.Add(5);
            Assert.Equal(5, Bst.Root.Left.Value);
        }

        [Fact]
        public void CanAddNodeToRightOfRoot()
        {
            BinarySearchTree Bst = new BinarySearchTree();
            Bst.Add(10);
            Bst.Add(20);
            Bst.Add(5);
            Assert.Equal(20, Bst.Root.Right.Value);
        }

        [Fact]
        public void CanAddMultipleNodesToABinarySearchTree()
        {
            BinarySearchTree Bst = new BinarySearchTree();
            int[] expected = { 10, 20, 5, 15, 25, 6, 3 };
            foreach (int num in expected)
            {
                Bst.Add(num);
            }
            int[] actual =
            {
                Bst.Root.Value,
                Bst.Root.Right.Value,
                Bst.Root.Left.Value,
                Bst.Root.Right.Left.Value,
                Bst.Root.Right.Right.Value,
                Bst.Root.Left.Right.Value,
                Bst.Root.Left.Left.Value,
            };
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, true)]
        [InlineData(7, false)]
        [InlineData(20, true)]
        [InlineData(999, false)]
        [InlineData(5, true)]
        [InlineData(420, false)]
        public void ReturnsTrueIfRootContainsSpecificValue(int value, bool expected)
        {
            BinarySearchTree Bst = new BinarySearchTree();
            Bst.Add(10);
            Bst.Add(20);
            Bst.Add(5);
            bool actual = Bst.Contains(value);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PreOrderTraversal()
        {
            BinarySearchTree Bst = new BinarySearchTree();
            BinaryTree<int> Bt = new BinaryTree<int>();
            List<int> array = new List<int>() { 10, 20, 5, 15, 25, 6, 3 };
            foreach (int num in array)
            {
                Bst.Add(num);
            }
            List<int> result = new List<int>();
            List<int> expected = new List<int>() { 10, 5, 3, 6, 20, 15, 25 };
            List<int> actual = Bt.PreOrder(Bst.Root, result);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InOrderTraversal()
        {
            BinarySearchTree Bst = new BinarySearchTree();
            BinaryTree<int> Bt = new BinaryTree<int>();
            List<int> array = new List<int>() { 10, 20, 5, 15, 25, 6, 3 };
            foreach (int num in array)
            {
                Bst.Add(num);
            }
            List<int> result = new List<int>();
            List<int> expected = new List<int>() { 3, 5, 6, 10, 15, 20, 25 };
            List<int> actual = Bt.InOrder(Bst.Root, result);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PostOrderTraversal()
        {
            BinarySearchTree Bst = new BinarySearchTree();
            BinaryTree<int> Bt = new BinaryTree<int>();
            List<int> array = new List<int>() { 10, 5, 15, 3, 6, 13, 18 };
            foreach (int num in array)
            {
                Bst.Add(num);
            }
            List<int> result = new List<int>();
            List<int> expected = new List<int>() { 3, 6, 5, 13, 18, 15, 10 };
            List<int> actual = Bt.PostOrder(Bst.Root, result);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanAddNodeToRoot()
        {
            BinaryTree<int> Bt = new BinaryTree<int>();
            Bt.Add(12);
            int actual = Bt.Root.Value;
            Assert.Equal(12, actual);
        }

        [Fact]
        public void CanAddNodeToLeft()
        {
            BinaryTree<int> Bt = new BinaryTree<int>();
            Bt.Add(12);
            Bt.Add(14);
            int[] expected = new int[] { 12, 14 };
            int[] actual = new int[] { Bt.Root.Value, Bt.Root.Left.Value };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanAddNodeToLeftandRight()
        {
            BinaryTree<int> Bt = new BinaryTree<int>();
            Bt.Add(12);
            Bt.Add(14);
            Bt.Add(15);
            int[] expected = new int[] { 12, 14, 15 };
            int[] actual = new int[] { Bt.Root.Value, Bt.Root.Left.Value, Bt.Root.Right.Value };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanAddMultipleNodes()
        {
            BinaryTree<int> Bt = new BinaryTree<int>();
            int[] expected = new int[] { 12, 14, 15, 152, 121, 615, 9145, 2315 };
            foreach (int num in expected)
            {
                Bt.Add(num);
            }

            int[] actual = new int[]
            {
                Bt.Root.Value,
                Bt.Root.Left.Value,
                Bt.Root.Right.Value,
                Bt.Root.Left.Left.Value,
                Bt.Root.Left.Right.Value,
                Bt.Root.Right.Left.Value,
                Bt.Root.Right.Right.Value,
                Bt.Root.Left.Left.Left.Value,
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BreadthFirstTraversal()
        {
            BinaryTree<int> Bt = new BinaryTree<int>();
            List<int> expected = new List<int>() { 10, 5, 15, 3, 6, 13, 18 };
            foreach (int num in expected)
            {
                Bt.Add(num);
            }
            List<int> actual = Bt.BreadthFirst();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnsRootValueIfNoChildrenForFindMaxValueMethod()
        {
            BinaryTree<int> Bt = new BinaryTree<int>();
            Bt.Add(13);
            int actual = Bt.FindMaximumValue(Bt.Root);
            Assert.Equal(13, actual);
        }

        [Fact]
        public void ReturnsMaximumValueInBinaryTree()
        {
            BinaryTree<int> Bt = new BinaryTree<int>();
            List<int> expected = new List<int>() { 10, 5, 15, 3, 420, 6, 13, 18 };
            foreach (int num in expected)
            {
                Bt.Add(num);
            }
            int actual = Bt.FindMaximumValue(Bt.Root);
            Assert.Equal(420, actual);
        }
    }
}
