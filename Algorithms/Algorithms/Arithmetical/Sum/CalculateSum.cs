using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.Sum
{
    class CalculateSum
    {
        /// <summary>
        /// Calculate Sum of array
        /// </summary>
        /// <returns></returns>
        public int GetSum()
        {
            Console.WriteLine("enter the length of the array");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter array");
                arr[i] = int.Parse(Console.ReadLine());
                sum += int.Parse(Console.ReadLine());
            }

            return sum;
        }
    }
}
