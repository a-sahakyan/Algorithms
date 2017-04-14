using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Numeral.ConvertToBinary
{
    class ConvertToBinary
    {
        /// <summary>
        /// converts a decimal number to binary one.
        /// </summary>
        public void Convert()
        {
            while (true)
            {
                Console.Write("enter decimal number: ");
                int dec = int.Parse(Console.ReadLine());
                int constantDec = dec;
                int num = 1;
                List<int> list = new List<int>();
                string result = "";

                if (constantDec % 2 == 0)
                {
                    while (dec >= num)
                    {
                        num *= 2;
                        if (num > dec)
                        {
                            num /= 2;
                            dec = dec - num;
                            list.Add(num);
                            num = 1;
                        }
                    }
                }
                else
                {
                    while (dec > num)
                    {
                        num *= 2;
                        if (num >= dec)
                        {
                            num /= 2;
                            dec = dec - num;
                            list.Add(num);
                            num = 1;
                        }
                    }
                }

                int index = 0;
                if (list.Count != 0)
                {
                    for (int i = list[0]; i > 1; i = i / 2)
                    {
                        if (i == list[index])
                        {
                            result += "1";
                            index = index >= list.Count - 1 ? index : index + 1;
                        }
                        else
                        {
                            result += "0";
                        }
                    }
                }

                result += constantDec % 2 == 0 ? "0" : "1";
                Console.WriteLine(result);
            }
        }
    }
}
