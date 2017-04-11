using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.FromLeftToRight
{
    class FromLeftToRight
    {
        /// <summary>
        /// Get numbers from left to right
        /// </summary>
        public string FLTR(int i)
        {
            if (i < 10)
            {
                return i.ToString();
            }
            return FLTR(i / 10) + " " + i % 10;
        }
    }
}
