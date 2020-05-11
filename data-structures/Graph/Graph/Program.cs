using Graph.Classes;
using System;
using System.Collections.Generic;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyGraph<string> graph = new MyGraph<string>();
            Vertex<string> v1 = graph.AddNode("Wa");
            Vertex<string> v2 = graph.AddNode("GA");
            Vertex<string> v3 = graph.AddNode("CA");
            Vertex<string> v4 = graph.AddNode("MI");
            graph.AddDirectedEdge(v1, v2, 50);
            graph.AddDirectedEdge(v1, v4, 100);
            List<Edge<string>> actual = graph.GetNeighbors(v1);
            foreach (var item in actual)
            {
                Console.WriteLine(item.Weight);
            };
        }
    }
}
