using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoyAshtarak
{
   public class Node
    {
        public int Val { set; get; }       
        public Node Next { set; get; }

        public Node(int a)
        {
            Val = a;
            Next = null;
        }    

    }
}
