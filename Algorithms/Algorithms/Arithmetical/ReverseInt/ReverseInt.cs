using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.ReverseInt
{
    class ReverseInt
    {
        /// <summary>
        /// prints the digits of a given decimal number in a reversed order.
        /// </summary>
        public int[] Reverse(int num)
        {
            int length = num.ToString().Length;
            int[] numbers = new int[length];
            int i = 0;
            while (i < length)
            {
                int reminder = num % 10;
                num /= 10;
                numbers[i] = reminder;
                i++;
            }

            return numbers;
        }
    }
}
