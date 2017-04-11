using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays.QuantityOfDuplicates
{
    class QuantityOfDuplicates
    {
        public void Quantity()
        {
            char[] arr = new char[] { 'a', 'a', 'b', 'c', 'c', 'c', 'c', 'l', 'v', 'l', 'c' };
            char[] duplicates = new char[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (!duplicates.Contains(arr[i]))
                {
                    int index = i;
                    int count = 1;
                    int dIndex = 0;
                    for (int j = ++index; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                            duplicates[dIndex++] = arr[j];
                        }
                    }
                    Console.WriteLine($"{arr[i]} count: {count}");
                }
            }
        }
    }
}
