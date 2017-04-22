using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings.Casing
{
    class Casing
    {
        /// <summary>
        /// modifies the casing of letters to uppercase at all places in the text surrounded by <upcase> and </upcase> tags.
        /// </summary>
        public void Modify()
        {
            string text = "We are living in a <upcase> yellow submarine </ upcase >.We don't have <upcase>anything</upcase> else.";
            char[] symbols = { '<', '>' };
            string[] arr = text.Split(symbols);

            string result = null;
            bool lower = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    result += "";
                }
                else
                {
                    if (lower)
                    {
                        result += arr[i];
                        lower = false;
                    }
                    else
                    {
                        result += arr[i].ToUpper();
                        lower = true;
                    }

                }
            }

            Console.WriteLine(result);
        }
    }
}
