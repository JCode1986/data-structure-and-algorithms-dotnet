using System;
using Xunit;
using LLMerge;
using LinkList.Classes;
using LinkedList.Classes;

namespace LLMergeTest
{
    public class UnitTest1
    {

        [Fact]
        public void TestReturnFirstLinkedListIfSecondLinkedListIsNull()
        {
            Linklist LL1 = new Linklist();
            LL1.Append(1);
            LL1.Append(3);
            LL1.Append(2);

            Linklist LL2 = new Linklist();

            Program.LLMerge(LL1, LL2);

            int[] actual = new int[3]
            {
                LL1.Head.Value,
                LL1.Head.Next.Value,
                LL1.Head.Next.Next.Value,
            };

            int[] expected = new int[3] { 1, 3, 2 };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestReturnSecondLinkedListIfFirstLinkedListIsNull()
        {
            Linklist LL2 = new Linklist();
            LL2.Append(1);
            LL2.Append(3);
            LL2.Append(2);

            Linklist LL1 = new Linklist();

            Program.LLMerge(LL1, LL2);

            int[] actual = new int[3]
            {
                LL2.Head.Value,
                LL2.Head.Next.Value,
                LL2.Head.Next.Next.Value,
            };

            int[] expected = new int[3] { 1, 3, 2 };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanChangePointers()
        {
            Linklist LL1 = new Linklist();
            LL1.Append(1);

            Linklist LL2 = new Linklist();
            LL2.Append(2);

            Linklist merge = Program.LLMerge(LL1, LL2);

        }

        [Fact]
        public void ThrowExceptionIfBothLinkedListsAreNull()
        {
            Linklist LL1 = new Linklist();
            Linklist LL2 = new Linklist();

            Assert.Throws<Exception>(() => Program.LLMerge(LL1, LL2));
        }



        [Fact (Skip = "Will work on this")]
        public void TestProperlyZipsLinkedLists()
        {
            Linklist LL1 = new Linklist();
            LL1.Append(1);
            LL1.Append(3);
            LL1.Append(2);

            Linklist LL2 = new Linklist();
            LL2.Append(5);
            LL2.Append(9);
            LL2.Append(4);

            Linklist merge = Program.LLMerge(LL1, LL2);

            int[] actual = new int[6]
            {
                LL1.Head.Value,
                LL1.Head.Next.Value,
                LL1.Head.Next.Next.Value,
                LL1.Head.Next.Next.Next.Value,
                LL1.Head.Next.Next.Next.Next.Value,
                LL1.Head.Next.Next.Next.Next.Next.Value
            };

            int[] expected = new int[3] { 1, 3, 2 };

            Assert.Equal(expected, actual);
        }
    }
}
