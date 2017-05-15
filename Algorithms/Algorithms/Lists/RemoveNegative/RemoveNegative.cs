using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lists.RemoveNegative
{
    class RemoveNegative
    {
        /// <summary>
        /// Program, which removes all negative numbers from a sequence.
        /// </summary>
        public void Remove()
        {
            List<int> list = new List<int>() { 19, -10, 12, -6, -3, 34, -2, 5 };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }

            Print(list);
        }

        private void Print(List<int> list)
        {
            foreach (var value in list)
            {
                Console.Write($"{value}  ");
            }
        }
    }
}
