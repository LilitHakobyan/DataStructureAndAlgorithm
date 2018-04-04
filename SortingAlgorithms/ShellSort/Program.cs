using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    public static class ShellSort
    {
        public static void sort(int[] arr)
        {
            int increment = arr.Length / 2;
            while (increment >= 1)
            {
                for (int startIndex = 0; startIndex < increment; startIndex++)
                {
                    insertionSort(arr, startIndex, increment);
                }
                increment = increment / 2;
            }
        }

        private static void insertionSort(int[] arr, int startIndex, int increment)
        {
            for (int i = startIndex; i < arr.Length - 1; i = i + increment)
            {
                for (int j = Math.Min(i + increment, arr.Length - 1); j - increment >= 0; j = j - increment)
                {
                    if (arr[j - increment] > arr[j])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j - increment];
                        arr[j - increment] = tmp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 4, 6, 5, 8, 12, 19, 2, 0 };

            ShellSort.sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
