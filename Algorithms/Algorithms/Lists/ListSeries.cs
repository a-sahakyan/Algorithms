using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ListSeries
    {
        /// <summary>
        /// check whether an element occurs in a list.
        /// </summary>
        public void CheckElement()
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

        /// <summary>
        /// Rotate a list by k elements
        /// </summary>
        public void RotateElements()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            int key = int.Parse(Console.ReadLine());

            for (int i = 0; i < key; i++)
            {
                list.Add(list[key - i - 1]);
                list.RemoveAt(key - i - 1);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void ConvertableList()
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
                            Console.WriteLine(Convert.ToInt32(key));
                        }
                    }
                }
            }
        }
        }
}
