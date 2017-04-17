using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.ConvertToBinary
{
    class ConvertToBinary
    {
        /// <summary>
        /// converts a decimal number to binary one.
        /// </summary>
        public void Convert(int n)
        {
            int temp = n % 2;

            if (n >= 2)
            {
                Convert(n / 2);
            }

            Console.Write(temp);
        }
    }
}
