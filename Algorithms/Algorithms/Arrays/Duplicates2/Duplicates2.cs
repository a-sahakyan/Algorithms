using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays.Duplicates2
{
    class Duplicates2
    {
        /// <summary>
        /// Finds duplicates from chars input.
        /// </summary>
        public void QuantityOfDuplicatesJugged()
        {
            Random rnd = new Random();
            int count = 0;
            Console.WriteLine("enter quantity of jugged array");
            int n = int.Parse(Console.ReadLine());
            char[][] arr = new char[n][];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("add number of elements");
                int m = int.Parse(Console.ReadLine());
                arr[i] = new char[m];
                int j = 0;
                while (arr[i].Length > j)
                {
                    for (int k = 65; k <= 90; k++)
                    {
                        int result = rnd.Next(65, 91);

                        if (j < m)
                        {
                            arr[i][j] = (char)result;
                            Console.Write(arr[i][j]);
                            j++;
                            if (j == arr[i].Length)
                            {
                                char[] duplicates = new char[j];

                                for (int p = 0; p < arr[i].Length; p++)
                                {
                                    if (!duplicates.Contains(arr[i][p]))
                                    {
                                        int index = p;
                                        count = 1;
                                        int dIndex = 0;
                                        for (int l = ++index; l < arr[i].Length; l++)
                                        {
                                            if (arr[i][p] == arr[i][l])
                                            {
                                                count++;
                                                duplicates[dIndex++] = arr[i][l];
                                            }
                                        }
                                        Console.Write($"    {arr[i][p]} count: {count}");
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
