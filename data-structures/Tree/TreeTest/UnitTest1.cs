using System;
using Tree.Classes;
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
    }
}
