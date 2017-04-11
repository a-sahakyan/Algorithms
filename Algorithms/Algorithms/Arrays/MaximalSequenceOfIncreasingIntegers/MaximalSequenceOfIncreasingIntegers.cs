using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays.MaximalSequenceOfIncreasingIntegers
{
    class MaximalSequenceOfIncreasingIntegers
    {
        /// <summary>
        /// finds the maximal sequence of increasing elements in an array
        /// </summary>
        public void GetSequence()
        {
            int[] arr = new int[] { 3, 2, 3, 4, 5, 2, 1, 2, 3, 4, 5, 6, 7, 2, 4 };
            List<List<int>> jugged = new List<List<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                jugged.Add(new List<int>());
            }

            int juggedIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != 0)
                {
                    if (arr[i] == arr[i + 1] - 1 || arr[i] == arr[i - 1] + 1)
                    {
                        jugged[juggedIndex].Add(arr[i]);
                    }
                    else
                    {
                        juggedIndex++;
                    }
                    if (i == arr.Length - 2)
                    {
                        break;
                    }
                }
            }

            int maxLength = 0;
            int indexCount = -1;
            for (int i = 0; i < jugged.Count; i++)
            {
                if (jugged[i].Count > maxLength)
                {
                    maxLength = jugged[i].Count;
                    indexCount++;
                }
            }
            Console.Write($"Best elements");
            for (int j = 0; j < jugged[indexCount].Count; j++)
            {
                Console.Write($" {jugged[indexCount][j]}  ");
            }
            Console.Write($"count: {maxLength}");
        }
    }
}
