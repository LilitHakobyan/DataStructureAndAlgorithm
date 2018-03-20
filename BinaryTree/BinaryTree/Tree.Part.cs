using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public delegate void miBan(string s);

    public class TreeExeption : ApplicationException
    {
        public TreeExeption(string msg) : base(msg)
        {

        }
    }

    public partial class Tree
    {
        protected class Node
        {
            public string value;
            public Node leftChild;
            public Node rightChild;

            public Node(string value, Node left = null, Node right = null)
            {
                this.value = value;
                this.leftChild = left;
                this.rightChild = right;
            }
        }

        protected Tree(Node node)
        {
            root = node;
        }

        protected void CopyTree(Node source, ref Node destination)
        {
            if (source!=null)
            {
                destination = new Node(source.value);
                CopyTree(source.leftChild, ref destination.leftChild);
                CopyTree(source.rightChild, ref destination.rightChild);
            }
        }

        protected void Preorder(Node node, miBan visit)
        {
            if (node!=null)
            {
                visit(node.value);
                Preorder(node.leftChild, visit);
                Preorder(node.rightChild, visit);
            }
        }
        protected void Inorder(Node node, miBan visit)
        {
            if (node != null)
            {
                Preorder(node.leftChild, visit);
                visit(node.value);
                Preorder(node.rightChild, visit);
            }
        }
        protected void Postorder(Node node, miBan visit)
        {
            if (node != null)
            {
                Preorder(node.leftChild, visit);
                Preorder(node.rightChild, visit);
                visit(node.value);
            }
        }
    }
}
