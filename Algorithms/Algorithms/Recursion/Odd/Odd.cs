using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.Odd
{
    class Odd
    {
        /// <summary>
        /// Get odd numbers
        /// </summary>
        public void GetOdd()
        {
            int i = int.Parse(Console.ReadLine());
            if (i > 0)
            {
                Console.WriteLine(i);
                Console.ReadLine();
                GetOdd();
            }
        }
    }
}
