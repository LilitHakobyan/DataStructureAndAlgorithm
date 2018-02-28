using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElement
{
    class Program
    {
        static public int MaxArr(int[] arr, int first, int last)
        {
            if (first < last)
            {
                int mid = (first + last) / 2;
                return Math.Max(MaxArr(arr, first, mid), MaxArr(arr, mid + 1, last));
            }
               return arr[first];
            

        }
        static void Main(string[] args)
        {
        }
    }
}
