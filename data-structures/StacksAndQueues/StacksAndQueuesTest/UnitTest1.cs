using MyStacks.Classes;
using System;
using Xunit;
using MyQueues;

namespace StacksAndQueuesTest
{
    public class UnitTest1
    {

        [Fact]
        public void CanSuccessfullyPushOnToAStack()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("banana");
            string expected = stack.Top.Value;
            Assert.Equal("banana", expected);
        }

        [Theory]
        [InlineData("banana")]
        [InlineData("orange")]
        [InlineData("plum")]
        [InlineData("chocolate")]
        public void CanSuccessfullyPushMultipleValuesOntoAStack(string value)
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("hello world");
            stack.Push("sike");
            stack.Push(value);
            string actual = $"{stack.Top.Value}, {stack.Top.Next.Value}, {stack.Top.Next.Next.Value}";
            string expected = $"{value}, sike, hello world";
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void CanSuccessfullyPopOffTheStack(int value)
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(10);
            stack.Push(value);
            stack.Pop();
            int expected = stack.Top.Value;
            Assert.Equal(10, expected);
        }

        [Fact]
        public void CanSuccessfullyEmptyAStackAfterMultiplePops()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("10");
            stack.Push("20");
            stack.Push("30");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Assert.Null(stack.Top);
        }

        [Fact]
        public void CanSuccessfullyPeekTheNextItemOnTheStack()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("10");
            stack.Push("20");
            stack.Push("30");
            string expected = stack.Peek();
            Assert.Equal("30", expected);
        }

        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyStack()
        {
            MyStack<string> stack = new MyStack<string>();
            Assert.Null(stack.Top);
        }

        [Fact]
        public void CallingPopOnEmptyStackRaisesException()
        {
            MyStack<string> stack = new MyStack<string>();
            Assert.Throws<Exception>(() => stack.Pop());
        }

        [Fact]
        public void CallingPeekOnEmptyStackRaisesException()
        {
            MyStack<string> stack = new MyStack<string>();
            Assert.Throws<Exception>(() => stack.Peek());
        }

        [Fact]
        public void ReturnsTrueIfStackIsEmpty()
        {
            MyStack<string> stack = new MyStack<string>();
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void ReturnsFalseIfStackIsNotEmpty()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("Bar");
            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void CanSuccessfullyEnqueueIntoAQueue()
        {
            MyQueue<string> queue = new MyQueue<string>();
            queue.Enqueue("Hi");
            string expected = queue.Front.Value;
            Assert.Equal("Hi", expected);
        }

        [Fact]
        public void CanSuccessfullyEnqueueMultipleValuesIntoAQueue()
        {
            MyQueue<string> queue = new MyQueue<string>();
            queue.Enqueue("Are");
            queue.Enqueue("You");
            queue.Enqueue("There");
            string actual = $"{queue.Front.Value}, {queue.Front.Next.Value}, {queue.Front.Next.Next.Value}";
            string expected = "Are, You, There";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanSuccessfullydDequeueOutOfAQueueTheExpectedValue()
        {
            MyQueue<string> queue = new MyQueue<string>();
            queue.Enqueue("Are");
            queue.Enqueue("You");
            queue.Dequeue();
            string expected = queue.Front.Value;
            Assert.Equal("You", expected);
        }

        [Fact]
        public void CanGetTheSizeOfQueue()
        {
            MyQueue<string> queue = new MyQueue<string>();
            queue.Enqueue("Are");
            queue.Enqueue("You");
            queue.Enqueue("23");
            int actual = queue.Size;
            Assert.Equal(3, actual);
        }

        [Fact]
        public void CanSuccessfullyPeekIntoAQueueSeeingTheExpectedValue()
        {
            MyQueue<string> queue = new MyQueue<string>();
            queue.Enqueue("Are");
            queue.Enqueue("You");
            string expected = queue.Peek();
            Assert.Equal("Are", expected);
        }

        [Fact]
        public void CanSuccessfullyEmptyAQueueAfterMultipleDequeues()
        {
            MyQueue<int> queue = new MyQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Dequeue();
            queue.Dequeue();
            var expected = queue.Front;
            Assert.Null(expected);
        }

        [Fact]
        public void CanSuccessfullyInstantiateAnEmptyQueue()
        {
            MyQueue<string> queue = new MyQueue<string>();
            Assert.Null(queue.Front);
        }

        [Fact]
        public void CallingPeekOnEmptyQueueRaisesException()
        {
            MyQueue<string> queue = new MyQueue<string>();
            Assert.Throws<Exception>(() => queue.Peek());
        }

        [Fact]
        public void CallingDequeueOnEmptyQueueRaisesException()
        {
            MyQueue<string> queue = new MyQueue<string>();
            Assert.Throws<Exception>(() => queue.Dequeue());
        }

        [Fact]
        public void ReturnsTrueIfQueueIsEmpty()
        {
            MyQueue<string> queue = new MyQueue<string>();
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void ReturnsFalseIfQueueIsNotEmpty()
        {
            MyQueue<string> queue = new MyQueue<string>();
            queue.Enqueue("Foo");
            Assert.False(queue.IsEmpty());
        }
    }
}
