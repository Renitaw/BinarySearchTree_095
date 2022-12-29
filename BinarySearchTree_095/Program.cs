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
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
