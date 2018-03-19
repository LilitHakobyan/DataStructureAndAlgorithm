using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoyAshtarak
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            Stack st = new Stack();
            for (int i = 0; i < 25; i++)
            {
                st.Push(rd.Next(-99,99));
            }
            Console.WriteLine("Count =" + st.Count);
            st.ShowStack();
            st.ShowStack();
        }
    }
}
