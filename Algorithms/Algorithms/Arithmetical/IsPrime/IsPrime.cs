using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.IsPrime
{
    class IsPrime
    {
        /// <summary>
        ///  checks whether a given number is prime or not.
        /// </summary>
        public void IsNumberPrime()
        {
            while (true)
            {
                Console.Write("Enter a positive number: ");
                int num = int.Parse(Console.ReadLine());
                int divide = 2;
                int maxDivide = (int)Math.Sqrt(num);
                bool isPrime = true;
                if (num == 1)
                {
                    isPrime = false;
                }

                while (divide <= maxDivide)
                {
                    if (num % divide == 0)
                    {
                        isPrime = false;
                    }
                    divide++;
                }

                Console.WriteLine($"prime: {isPrime}");
            }
        }
    }
}
