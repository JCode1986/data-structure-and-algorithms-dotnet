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
            Node node = new Node(3);
            Assert.IsType<int>(node.Value);
        }

        [Theory]
        [InlineData(23)]
        [InlineData(420)]
        [InlineData(69)]
        [InlineData(1986)]

        public void CanGetValueOfValuePropertyInNode(int value)
        {
            Node node = new Node(value);
            Assert.Equal(value, node.Value);
        }

        [Theory]
        [InlineData(23)]
        [InlineData(420)]
        [InlineData(69)]
        [InlineData(1986)]

        public void CanChangeAndSetValueOfValuePropertyInNode(int value)
        {
            Node node = new Node(999);
            node.Value = value;
            Assert.Equal(value, node.Value);
        }

        [Theory]
        [InlineData(23, 32)]
        [InlineData(420, 11)]
        [InlineData(69, 96)]
        [InlineData(1986, 9000)]

        public void NextProperyOnNodeCanBeSet(int value1, int value2)
        {
            Node node1 = new Node(value1);

            Node node2 = new Node(value2);
            node1.Next = node2;

            Assert.Equal(node1.Next, node2);
        }

        [Fact]
        public void LinkedListClassHasHeadProperty()
        {
            Linklist linkList = new Linklist();
            Assert.Null(linkList.Head);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(35)]
        [InlineData(21)]
        [InlineData(57)]
        public void CanInsertNewNodeToLinkedListAsHead(int expected)
        {
            Linklist ll = new Linklist();
            ll.Insert(expected);
            Assert.Equal(expected, ll.Head.Value);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(35)]
        [InlineData(21)]
        [InlineData(57)]
        public void CanInsertNewNodeAsHeadInLLThatAlreadyHasNodes(int expected)
        {
            Linklist ll = new Linklist();
            ll.Insert(20);
            ll.Insert(expected);
            Assert.Equal(expected, ll.Head.Value);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(4, true)]
        [InlineData(6, true)]
        public void CanReturnTrueIfValueInLinkedList(int value1, bool expected)
        {
            Linklist ll = new Linklist();
            ll.Insert(value1);
            bool actual = ll.Includes(value1);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(1, false)]
        [InlineData(2, false)]
        [InlineData(4, false)]
        [InlineData(6, false)]
        public void CanReturnFalseIfValueInLinkedList(int value1, bool expected)
        {
            Linklist ll = new Linklist();
            ll.Insert(3);
            ll.Insert(7);
            ll.Insert(9);
            ll.Insert(10);
            bool actual = ll.Includes(value1);
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ReturnsAllNodeValueInStringFormat()
        {
            Linklist ll = new Linklist();
            ll.Insert(3);
            ll.Insert(7);
            ll.Insert(9);
            string actual = ll.ToString();
            string expected = $"{{{ll.Head.Value}}}-->{{{ll.Head.Next.Value}}}-->{{{ll.Head.Next.Next.Value}}}-->NULL";
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ThrowsExceptionIfNoHeadWhenCallingToString()
        {
            Linklist ll = new Linklist();
            Assert.Throws<Exception>(() => ll.ToString());
        }

        [Fact]
        public void ThrowsExceptionIfNoHeadWhenCallingIncludes()
        {
            Linklist ll = new Linklist();
            Assert.Throws<Exception>(() => ll.Includes(3));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void CanAppendToAnEmptyLinkedList(int value)
        {
            Linklist ll = new Linklist();
            ll.Append(value);
            Assert.Equal(value, ll.Head.Value);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void CanAppendToALinkedListWithNodes(int value)
        {
            Linklist ll = new Linklist();
            ll.Insert(20);
            ll.Insert(22);
            ll.Insert(24);
            ll.Append(value);
            int expected = ll.Tail.Value ;
            Assert.Equal(value, expected);
        }

        [Fact]
        public void ThrowsExceptionIfNoHeadWhenCallingInsertBefore()
        {
            Linklist ll = new Linklist();
            Assert.Throws<Exception>(() => ll.InsertBefore(3, 23));
        }

        [Theory]
        [InlineData(1900)]
        [InlineData(1707)]
        [InlineData(54)]
        public void CanInsertANodeBeforeWithOnlyOneNodeInLinkedList(int value)
        {
            Linklist ll = new Linklist();
            ll.Insert(23);
            ll.InsertBefore(23, value);
            int actual = ll.Head.Value;
            int expected = value;
            Assert.Equal(actual, expected);
        }
        [Theory]
        [InlineData(23)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        public void CanInsertBeforeASpecificNodeInTheMiddle(int value)
        {
            Linklist ll = new Linklist();
            ll.Insert(20);
            ll.Insert(40);
            ll.Insert(69);
            ll.Insert(2020);
            ll.Insert(123);
            ll.Insert(456);
            ll.InsertBefore(2020, value);
            int expected = ll.Head.Next.Next.Next.Value;
            Assert.Equal(value, expected);
        }

        [Theory]
        [InlineData(23)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        public void CanInsertBeforeASpecificNodeInTheEndOfALinkedList(int value)
        {
            Linklist ll = new Linklist();
            ll.Append(20);
            ll.Append(40);
            ll.Append(69);
            ll.Append(2020);
            ll.Append(123);
            ll.Append(456);
            ll.InsertBefore(456, value);
            int expected = ll.Head.Next.Next.Next.Next.Next.Value;
            Assert.Equal(value, expected);
        }

        [Fact]
        public void ThrowsExceptionIfNoHeadWhenCallingInsertAfter()
        {
            Linklist ll = new Linklist();
            Assert.Throws<Exception>(() => ll.InsertAfter(3, 23));
        }

        [Theory]
        [InlineData(1900)]
        [InlineData(1707)]
        [InlineData(54)]
        public void CanInsertANodeAfterWithOnlyOneNodeInLinkedList(int value)
        {
            Linklist ll = new Linklist();
            ll.Append(23);
            ll.InsertAfter(23, value);
            int actual = ll.Tail.Value;
            int expected = value;
            Assert.Equal(actual, expected);
        }
        [Theory]
        [InlineData(1900)]
        [InlineData(1707)]
        [InlineData(54)]
        public void CanInsertANodeAfterWithOnlyOneNodeInMiddleOfLinkedList(int value)
        {
            Linklist ll = new Linklist();
            ll.Append(23);
            ll.Append(232);
            ll.Append(2367);
            ll.Append(12364);
            ll.InsertAfter(2367, value);
            int actual = ll.Head.Next.Next.Next.Value;
            Assert.Equal(value, actual);
        }

        [Theory]
        [InlineData(1900)]
        [InlineData(1707)]
        [InlineData(54)]
        public void CanInsertANodeAfterWithOnlyOneNodeInEndOfLinkedList(int value)
        {
            Linklist ll = new Linklist();
            ll.Append(23);
            ll.Append(232);
            ll.Append(2367);
            ll.Append(12367);
            ll.InsertAfter(12367, value);
            int actual = ll.Tail.Value;
            Assert.Equal(value, actual);
        }

    }
}
