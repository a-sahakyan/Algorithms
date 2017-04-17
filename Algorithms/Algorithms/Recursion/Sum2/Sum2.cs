using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.Sum2
{
    class Sum2
    {
        public int RecSum(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n + RecSum(n - 1);
        }
    }
}
