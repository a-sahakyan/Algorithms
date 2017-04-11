using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays.SquareMatrix
{
    class SquareMatrix
    {
        public void Matrix()
        {
            Console.Write("enter dimension count: ");
            int dimension = int.Parse(Console.ReadLine());
            int[,] arr = new int[dimension, dimension];

            int temp = 1;
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                for (int j = i; j <= (dimension - 1) * (dimension - 1); j += dimension - 1)
                {
                    Console.Write($"{j}  ");
                    temp = j;
                }
                Console.WriteLine();
            }
        }
    }
}
