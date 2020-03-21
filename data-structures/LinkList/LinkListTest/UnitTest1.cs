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
        
    }
}
