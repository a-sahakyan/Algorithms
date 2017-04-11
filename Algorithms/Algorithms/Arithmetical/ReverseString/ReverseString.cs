using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.ReverseString
{
    class ReverseString
    {
        /// <summary>
        /// Reverse String
        /// </summary>
        public void Reverse()
        {
            string key = Console.ReadLine();

            for (int i = key.Length - 1; i >= 0; i--)
            {
                Console.Write(key[i]);
            }
        }
    }
}
