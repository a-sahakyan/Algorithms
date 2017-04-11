using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays.SquareMatrix3
{
    class SquareMatrix3
    {
        public void Matrix()
        {
            Console.Write("enter dimension count: ");
            int dimension = int.Parse(Console.ReadLine());
            int[,] matrix = new int[dimension, dimension];

            int rows = dimension - 1;
            int cols = 0;
            int count = 1;
            bool accepted = false;
            int counter = 2;
            for (int i = 1; i <= matrix.Length; i++)
            {
                if (rows == dimension - 1)
                {
                    if (rows <= dimension - 1 && cols <= dimension - 1)
                    {
                        matrix[rows, cols] = i;
                    }
                    if (count >= dimension)
                    {
                        rows = 0;
                        cols = 1;
                        accepted = true;
                    }
                    else if (accepted)
                    {
                        rows = 0;
                        cols = count++;
                        matrix[rows, cols] = i;
                        cols++;
                    }
                    else
                    {
                        rows -= count++;
                        cols = 0;
                    }
                }
                else if (cols == dimension - 1 && accepted)
                {
                    matrix[rows, cols] = i;
                    rows = 0;
                    cols = counter++;
                }
                else
                {
                    matrix[rows, cols] = i;
                    cols++;
                    rows++;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
