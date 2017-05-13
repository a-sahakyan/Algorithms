using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lists.LongestSubsequenceOfEqual
{
    class LongestSubsequenceOfEqual
    {
        /// <summary>
        /// Method that finds the longest subsequence of equal numbers in a given List.
        /// </summary>
        public void FindOut()
        {
            List<int> list = new List<int>() { 1, 5, 5, 5, 4, 4, 5, 8, 8 };
            int maxCount = LongestEqualCount(list);
            int count = 1;
            List<int> longestEquaList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count;)
                {
                    if (list[i] == list[j])
                    {
                        count++;
                        if (count == maxCount)
                        {
                            for (int k = 0; k < maxCount; k++)
                            {
                                longestEquaList.Add(list[i]);

                            }
                            goto print;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                    break;
                }
            }
            print:
            Print(longestEquaList, maxCount);
        }

        private int LongestEqualCount(List<int> list)
        {
            int count = 1;
            List<int> allCountsList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count;)
                {
                    if (list[i] == list[j])
                    {
                        count++;
                        if (j == list.Count - 1)
                        {
                            allCountsList.Add(count);
                        }
                    }
                    else
                    {
                        allCountsList.Add(count);
                        count = 1;
                    }
                    break;
                }
            }

            int max = 0;
            for (int i = 0; i < allCountsList.Count; i++)
            {
                if (allCountsList[i] > max)
                {
                    max = allCountsList[i];
                }
            }

            return max;
        }

        private void Print(List<int> longestEqualList, int maxCount)
        {
            foreach (var value in longestEqualList)
            {
                Console.Write($"{value}  ");
            }

            Console.Write($" Count: {maxCount}");
        }
    }
}
