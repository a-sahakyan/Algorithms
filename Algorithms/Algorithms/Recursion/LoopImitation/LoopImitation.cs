using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.LoopImitation
{
    class LoopImitation
    {
        public void Imitation(int i, int n)
        {
            if (i == n)
            {
                return;
            }
            else
            {
                //Console.WriteLine(i); 0,n-1
                Imitation(i + 1, n);
                Console.WriteLine(i);//n-1,0
            }
        }
    }
}
