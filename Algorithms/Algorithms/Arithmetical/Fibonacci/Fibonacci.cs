using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.Fibonacci
{
    class Fibonacci
    {
        /// <summary>
        /// First 15 Fibonacci numbers.
        /// </summary>
        public void GetFibonacciNumbers()
        {
            List<int> list = new List<int>() { };
            for (int i = 0; i < 15; i++)
            {
                if (i == 0 || i == 1)
                {
                    list.Add(i);
                }
                else
                {
                    list.Add(list[i - 1] + list[i - 2]);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
