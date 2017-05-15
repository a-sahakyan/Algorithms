using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lists.TheMajorant
{
    class TheMajorant
    {
        private List<int> _list = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

        /// <summary>
        ///  The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
        /// The program finds the majorant 
        /// </summary>
        public void GetMajorant()
        {
            SortList();

            List<List<int>> jaggedList = new List<List<int>>();

            SortList();

            int count = 0;
            int index = -1;
            for (int i = 0; i < _list.Count; i++)
            {
                bool flag = true;
                jaggedList.Add(new List<int>());
                index++;
                for (int j = i + 1; j < _list.Count; j++)
                {
                    if (_list[i] == _list[j])
                    {
                        if (flag)
                        {
                            jaggedList[index].Add(_list[i]);
                            flag = false;
                        }
                        jaggedList[index].Add(_list[j]);
                        count++;
                    }
                    else if (j == _list.Count - 1 && flag)
                    {
                        jaggedList[index].Add(_list[i]);
                    }
                }
                if (count != 0)
                {
                    i += count;
                    count = 0;
                }
            }

            Print(jaggedList);
        }

        private void SortList()
        {
            for (int i = 0; i < _list.Count; i++)
            {
                for (int j = i + 1; j < _list.Count; j++)
                {
                    if (_list[i] > _list[j])
                    {
                        int temp = _list[i];
                        _list[i] = _list[j];
                        _list[j] = temp;
                    }
                }
            }
        }

        private void Print(List<List<int>> jaggedList)
        {
            bool flag = true;
            for (int i = 0; i < jaggedList.Count; i++)
            {
                if (jaggedList[i].Count == _list.Count / 2 + 1)
                {
                    Console.WriteLine(jaggedList[i][0]);
                    flag = false;
                }
                else if (i == jaggedList.Count - 1 && flag)
                {
                    Console.WriteLine("the majorant does not exist!");
                }
            }
        }
    }
}
