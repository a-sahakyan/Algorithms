using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.Odd2
{
    class Odd2
    {
        /// <summary>
        /// Get Odd numbers
        /// </summary>
        public void Odd()
        {
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                if (a % 2 == 1)
                {
                    Console.WriteLine(a);
                    Odd();
                }
                else
                {
                    Odd();
                }
            }
        }
    }
}
