using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ListSeries
    {
        /// <summary>
        /// Rotate a list by k elements
        /// </summary>
        public void RotateElements()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            int key = int.Parse(Console.ReadLine());

            for (int i = 0; i < key; i++)
            {
                list.Add(list[key - i - 1]);
                list.RemoveAt(key - i - 1);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
