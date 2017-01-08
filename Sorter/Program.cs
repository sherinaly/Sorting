using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = { 2, 1, 3 };
            ArraySorter.BubbleSort(numbers);
            Print(numbers);
            Console.ReadKey();

            //var list = new List<int> {2, 3, 1, 5};

            //var lengths = from x in list
            //              orderby x
            //              select x;

            //foreach (var value in lengths)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.ReadLine();
        }
      
        /// <summary>
        /// Prints the specified arr.
        /// </summary>
        /// <param name="arr">The arr.</param>
        public static void Print(int[] arr)
        {
            foreach (var v in arr)
            {
                Console.Write(v.ToString() + ",");
            }

        }
       

    }

}
