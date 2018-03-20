using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
   

    public partial class Tree
    {

        public bool IsEmpty => root == null;
        private Node root;

        public Tree()
        {
            root = null;
        }

        public Tree(string s)
        {
            try
            {
                this.root = new Node(s);
            }
            catch
            { 
              throw new TreeExeption("Cannot Alocate memory");
            }
        }

        public string RootData
        {
            get
            {
                if (root==null)
                {
                    throw new Exception("tree is empty");
                }
                return this.root.value;
            }
            set
            {
                if (this.root == null)
                {
                    root = new Node(value);
                }
                else
                    this.root.value = value;
            }
        }

        public void AttachLeftSutTree(Tree left)
        {
            if (IsEmpty)
            {
                throw new Exception("Anna");
            }
            if (root.leftChild!=null)
            {
                throw new Exception("Anna");
            }
            Tree temp = new Tree(left); 
            root.leftChild = new Node(temp.root.value, temp.root.leftChild, temp.root.rightChild);
        }
        public void AttachRightSutTree(Tree right)
        {
            if (IsEmpty)
            {
                throw new Exception("Anna");
            }
            if (root.leftChild != null)
            {
                throw new Exception("Anna");
            }
            Tree temp = new Tree(right);
            root.rightChild = new Node(temp.root.value, temp.root.leftChild, temp.root.rightChild);
        }

        public void AttachLeft(string str)
        {
            if (this.root==null)
            {
                throw new TreeExeption("Empty Tree");
            }

            if(this.root.leftChild!=null)
            {
                throw new TreeExeption("Tree Exists");
            }
            
            this.root.leftChild = new Node(str);
        }

        public void AttachRight(string str)
        {
            if (this.root == null)
            {
                throw new TreeExeption("Empty Tree");
            }

            if (this.root.rightChild != null)
            {
                throw new TreeExeption("Tree Exists");
            }

            this.root.rightChild = new Node(str);
        }

        protected Node GetLeftChild()
        {
            if (this.root == null)
            {
                throw new TreeExeption("Empty Tree");
            }

            if (this.root.leftChild == null)
            {
                throw new TreeExeption("Empty Tree");
            }

            return root.leftChild;
        }

        protected  Node GetRightChild()
        {
            if (this.root == null)
            {
                throw new TreeExeption("Empty Tree");
            }

            if (this.root.rightChild == null)
            {
                throw new TreeExeption("Empty Tree");
            }

            return root.rightChild;
        }

        public void PreorderTraverse(miBan visit)
        {
            Preorder(this.root, visit);
        }
        public Tree(string s,Tree left,Tree right)
        {
            root = new Node(s, left.root, right.root);
        }

        public Tree(Tree tree)
        {
            if (tree.IsEmpty)
            {
               this.root = null;
            }
           CopyTree(tree.root, ref this.root);
        }
        
    }
}
