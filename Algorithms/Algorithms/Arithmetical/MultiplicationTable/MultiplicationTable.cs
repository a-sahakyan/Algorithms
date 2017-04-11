using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.MultiplicationTable
{
    class MultiplicationTable
    {
        public void Table()
        {
            int number = int.Parse(Console.ReadLine());
            int keepNum = number;
            int table = 10;

            for (int i = 1; i < table; i++)
            {
                number *= i;

                Console.WriteLine(number);
                number = keepNum;
            }
        }
    }
}
