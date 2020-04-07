using FizzBuzzTree.Classes;
using System;
using Tree;
using Tree.Classes;
using Xunit;

namespace FizzBuzzTreeTest
{
    public class UnitTest1
    {
        MyFizzBuzzTree FB = new MyFizzBuzzTree();
        BinarySearchTree BST = new BinarySearchTree();
        BinaryTree<object> BT = new BinaryTree<object>();

        [Fact]
        public void ThrowsExceptionIfRootIsNull()
        {
            Assert.Null(FB.FBTree(BST.Root));
        }

        [Fact]
        public void RootReturnsProperFizzBuzzValue()
        {
            BST.Add(15);
            Assert.Equal("FizzBuzz", );
        }

        /*        [Fact]
                public void CanInstantiateNewNodeWithFBValue()
                {

                    BST.Add(15);
                    BinaryTree<string> actual = FB.FBTree(BST);
                    Assert.Equal("FizzBuzz", actual);
                }*/
    }
}
