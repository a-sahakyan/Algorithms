using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings.NumberOfDays
{
    class NumberOfDays
    {
        public void Calculate()
        {
            while (true)
            {
                Console.Write("Enter the first date: ");
                string date = Console.ReadLine();
                Console.Write("Enter the second date:");
                string date2 = Console.ReadLine();
                DateTime dateTime = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
                DateTime dateTime2 = DateTime.ParseExact(date2, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);

                Console.WriteLine($"Distance: {dateTime - dateTime2} days");
            }
        }
    }
}
