using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_095
{
    class Node
    {
        public string info;
        public Node lefftchild;
        public Node Rightchild;

        // Constructor for the node class

        public Node(string i, Node l, Node r)
        {
            info = i;
            lefftchild = l;
            Rightchild = r;
        }
    }
    /* A node class consist of three things, the information, references to the right child, and references to the left child */
    class BinaryTree
    {
        public Node ROOT;
        public  BinaryTree()
        {
            ROOT = null; /*Initializing ROOT to null*/
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
