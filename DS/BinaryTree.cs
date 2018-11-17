using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.DS
{
    public class BinaryTree
    {
        // Root of Binary Tree 
        BinaryNode root;

        // Constructors 
        public BinaryTree(int key)
        {
            root = new BinaryNode(key);
        }

        BinaryTree()
        {
            root = null;
        }

        public void Insert(int key)
        {
            BinaryNode index = InsertRecursive(root, key);

        }

        public BinaryNode InsertRecursive(BinaryNode curr_node, int key)
        {
            Console.WriteLine("Insert: " + key);
            if (curr_node == null)
            {
                curr_node = new BinaryNode(key);
                return curr_node;
            }

            if (key < curr_node.Key)
            {
                Console.WriteLine("current value: " + curr_node.Key + " Moved Left to Insert");
                curr_node.Left = InsertRecursive(curr_node.Left, key);
            }

            if (key > curr_node.Key)
            {
                Console.WriteLine("current value: " + curr_node.Key + " Moved Right to Insert");
                curr_node.Right = InsertRecursive(curr_node.Right, key);
            }

            return curr_node;
        }

        #region Search

        public void Search(int key)
        {

            BinaryNode index = SearchRecursive(root, key);

            if (index == null)
                Console.WriteLine("Not Found");
            else
                Console.WriteLine("Found: " + index.Key);

        }

        private BinaryNode SearchRecursive(BinaryNode curr_node, int key)
        {

            if (curr_node == null)
                return null;

            Console.WriteLine("Searching: " + curr_node.Key);

            if (curr_node.Key == key)
                return curr_node;
            else if (key < curr_node.Key)
                return SearchRecursive(curr_node.Left, key);
            else if (key > curr_node.Key)
                return SearchRecursive(curr_node.Right, key);

            return curr_node;
        }

        #endregion


        public void Remove(int key)
        {

            BinaryNode node = RemoveRecursive(root, key);

            if (node == null)
                Console.WriteLine("Not Found");
            else
                Console.WriteLine("Found: " + node.Key);

        }

        public BinaryNode RemoveRecursive(BinaryNode curr_node, int key)
        {
            if (curr_node == null)
                return curr_node;

            if (key < curr_node.Key)
                curr_node.Left = RemoveRecursive(curr_node.Left, key);
            else if (key > curr_node.Key)
                curr_node.Right = RemoveRecursive(curr_node.Right, key);
            else if (curr_node.Key == key)
            {
                // IF Leaf Node
                if (curr_node.Left == null && curr_node.Right == null)
                    curr_node = null;
                // If has one node attached
                else if (curr_node.Left == null)
                {
                    return curr_node.Right;
                }
                // If has one node attached
                else if (curr_node.Right == null)
                {
                    return curr_node.Right;
                }
                // If both nodes are filed .find the lowest value in the right subtree;
                else
                {
                    curr_node.Key = FindLeftLowest(curr_node).Key;
                    curr_node.Right = RemoveRecursive(curr_node, curr_node.Key);
                }
            }

            return curr_node;
        }

        private BinaryNode FindLeftLowest(BinaryNode node)
        {
            BinaryNode curr_node = node;

            while (curr_node.Left != null)
                curr_node = curr_node.Left;

            return curr_node;
        }

        public static void Execute()
        {
            BinaryTree tree = new BinaryTree(100);
            tree.Insert(170);
            tree.Insert(10);
            tree.Insert(150);
            tree.Insert(50);
            tree.Insert(40);
            tree.Insert(60);
            tree.Insert(111);
            tree.Insert(24);
            tree.Insert(105);

            tree.Search(40);

            tree.Remove(40);

            tree.Search(40);
        }

    }
}
