using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lists.RemoveMinimal
{
    class RemoveMinimal
    {
        /// <summary>
        /// Removes a numbers of elements in such a way that the remaining array is sorted in an increasing order.
        /// </summary>
        public void Sort()
        {
            List<int> list = new List<int>() { 6, 5, 1, 2, 4, 3, 3, 4, 5, 3, 9, 9, 0, 3, 6, 4, 5, 0, 5, 0 };
            int max = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1)
                {
                    if (list[i] > list[i + 1])
                    {
                        if (i == 0)
                        {
                            list.RemoveAt(i);
                            i--;
                        }
                        else
                        {
                            list.RemoveAt(i + 1);
                            i--;
                        }
                    }
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);

                if (list[i] == max)
                {
                    break;
                }
            }
        }
    }
}
