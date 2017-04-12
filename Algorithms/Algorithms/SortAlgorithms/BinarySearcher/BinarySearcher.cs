using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortAlgorithms.BinarySearcher
{
    static class BinarySearcher
    {
        //Binary search is a fast search algorithm with run-time complexity of Ο(log n). 
        //This search algorithm works on the principle of divide and conquer. 
        //For this algorithm to work properly, the data collection should be in the sorted form.
        /// <summary>
        /// Binary Search
        /// </summary>
        /// <param name="a">Sorted ascending array of type int []</param>
        /// <param name="x">The desired element.</param>
        public static int? BinarySearch(int[] a, int x)
        {
            // Check if it makes sense to do a search.
            // If the length of the array is zero, there is nothing to look for.
            // If the required element is smaller than the first element of the array, then it does not exist in the array.
            // If the required element is greater than the last element of the array, then it does not exist in the array.
            if ((a.Length == 0) || (x < a[0]) || (x > a[a.Length - 1]))
                return null;

            // Proceed to search.
            // The number of the first element in the array.
            int first = 0;
            // length of the array
            int last = a.Length;

            // If the previewed area is not empty, first < last
            while (first < last)
            {
                int mid = first + (last - first) / 2;

                if (x <= a[mid])
                    last = mid;
                else
                    first = mid + 1;
            }

            // Now last can point to the desired element of the array.
            if (a[last] == x)
                return last;
            else
                return null;
        }
    }
}
