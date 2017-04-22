using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings.SubstringsCount
{
    class SubstringsCount
    {
        /// <summary>
        /// detects how many times a substring 'in' is contained in the text.
        /// </summary>
        public void GetCount()
        {
            string str = "We are living in a yellow submarine.We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string sameTextWithLowerCase = str.ToLower();
            int count = 0;
            for (int i = 0; i < sameTextWithLowerCase.Length - 1; i++)
            {
                string concatinated = sameTextWithLowerCase[i].ToString() + sameTextWithLowerCase[i + 1].ToString();

                if (concatinated.Equals("in"))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
