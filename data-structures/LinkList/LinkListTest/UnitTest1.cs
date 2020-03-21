using LinkedList.Classes;
using LinkList.Classes;
using System;
using Xunit;

namespace LinkListTest
{
    public class UnitTest1
    {
        [Fact]
        public void NodeClassHasValueProperty()
        { 
            Node node = new Node();
            Assert.IsType<int>(node.Value);
        }

        [Fact]
        public void CanGetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.Value = 10;
            Assert.Equal(10, node.Value);
        }

        [Fact]
        public void CanChangeAndSetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.Value = 10;
            node.Value = 15;
            Assert.Equal(15, node.Value);
        }

        [Fact]
        public void NodeClassHasNextProperty()
        {
            Node node = new Node();
            Assert.Null(node.Next);
        }

        [Fact]
        public void NextProperyOnNodeCanBeSet()
        {
            Node node = new Node();
            node.Value = 18;

            Node node2 = new Node();
            node.Next = node2;

            Assert.Equal(node.Next, node2);
        }

        [Fact]
        public void LinkedListClassHasHeadProperty()
        {
            Linklist linkList = new Linklist();
            Assert.Null(linkList.Head);
        }

        [Fact]
        public void CanInsertNewNodeToLinkedListAsHead()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            Assert.Equal(10, ll.Head.Value);
        }

        [Fact]
        public void CanInsertNewNodeAsHeadInLLThatAlreadyHasNodes()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            Assert.Equal(20, ll.Head.Value);
        }
    }
}
