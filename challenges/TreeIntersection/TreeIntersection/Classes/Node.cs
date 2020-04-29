using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class MyNode
    {
        public string Value;
        public MyNode Left;
        public MyNode Right;
        public MyNode(string data, MyNode left = null, MyNode right = null)
        {
            Value = data;
            Left = left;
            Right = right;
        }
    }
}