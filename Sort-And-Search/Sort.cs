using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_And_Search
{
    /// <summary>
    /// The sorting algorithms implemented.
    /// </summary>
    internal class Sort
    {
        /// <summary>
        /// This function takes in a list and uses the Bubble Sort algorithm to sort it.
        /// Bubble Sort moves through each element of the list and compares the two elements,
        /// swapping the elements if need be. This will be repeated until the list is sorted
        /// and no more swaps are made.
        /// 
        /// Runtime:
        /// Space:
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>A sorted list of elements</returns>
        public static List<int> BubbleSort(List<int> numbers)
        {
            int listLength = numbers.Count;
            bool swapped = false;

            //TODO - Optimize BubbleSort algorithm

            do
            {
                swapped = false;
                for (int i = 1; i < listLength; i++)
                {
                    if (numbers[i - 1] > numbers[i])
                    {
                        Swap(numbers, i - 1, i);
                        swapped = true;
                    }
                }
            }while (swapped != false);

            return numbers;
        }

        /// <summary>
        /// This function will swap two elements in a list.
        /// 
        /// Runtime:
        /// Space:
        /// </summary>
        /// <param name="numbers">A list of elements</param>
        /// <param name="x">Element of the list to be swapped</param>
        /// <param name="y">Element of the list to be swapped</param>
        private static void Swap(List<int> numbers, int x, int y)
        {
            int temp = numbers[x];
            numbers[x] = numbers[y];
            numbers[y] = temp;
        }
    }
}
