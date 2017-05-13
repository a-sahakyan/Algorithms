using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lists.ElementsCount
{
    class ElementsCount
    {
        List<int> _list = new List<int>() { 3, 1, 4, 4, 2, 3, 3, 4, 3, 2, 5, 5, 2 };

        /// <summary>
        /// Finds in a given array of integers how many times each of them occurs.
        /// </summary>
        public void GetCount()
        {
            List<List<int>> jaggedList = new List<List<int>>();

            SortList();

            bool flag = false;
            int count = 0;
            int index = -1;
            for (int i = 0; i < _list.Count; i++)
            {
                flag = true;
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
            for (int i = 0; i < jaggedList.Count; i++)
            {
                Console.WriteLine($"{jaggedList[i][0]} -> {jaggedList[i].Count} times.");
            }
        }
    }
}
