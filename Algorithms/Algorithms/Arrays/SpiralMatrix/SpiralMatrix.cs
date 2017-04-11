using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays.SpiralMatrix
{
    class SpiralMatrix
    {
        public void Spiral()
        {
            Console.Write("enter number of dimensions: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int rows = 0;
            int cols = 0;
            int step = 1;
            for (int nums = 1; nums <= matrix.Length; nums++)
            {
                matrix[rows, cols] = nums;

                if (step == 1)
                {
                    if (cols < n - 1 && matrix[rows, cols + 1] == 0)
                    {
                        cols++;

                    }
                    else
                    {
                        step = step >= 4 ? 1 : step + 1;
                    }
                }
                if (step == 2)
                {
                    if (rows < n - 1 && matrix[rows + 1, cols] == 0)
                    {
                        rows++;
                    }
                    else
                    {
                        step = step >= 4 ? 1 : step + 1;
                    }
                }
                if (step == 3)
                {
                    if (cols > 0 && matrix[rows, cols - 1] == 0)
                    {
                        cols--;
                    }
                    else
                    {
                        step = step >= 4 ? 1 : step + 1;
                    }
                }

                if (step == 4)
                {
                    if (matrix[rows - 1, cols] == 0 && rows > 0)
                    {
                        rows--;
                    }
                    else
                    {
                        step = step >= 4 ? 1 : step + 1;
                        if (nums != matrix.Length)
                        {
                            nums--;
                        }
                    }

                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
