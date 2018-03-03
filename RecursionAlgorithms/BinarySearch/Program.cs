using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
   
    class Program
    {
       
        public static int BS(int[] arr,int first,int last, int k)
        {
            if (last >= first)
            {
                int mid = (first + last) / 2;
                if (k == arr[mid])
                    return arr[mid];
                if (k < arr[mid])
                    return BS(arr, first, mid - 1, k);
                if (k > arr[mid])
                    return BS(arr, mid + 1, last, k);
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int x = 5;
            object ob = x;
            int y =  (int)x;

            int[] arr = {1,5,8,9,78,95,489};
            Console.WriteLine(BS(arr, 0, arr.Length - 1, 5));

          

       
        }
    }
}
