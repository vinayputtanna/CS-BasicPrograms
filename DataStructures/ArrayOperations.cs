using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataStructures
{
    class ArrayOperations
    {
        /// <summary>
        /// Array declaration
        /// </summary>
        int[] arr;
        int[] arr1 = new int[10];
        char[] arr2 = new char[80];
        double[] darr = { 1, 2.5, 3.45, 6.78 };
        string[] sarr = new string[] { "hello", "vinay" };

        int[,] mdarr = new int[500,600];

        ArrayList arrl = new ArrayList();

        public void LinearSearch()
        {
            Console.WriteLine("Enter the array size");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the array values");
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the search value");
            int searchValue = int.Parse(Console.ReadLine());
            foreach (int val in arr)
            {
                if (val == searchValue)
                {
                    Console.WriteLine(searchValue + " is present in the array");
                    return;
                }
            }
            Console.WriteLine(searchValue + " is not present in the array");
        }
    }
}
