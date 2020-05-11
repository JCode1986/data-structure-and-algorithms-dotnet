﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class MyGraph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

        private int _size;

        public MyGraph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        /// <summary>
        /// Adds a vertex to adjacency list, and increments list size by 1
        /// </summary>
        /// <param name="value">T</param>
        /// <returns>node</returns>
        public Vertex<T> AddNode(T value)
        {
            Vertex<T> node = new Vertex<T>(value);
            AdjacencyList.Add(node, new List<Edge<T>>());
            _size++;
            return node;
        }

        /// <summary>
        /// Add edge one way
        /// </summary>
        /// <param name="a">vertex</param>
        /// <param name="b">vertex</param>
        /// <param name="weight">int</param>
        public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AdjacencyList[a].Add(
                new Edge<T>
                {
                    Vertex = b,
                    Weight = weight
                }
            );
        }

        /// <summary>
        /// Add edge two-way
        /// </summary>
        /// <param name="a">vertex</param>
        /// <param name="b">vertex</param>
        /// <param name="weight">int</param>
        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(b, a, weight);
        }

        /// <summary>
        /// Returns a list of vertices
        /// </summary>
        /// <returns>list</returns>
        public List<Vertex<T>> GettAllVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();

            foreach (var vertex in AdjacencyList)
            {
                vertices.Add(vertex.Key);
            }

            return vertices;
        }

        /// <summary>
        /// Get all neighbors from a specific vertex
        /// </summary>
        /// <param name="vertex">vetex</param>
        /// <returns>List of </returns>
        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
            // get all edges connected to a vertex
            return AdjacencyList[vertex];
        }

        /// <summary>
        /// returns size of adjacency list
        /// </summary>
        /// <returns>int</returns>
        public int Size()
        {
            return _size;
        }

        /// <summary>
        /// Prints out all vertices and edges in adjacency list
        /// </summary>
        public string Print()
        {
            string result = "Vertices: ";
            foreach (var vertex in AdjacencyList)
            {
                foreach (var edge in vertex.Value)
                {
                    //Console.Write($"{edge.Vertex.Value}, {edge.Weight} ->");
                    result += $"{vertex.Key.Value} and {edge.Vertex.Value}, Weight: {edge.Weight} --> ";
                }
            }
            result += "null";
            return result;
        }
    }
}
