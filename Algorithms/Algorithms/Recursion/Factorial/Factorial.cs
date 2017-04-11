using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.Factorial
{
    class Factorial
    {
        public int GetFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * GetFactorial(n - 1);
        }
    }
}
