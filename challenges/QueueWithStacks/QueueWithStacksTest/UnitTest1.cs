using System;
using Xunit;
using PseudoQueue;
using PseudoQueue.Classes;

namespace QueueWithStacksTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiatePseudoQueue()
        {
            MyPseudoQueue ps = new MyPseudoQueue();
            ps.PseudoQueue();
            bool expected = ps.FirstStack.IsEmpty();
            Assert.True(expected);
        }
        [Fact]
        public void CanInsertNodeIntoAPseudoQueue()
        {
            MyPseudoQueue ps = new MyPseudoQueue();
            ps.PseudoQueue();
            ps.PseudoQueueEnqueue(23);
            int expected = ps.FirstStack.Top.Value;
            Assert.Equal(23, expected);
        }

        [Fact]
        public void CanInsertMulitpleNodesIntoAPseudoQueue()
        {
            MyPseudoQueue ps = new MyPseudoQueue();
            ps.PseudoQueue();
            ps.PseudoQueueEnqueue(20);
            ps.PseudoQueueEnqueue(15);
            ps.PseudoQueueEnqueue(10);
            ps.PseudoQueueEnqueue(5);
            int[] expected = 
            { 
                ps.FirstStack.Top.Next.Next.Next.Value,
                ps.FirstStack.Top.Next.Next.Value,
                ps.FirstStack.Top.Next.Value, 
                ps.FirstStack.Top.Value
            };
            int[] actual = { 5, 10, 15, 20 };
            Assert.Equal(actual, expected);
        }
    }
}
