using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays.MaximalConsecutiveSequence
{
    class MaximalConsecutiveSequence
    {
        /// <summary>
        /// finds the maximal sequence of consecutive equal elements in an array.
        /// </summary>
        public void GetSequence()
        {
            int[] arr = new int[] { 1, 1, 1, 1, 1, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 1 };
            List<string> list = new List<string>() { };
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        i++;
                    }
                    else if (count >= 2)
                    {
                        list.Add($"{arr[i]} count: {count}");
                        count = 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            char[] s = { ' ' };
            string[] s1;
            int p = 0;
            List<int> maxCount = new List<int>() { };
            for (int i = 0; i < list.Count; i++)
            {
                s1 = list[i].Split(s, StringSplitOptions.RemoveEmptyEntries);

                int num = 0;
                bool parsed = int.TryParse(s1[2], out num);
                if (parsed == true)
                {
                    maxCount.Add(num);
                }
            }

            int maxValue = 0;
            int countValue = -1;
            for (int i = 0; i < maxCount.Count; i++)
            {
                if (maxValue < maxCount[i])
                {
                    maxValue = maxCount[i];
                    countValue++;
                }
            }

            Console.WriteLine(list[countValue]);
        }
    }
}
