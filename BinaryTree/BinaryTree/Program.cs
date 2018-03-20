using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void ShowValues(string s)
        {
            Console.WriteLine(s);
        }
        
        static void Main(string[] args)
        {
            Tree tree2 = new Tree("lalala");
            Tree tree1 = new Tree();

           // Console.WriteLine(tree1.GetRootValue());

            tree1.RootData = "Tom";
            tree1.AttachLeft("John");
            tree1.AttachRight("Merry");
            tree1.PreorderTraverse(ShowValues);

          



            
        }
    }
}
