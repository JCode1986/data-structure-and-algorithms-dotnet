using HashTable.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeftJoin.Classes
{
    public class LeftJoin
    {
        public MyHashTable<object> MyLeftJoint(MyHashTable<object> H1, MyHashTable<object> H2)
        {
            foreach(var bucket in H1.Table)
            {
                if (bucket != null)
                {
                    foreach(var node in bucket)
                    {
                        if (H2.contains(node.Key))
                        {
                            H1.Add(node.Key, H2.Get(node.Key));
                        }
                        Node newNode = new Node(null, null);
                        H1.Add(newNode.Key, newNode.Value);
                    }
                }
            }
            return H1;
        }
    }
}
