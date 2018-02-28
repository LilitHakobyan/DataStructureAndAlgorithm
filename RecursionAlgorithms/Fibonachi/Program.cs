using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    class Program
    {
        private static int count = 0;
        public static ulong Fib(uint n)
        {
            count++;
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);

        }
        static void Main(string[] args)
        {
            do
            {
                uint n = uint.Parse(Console.ReadLine());
                Console.WriteLine(n + " th Item=" + Fib(n) +
                                  "\t Call Count" + count);


            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
