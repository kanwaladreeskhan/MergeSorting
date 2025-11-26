using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 34, 54, 1, 4, 67, 23, 23, 44, 11 };
            Console.WriteLine("Given Array:");
            Merge merge=new Merge();
            merge.PrintArray(arr);
            merge.sort(arr,0,arr.Length-1);
            Console.WriteLine("\nSorted Array:");
            merge.PrintArray(arr);
        }
    }
}
