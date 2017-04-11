using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays.SquareMatrix4
{
    class SquareMatrix4
    {
        public void Matrix()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("enter dimension count: ");
            int dimension = int.Parse(Console.ReadLine());
            int[,] matrix = new int[dimension, dimension];

            string move = "down";
            int rows = 0;
            int cols = 0;
            int counter = dimension - 1;

            for (int i = 1; i <= matrix.Length; i++)
            {
                if (move == "down")
                {
                    if (rows < dimension - 1 && matrix[rows + 1, cols] == 0)
                    {
                        matrix[rows, cols] = i;
                        rows++;
                    }
                    else
                    {
                        matrix[rows, cols] = i++;
                        if (i >= matrix.Length)
                        {
                            break;
                        }
                        move = "right";
                        cols++;

                    }
                }
                if (move == "right")
                {
                    if (cols < dimension - 1 && matrix[rows, cols + 1] == 0)
                    {
                        matrix[rows, cols] = i;
                        cols++;

                    }
                    else
                    {
                        matrix[rows, cols] = i++;
                        move = "up";
                        rows--;

                    }
                }
                if (move == "up")
                {
                    if (rows > 0 && matrix[rows - 1, cols] == 0)
                    {
                        matrix[rows, cols] = i;
                        rows--;
                    }
                    else
                    {
                        move = "left";
                    }
                }
                if (move == "left")
                {
                    if (cols > 0 && matrix[rows, cols - 1] == 0)
                    {
                        matrix[rows, cols] = i;
                        cols--;
                    }
                    else
                    {
                        matrix[rows, cols] = i;
                        rows++;
                        move = "down";
                    }
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
