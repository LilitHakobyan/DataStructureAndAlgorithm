using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoyAshtarak
{
   public class Stack
   {
        private Node first;
        public int Count { get; private set; }

       public void Push(int a)
       {
            Node nd = new Node(a);
           Count++;
           if (first == null)
           {
               first = nd;
           }
           else
           {
               Node temp = first;
               while (temp.Next!=null)
               {
                   temp = temp.Next;
               }
               temp.Next = nd;
           }
       }

       public void ShowStack()
       {
           Node temp = first;
           if (temp == null)
           {
               Console.WriteLine("stack is empty");
           }
           else
           {
               while (temp != null)
               {
                   Console.Write(temp.Val+"\t");
                   temp = temp.Next;
               }              
           }
       }
   }
}
