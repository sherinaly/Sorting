using System;

namespace Sorter
{
    /// <summary>
    /// Class ArraySorter that implemets BubbleS ort.
    /// </summary>
    public class ArraySorter
    {

        /// <summary>
        /// Bubble sorting.
        /// </summary>
        /// <param name="numbersArrayInts">The numbers array ints.</param>
        public static void BubbleSort(int[] numbersArrayInts)
        {
            var n = numbersArrayInts.Length;
            bool swaped;
            do
            {
                swaped = false;
                for (var i = 1; i <= n - 1; i++)
                {
                    if (numbersArrayInts[i - 1] <= numbersArrayInts[i]) continue;
                    Swap(numbersArrayInts, i - 1, i);
                    swaped = true;
                }
            }
            while (swaped);
        }

        /// <summary>
        /// Swaps two numbers in the given array using the specified locations.
        /// </summary>
        /// <param name="numbers">The numbers.</param>
        /// <param name="idx1">The idx1.</param>
        /// <param name="idx2">The idx2.</param>
        private static void Swap(int[] numbers, int idx1, int idx2)
        {
            var tmp = numbers[idx1];
            numbers[idx1] = numbers[idx2];
            numbers[idx2] = tmp;
        }
    

       
    }
}