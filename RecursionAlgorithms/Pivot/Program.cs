using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivot
{
    class Program
    {
        public static int MinElement_k(int[] a, int first, int end, int k)
        {
            int piIndex = first;
            int first1 = first;
            int last1 = piIndex - 1;
            int first2 = piIndex + 1;
            int last2 = end;

            //////try with recursion
            for (int i = first2; i <= last2; i++)
            {
                if (a[i] < a[piIndex])
                {
                    int temp = a[piIndex];
                    a[piIndex] = a[i];
                    a[i] = a[first2];
                    a[first2] = temp;
                    piIndex++;
                    last1++;
                    first2++;

                }
            }
            ////////
            if (k == piIndex - first + 1)
                return a[piIndex];
            if (k < piIndex - first + 1) return MinElement_k(a, first1, last1, k);
            if (k > piIndex - first + 1) return MinElement_k(a, first2, last2, k - (piIndex - first + 1));
            return 1;
        }
        static void Main(string[] args)
        {
            Random rd = new Random();
            do
            {
                int[] a = new int[rd.Next(8, 25)];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = rd.Next(-999, 1000);
                    Console.WriteLine(a[i] + "\t");

                }
                Console.WriteLine("   ");
                int k = rd.Next(1, a.Length - 1);
                int min = MinElement_k(a, 0, a.Length - 1, k);
                Console.WriteLine("   ");
                Console.WriteLine("\n" + k + "    min=" + min);

            } while (Console.ReadKey().Key == ConsoleKey.End);


        }

    }

  
}
