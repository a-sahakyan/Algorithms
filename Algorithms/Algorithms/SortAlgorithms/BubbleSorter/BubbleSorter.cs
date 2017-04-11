using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortAlgorithms.BubbleSorter
{
   static class BubbleSorter
    {
        /// <summary>
        /// Repeatedly compare neighbor pairs and swap if necessary.
        /// </summary>
        public static void BubbleSort()
        {
            int[] arr = new int[] { 2, 5, 6, 8, 8, 1, 4, 7, 9, 3 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])   //arr[i] < arr[j] to sort from large to small
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
