using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        /// <summary>
        /// prints a matrix of numbers
        /// </summary>
        public void GetMatrix()
        {
            Console.Write("dimension: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = i + 1; j <= num + i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
