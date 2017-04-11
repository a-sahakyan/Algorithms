using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.MaxMinValues
{
    class MaxMinValues
    {
        /// <summary>
        /// Get max and min values from List
        /// </summary>
        public void GetValues()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 56, 4, 5, 78, 9, 6, -2 };

            int max = 0;
            int min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (max < list[i])
                {
                    max = list[i];
                }
                else if (min > list[i])
                {
                    min = list[i];
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
