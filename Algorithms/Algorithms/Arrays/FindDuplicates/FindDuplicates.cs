using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays.FindDuplicates
{
    class FindDuplicates
    {
        /// <summary>
        /// finds the most frequently occurring element in an array.
        /// </summary>
        public void Duplicates()
        {
            int[] arr = new int[] { 1, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 9, 9, 9 };
            List<List<int>> duplicates = new List<List<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                duplicates.Add(new List<int>());
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            int dIndex = 0;
            int count = 1;
            int increaser = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 2)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        if (increaser == 0)
                        {
                            duplicates[dIndex].Add(arr[i]);
                            increaser++;
                        }
                        duplicates[dIndex].Add(arr[i + 1]);
                        increaser++;

                        count++;
                    }
                    else if (arr[i + 1] == arr[i + 2])
                    {
                        Console.WriteLine(count);
                        count = 1;
                        increaser = 0;
                        dIndex++;
                    }
                    else
                    {
                        dIndex++;
                        increaser = 0;
                        duplicates[dIndex].Add(arr[i + 1]);
                        increaser++;
                    }

                }
                else
                {
                    if (arr[i] == arr[i + 1])
                    {
                        if (increaser == 0)
                        {
                            duplicates[dIndex].Add(arr[i]);
                            increaser++;
                        }

                        duplicates[dIndex].Add(arr[i + 1]);
                        increaser++;
                        count++;
                        break;
                    }
                    else
                    {
                        increaser = 0;
                        duplicates[++dIndex].Add(arr[i + 1]);
                        increaser++;
                        break;
                    }
                }
            }
            int max = 0;
            int pos = 0;
            for (int i = duplicates.Count - 1; i >= 0; i--)
            {
                if (duplicates[i].Count == 0)
                {
                    duplicates.Remove(duplicates[i]);
                }
            }

            for (int i = 0; i < duplicates[dIndex].Count; i++)
            {
                if (duplicates[i].Count > max)
                {
                    max = duplicates[i].Count;
                    pos = i;
                }
            }
            Console.Write($"Best ");
            for (int i = 0; i < duplicates[pos].Count; i++)
            {
                Console.Write($"{duplicates[pos][i]} ");
            }
            Console.Write($"count: {max}");
        }
    }
}
