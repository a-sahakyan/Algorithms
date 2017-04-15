using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Numeral.ConvertToDecimal
{
    class ConvertToDecimal
    {
        /// <summary>
        /// converts a binary number to decimal one.
        /// </summary>
        public void Convert()
        {
            while (true)
            {
                Console.Write("enter binary number: ");
                int binary = int.Parse(Console.ReadLine());
                int length = binary.ToString().Length;
                int result = 0;
                int i = 0;
                while (i < length)
                {
                    int remainder = binary % 10;
                    binary /= 10;
                    result += remainder * (int)Math.Pow(2, i);
                    i++;
                }
                Console.WriteLine(result);
            }
        }
    }
}
