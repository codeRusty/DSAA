using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.DS
{
    public class Node
    {
        public Node(int key)
        {
            Key = key;
            Nodes = new List<Node>();
        }
        public List<Node> Nodes;
        public int Key;

    }
}
