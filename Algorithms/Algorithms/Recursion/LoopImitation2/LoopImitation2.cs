using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.LoopImitation2
{
    class LoopImitation2
    {
        public void Imitation2(int i, int n)
        {
            Console.WriteLine(i);
            if (i < n & i % 2 == 0)
            {
                Imitation2(i + 1, n);
            }
            Console.WriteLine(i);
        }
    }
}
