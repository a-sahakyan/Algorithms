using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Enums
{
    class WeekDay
    {
        public void Days()
        {
            while (true)
            {
                DayOfWeek d = (DayOfWeek)int.Parse(Console.ReadLine());
                Console.WriteLine(((int)d >= 1 && (int)d <= 7) ? $"{d}" : "Please try again!!!");
            }
        }
    }
}
