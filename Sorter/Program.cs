using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    class Program
    {
        // testing bubble sort
        private static void Main(string[] args)
        {
            // a sample array of int to test the functionality of BubbleSort
            int[] numbers = {3,2,-9,0};
            Console.Write("Input: ");
            Print(numbers);
            ArraySorter.BubbleSort(numbers);
            Console.WriteLine();
            Console.Write("Output: ");
            Print(numbers);
            Console.ReadKey();
        }
      
        /// <summary>
        /// Prints the specified arr.
        /// </summary>
        /// <param name="arr">The arr.</param>
        public static void Print(int[] arr)
        {
            
            foreach (var v in arr)
            {
                Console.Write(v.ToString() +"  ");
            }

        }
       

    }

}
