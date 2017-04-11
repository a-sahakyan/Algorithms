using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.Sum
{
    class Sum
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        int sum = 0;
        int k = 0;
        public int RecursionSum()
        {
            if (k < list.Count)
            {
                sum += list[k];
                k++;
                RecursionSum();
            }

            return sum;
        }
    }
}
