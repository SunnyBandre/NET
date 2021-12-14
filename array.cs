using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50585006
{
    class array
    {
        public static void CreateArray()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 45, 32 };
            Console.WriteLine("Array Before sorting");
            foreach (int i in a) 
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

        }
        public static void SortArray()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 45, 32 };
            Array.Sort(a);
            Console.WriteLine("Array After sorting");
            foreach (int i in a)
            {
                Console.Write(" " +  i);
            }
        }
        public static void Main(string[] args)
        {
            CreateArray();
            SortArray();
            Console.ReadLine();
        }
    }
}
