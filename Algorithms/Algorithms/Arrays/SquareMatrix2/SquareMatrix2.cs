using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays.SquareMatrix2
{
    class SquareMatrix2
    {
        public void Matrix()
        {
            Console.Write("enter dimension count: ");
            int dimension = int.Parse(Console.ReadLine());
            int[,] matrix = new int[dimension, dimension];

            int rows = 0;
            int cols = 0;
            int move = 1;
            for (int i = 1; i <= matrix.Length; i++)
            {
                if (move == 1)
                {
                    if (rows < dimension - 1)
                    {
                        matrix[rows, cols] = i;
                        rows++;
                    }
                    else
                    {
                        move = move >= 4 ? 1 : move + 1;
                    }
                }
                if (move == 2)
                {
                    matrix[rows, cols] = i;
                    cols++;
                    if (i != matrix.Length)
                    {
                        move = move >= 4 ? 1 : move + 1;
                        i++;
                    }
                }
                if (move == 3)
                {
                    if (rows > 0)
                    {
                        matrix[rows, cols] = i;
                        rows--;
                    }
                    else
                    {
                        move = move >= 4 ? 1 : move + 1;
                    }
                }

                if (move == 4)
                {
                    matrix[rows, cols] = i;
                    cols++;
                    move = move >= 4 ? 1 : move + 1;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}   ");
                }
                Console.WriteLine();
            }
        }
    }
}
