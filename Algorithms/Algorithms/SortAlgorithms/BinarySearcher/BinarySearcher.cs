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
        private static int? BinarySearch(int[] a, int x)
        {
            // Проверить, имеет ли смыл вообще выполнять поиск:
            // - если длина массива равна нулю - искать нечего;
            // - если искомый элемент меньше первого элемента массива, значит, его в массиве нет;
            // - если искомый элемент больше последнего элемента массива, значит, его в массиве нет.
            if ((a.Length == 0) || (x < a[0]) || (x > a[a.Length - 1]))
                return null;

            // Приступить к поиску.
            // Номер первого элемента в массиве.
            int first = 0;
            // Номер элемента массива, СЛЕДУЮЩЕГО за последним
            int last = a.Length;

            // Если просматриваемый участок не пуст, first < last
            while (first < last)
            {
                int mid = first + (last - first) / 2;

                if (x <= a[mid])
                    last = mid;
                else
                    first = mid + 1;
            }

            // Теперь last может указывать на искомый элемент массива.
            if (a[last] == x)
                return last;
            else
                return null;
        }
    }
}
