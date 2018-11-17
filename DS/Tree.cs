using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.DS
{
    public class Tree
    {
        public Node root = null;

        public Tree(int key)
        {
            root = new Node(key);
        }

        public void Insert(BinaryNode node, int key)
        {
            Queue<BinaryNode> q = new Queue<BinaryNode>();
            q.Enqueue(node);
            while (q.Count > 0)
            {
                node = q.Peek();
                q.Dequeue();

                if (node.Left == null)
                {
                    node.Left = new BinaryNode(key);
                    break;
                }
                else
                    q.Enqueue(node.Left);

                if (node.Right == null)
                {
                    node.Right = new BinaryNode(key);
                    break;
                }
                else
                    q.Enqueue(node.Right);

            }
        }

    }
}
