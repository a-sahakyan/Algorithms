using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.Maximum
{
    class Maximum
    {
        /// <summary>
        /// Get Max value
        /// </summary>
        /// <returns></returns>
        public int Max()
        {
            int i = int.Parse(Console.ReadLine());

            if (i > 0)
            {
                return Math.Max(i, Max());
            }
            return 0;
        }
    }
}
