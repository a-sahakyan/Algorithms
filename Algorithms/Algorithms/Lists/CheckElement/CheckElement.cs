using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lists.CheckElement
{
    class CheckElement
    {
        /// <summary>
        /// check whether an element occurs in a list.
        /// </summary>
        public void CheckElements()
        {
            while (true)
            {
                List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int key = int.Parse(Console.ReadLine());

                int i = 0;
                while (i < list.Count)
                {
                    if (key == list[i])
                    {
                        Console.WriteLine(true.ToString());
                        break;
                    }
                    i++;
                }

                if (i == list.Count)
                {
                    Console.WriteLine(false.ToString());
                }
            }
        }

    }
}
