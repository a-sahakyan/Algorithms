using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.EvenOrOdd
{
    class EvenOrOdd
    {
        /// <summary>
        /// Check number
        /// </summary>
        public void GetNumber()
        {
            while (true)
            {
                Console.WriteLine("enter number or the key to exit");
                string a = Console.ReadLine();

                if (a == "end")
                {
                    Environment.Exit(0);
                }
                if (Convert.ToInt32(a) % 2 == 0)
                {
                    Console.WriteLine("the number is even");
                }
                else
                {
                    Console.WriteLine("the number is odd");
                }
            }
        }
    }
}
