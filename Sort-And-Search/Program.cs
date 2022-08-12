/*
 * Author: Jackson A. Kelley
 * Date: August 10, 2022
 * 
 * Summary: This program accepts an unsorted list of data from the user
 *          then sorts the data and allows the user to search for
 *          specific elements within the list. Both Bubble Sort and Merge Sort
 *          will be implemented for sorting the list, and Binary Search will be
 *          used for the search.
*/
namespace Sort_And_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string[] temp;
            List<int> unsortedList = new List<int>();
            List<int> sortedList = new List<int>();
            Console.WriteLine("Please enter the numbers you'd like to sort:");
            input = Console.ReadLine();
            temp = input.Split(" ");

            //Accepting input from the user for creating the list.
            // TODO - implement a menu for the user to choose whether to create, print, sort, or search.
            foreach (string num in temp)
            {
                int number;
                bool test = false;

                test = int.TryParse(num, out number);
                if (test)
                {
                    unsortedList.Add(number);
                    Console.WriteLine($"{number} was successfully added to the list.");
                }
                else
                {
                    Console.WriteLine($"Error! {num} is invalid and was not added to the list of integers.");
                }
            }

            sortedList = Sort.BubbleSort(unsortedList);

            //Prints out the sorted list
            // TODO - Create a print function for the user to choose.
            Console.WriteLine("Sorted:");
            foreach (int number in sortedList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");
        }
    }
}