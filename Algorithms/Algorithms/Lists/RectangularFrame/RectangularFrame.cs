using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lists.RectangularFrame
{
    class RectangularFrame
    {
        public void TheRectangularFrame()
        {
            List<string> list = new List<string>() { "Hello", "World", "in", "aghffgfgfgbcdefghi", "a", "frame" };

            int length = 0;
            int rowIndex = 0;
            foreach (var item in list)
            {
                length = item.Length > length ? item.Length : length;
            }

            for (int i = 0; i <= list.Count + 1; i++)
            {
                int columnIndex = 0;
                int space = length - list[rowIndex].Length;
                int frontSpace = space / 2;
                int endSpace = space % 2 == 0 ? frontSpace : frontSpace + 1;
                int word = list[rowIndex].Length;
                for (int j = 0; j <= length + 1; j++)
                {
                    if (i == 0 || i == list.Count + 1 || j == 0 || j == length + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (frontSpace-- > 0)
                        {
                            Console.Write(" ");
                        }
                        else if (word-- > 0)
                        {
                            Console.Write((list[rowIndex])[columnIndex++]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
                rowIndex = rowIndex < list.Count - 1 && i != 0 ? rowIndex + 1 : rowIndex;
            }
        }
    }
}
