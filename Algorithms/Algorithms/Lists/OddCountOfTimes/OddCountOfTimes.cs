using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lists.OddCountOfTimes
{
    class OddCountOfTimes
    {
        /// <summary>
        /// Removes from a given sequence all numbers that appear an odd count of times.
        /// </summary>
        public void Remove()
        {
            List<int> list = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 }; /* -> { 5, 3, 3, 5}*/

            int count = 1;
            int value = 0;
            List<int> evenCountList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                value = list[i];

                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        count++;
                    }
                }
                if (count % 2 == 1)
                {
                    for (int j = 0; j < count; j++)
                    {
                        list.Remove(value);
                    }

                    i = i > -1 ? i - 1 : -1;
                }
                else
                {
                    for (int j = 0; j < count; j++)
                    {
                        evenCountList.Add(value);
                    }
                }
                count = 1;
            }

            Print(evenCountList);
        }

        private void Print(List<int> evenCountList)
        {
            foreach (var value in evenCountList)
            {
                Console.Write($"{value}  ");
            }
        }
    }
}
