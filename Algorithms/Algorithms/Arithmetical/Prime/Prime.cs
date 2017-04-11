using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.Prime
{
    
    class Prime
    {
        //A prime number (or a prime) is a natural number greater than 1 
        //that has no positive divisors other than 1 and itself
        /// <summary>
        /// Get prime numbers
        /// </summary>
        public void PrimeNumbers()
        {
            while (true)
            {
                int key = int.Parse(Console.ReadLine());
                double result = Math.Sqrt(key);

                if ((key % 2 == 0 && key != 2) || (key % 3 == 0 && key != 3) || (key % 5 == 0 && key != 5) || (key % 7 == 0 && key != 7) || (result % 1 == 0))
                {
                    Console.WriteLine($"{key} is not prime");
                }
                else
                {
                    Console.WriteLine($"{key} is prime");
                }
            }
        }
    }
}
