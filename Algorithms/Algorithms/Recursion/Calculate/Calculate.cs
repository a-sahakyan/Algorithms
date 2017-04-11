using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.Calculate
{
    class Calculate
    {
        /// <summary>
        /// Calculate numberCalculate
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int CalculateNumber(int i)
        {
            if (i < 10)
            {
                return i;
            }
            return i % 10 + CalculateNumber(i / 10);
        }
    }
}
