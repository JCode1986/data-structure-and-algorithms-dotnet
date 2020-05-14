using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Vertex<T>
    {
        public T Value { get; set; }
        public bool Visited { get; set; } = false;

        public Vertex(T value)
        {
            Value = value;
        }
    }
}
