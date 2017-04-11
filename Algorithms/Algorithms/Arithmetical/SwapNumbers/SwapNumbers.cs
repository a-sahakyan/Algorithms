using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.SwapNumbers
{
    class SwapNumbers
    {
        /// <summary>
        /// Swap two numbers
        /// </summary>
        public void Swap()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int keepFirst = 0;
            keepFirst = firstNum;
            firstNum = secondNum;
            secondNum = keepFirst;

            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
        }
    }
}
