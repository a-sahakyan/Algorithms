using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.FromOneToN
{
    class FromOneToN
    {
        /// <summary>
        /// Get all numbers from 1 to n.
        /// </summary>
        public string GetFromOneToN(int n)
        {
            if (n == 0) return "0";
            if (n == 1) return "1";
            return GetFromOneToN(n - 1) + " " + n;
        }
    }
}
