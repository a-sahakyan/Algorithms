using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.SubsetsSum
{
    class SubsetsSum
    {
        /// <summary>
        /// The program finds those subsets whose sum is zero
        /// </summary>
        public void GetSums()
        {
            int[] arr = new int[] { 3, 1, -7, 35, 22 };
            int sum = 0;
            int subsets = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                int subsetSum = 0;
                int subsetIndex = i;
                int jIndex = i + 2;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (j < arr.Length - 1)
                    {
                        sum = arr[i] + arr[jIndex++];
                    }
                    subsetSum += arr[subsetIndex++];

                    if (sum == 0 || subsetSum == 0)
                    {
                        subsets++;
                    }
                }
            }

            Console.WriteLine(subsets >= 2 ? $"matches count:{--subsets}" : "None match");
        }
    }
}
