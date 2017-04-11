using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.Maximum
{
    class Maximum
    {
        /// <summary>
        /// Get Max Value
        /// </summary>
        /// <returns></returns>
        public int Max()
        {
            List<int> list = new List<int>()
            {
                1,2,3,4,5,6,29,4,7,55,55,-72,22,4
            };
            int max = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
