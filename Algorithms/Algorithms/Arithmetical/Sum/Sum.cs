using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.Sum
{
    class Sum
    {
        /// <summary>
        /// Calculate Sum
        /// </summary>
        /// <returns></returns>
        public int GetSum()
        {
            List<int> list = new List<int>
            {
                1,2,3,4,5,6
            };
            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }

            return sum;
        }
    }
}
