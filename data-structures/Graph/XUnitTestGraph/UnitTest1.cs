using Graph.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitTestGraph
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateAnEmptyGraph()
        {
            MyGraph<string> graph = new MyGraph<string>();
            Assert.Equal(0, graph.Size());
        }

        [Fact]
        public void CanAddAVertexToAdjacencyList()
        {
            MyGraph<string> graph = new MyGraph<string>();
            Vertex<string> actual = graph.AddNode("Hello");
            Assert.True(graph.AdjacencyList.ContainsKey(actual));
        }

        [Fact]
        public void CanAddAVerticesToAdjacencyList()
        {
            MyGraph<string> graph = new MyGraph<string>();
            graph.AddNode("Hello");
            graph.AddNode("World");
            Assert.Equal(2, graph.Size());
        }

        [Fact]
        public void CanAddDirectedEdge()
        {
            MyGraph<string> graph = new MyGraph<string>();
            Vertex<string> v1 = graph.AddNode("Hello");
            Vertex<string> v2 = graph.AddNode("World");
            graph.AddDirectedEdge(v1, v2, 50);
            string actual = graph.Print();
            string expected = "Vertices: Hello and World, Weight: 50 --> null";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanGetAllVerticesFromAdjacencyList()
        {
            MyGraph<string> graph = new MyGraph<string>();
            graph.AddNode("Hello");
            graph.AddNode("World");
            graph.AddNode("Foo");
            graph.AddNode("Bar");
            List<Vertex<string>> actual = graph.GettAllVertices();
            Assert.Equal(4, actual.Count);
        }

        [Fact]
        public void CanGetAllEdgesConnectedToAVertex()
        {
            MyGraph<string> graph = new MyGraph<string>();
            Vertex<string> v1 = graph.AddNode("Wa");
            Vertex<string> v2 = graph.AddNode("GA");
            Vertex<string> v3 = graph.AddNode("CA");
            Vertex<string> v4 = graph.AddNode("MI");
            graph.AddDirectedEdge(v1, v2, 50);
            graph.AddDirectedEdge(v1, v4, 100);
            List<int> actual = new List<int>();
            List<int> expected = new List<int>() { 50, 100 };
            foreach(var item in graph.GetNeighbors(v1))
            {
                actual.Add(item.Weight);
            }
            Assert.Equal(expected, actual);
        }
    }
}
