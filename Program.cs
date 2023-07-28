using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConAppShellSort
{
    internal class Program
    {
        public static void ShellSort(int[] array)
        {
            int n = array.Length;
            int gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j = i;
                    while (j >= gap && array[j - gap] > temp)
                    {
                        array[j] = array[j - gap];
                        j -= gap;


                    }
                    array[j] = temp;
                }
                gap /= 2;
            }
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  "); // Changed WriteLine to Write to print on the same line.
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 7, 4, 5, 2, 45, 78, 90, 12 };
            Console.WriteLine("print array without sort");
            Print(arr);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ShellSort(arr);
            sw.Stop();
            Console.WriteLine("After shell sort");
            Print(arr);
            Console.WriteLine($"ArraySize {arr.Length} Time Taken {sw.Elapsed.TotalMilliseconds} millideconds");
            Console.ReadKey();
        }
    }
}