using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays.ReverseArray
{
    class ReverseArray
    {
        /// <summary>
        /// Reverse array
        /// </summary>
        public void Reverse()
        {
            int[] arr = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            int j = 1;
            for (int i = 0; i < arr.Length / 2; i++) //  { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
