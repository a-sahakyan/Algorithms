using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.FromRightToLeft
{
    class FromRightToLeft
    {
        /// <summary>
        /// Get numbers from right to left
        /// </summary>
        public int FRTL(int i)
        {
            if (i < 10)
            {
                return i;
            }
            Console.WriteLine(i % 10);
            return FRTL(i / 10);
        }
    }
}
