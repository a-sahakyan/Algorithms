using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.FromOneToN2
{
    class FromOneToN2
    {
        /// <summary>
        /// prints from 1 to n numbers
        /// </summary>
        public void GetFromOneToN(int n)
        {
            if (n != 1)
            {
                GetFromOneToN(n - 1);
            }

            Console.WriteLine(n);
        }
    }
}
