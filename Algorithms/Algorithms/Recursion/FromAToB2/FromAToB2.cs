using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.FromAToB2
{
    class FromAToB2
    {
        public string FATB(int a, int b)
        {
            if (a == b)
            {
                return $"{a}";
            }

            return FATB(a, b - 1) + " " + b;
        }
    }
}
