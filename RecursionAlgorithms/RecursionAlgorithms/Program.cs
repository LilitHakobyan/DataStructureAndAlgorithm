using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAlgorithms
{
    class Program
    {
        public static class RecursivMethod
        {
            public static int Count { get; set; }

            public static ulong Factorial(uint n)
            {
                if (n < 2) return 1;
                Count++;
                return Factorial(n - 1) * n;
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
