using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_095
{
    class Node
    {
        public string info;
        public Node lefftchild;
        public Node rihtchild;

        // Constructor for the node class

        public Node(string i, Node l, Node r)
        {
            info = i;
            lefftchild = l;
            rihtchild = r;
        }
    }
    /* A node class consist of three things, the information, references to the right child, and references to the left child */
    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; /*Initializing ROOT to null*/
        }
        public void Insert(string element)/* Insert a node in the binary search tree */
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null)/* Check if the node to be inserted already inserted or not */
            {
                Console.WriteLine("Duplicate words not allowerd");
                return;
            }
            else /* if the specified node is not present */
            {
                tmp = new Node(element, null, null);
                if (parent == null) /*if the trees is empty */
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    if (string.Compare(element, parent.info) < 0)
                        parent.lefftchild = tmp;
                }
                else
                {
                    parent.rihtchild = tmp;
                }
            }
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            /*This function searchs the currentNode of the specified Node as well as the current node of its parent */
            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.lefftchild;
                else
                    currentNode = currentNode.rihtchild;
            }
        }
        public void inorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr == null)
            {
                inorder(ptr.lefftchild);
                Console.WriteLine(ptr.info + " ");
                inorder(ptr.rihtchild);
            }
        }
        public void preorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.WriteLine(ptr.info + " ");
                preorder(ptr.lefftchild);
                preorder(ptr.rihtchild);
            }
        }
        public void postorder(Node ptr) /* preforms the postorder traversal of the tree*/
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                postorder(ptr.lefftchild);
                postorder(ptr.rihtchild);
                Console.WriteLine(ptr.info + " ");
            }
        }





        internal class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
