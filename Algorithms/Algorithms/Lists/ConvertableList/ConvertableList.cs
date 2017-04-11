using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lists.ConvertableList
{
    class ConvertableList
    {
        public void Convert()
        {
            List<string> list = new List<string>() { "b1", "b2", "1b3", "1b23" };

            for (int i = 0; i < list.Count; i++)
            {
                string key = "";
                char[] arr = new char[list[i].Length];

                for (int j = 0; j < list[i].Length; j++)
                {
                    int number;
                    string str = (list[i])[j].ToString();
                    arr[j] = ((list[i])[j]);

                    bool flag = int.TryParse((list[i])[j].ToString(), out number);
                    if (flag == true)
                    {
                        key += number.ToString();
                        if ((list[i])[j] == arr[arr.Length - 1])
                        {
                            Console.WriteLine(System.Convert.ToInt32(key));
                        }
                    }
                }
            }
        }
    }
}
