using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.DS
{
    public class BinaryNode
    {
        public BinaryNode(int key)
        {
            Key = key;
            Left = null;
            Right = null;
        }
        public int Key;
        public BinaryNode Left { get; set; }
        public BinaryNode Right { get; set; }
    }

  
}
