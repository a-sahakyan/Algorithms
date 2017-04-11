using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Algorithms.Arrays.JaggedColors
{
    class JaggedColors
    {
        public void JuggedColors()
        {
            Console.WriteLine("enter first dimension");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second dimenstion");
            int m = int.Parse(Console.ReadLine());

            string[,] arr = new string[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Random rnd = new Random();
                    int result = rnd.Next(0, 16);
                    Thread.Sleep(1000);
                    Console.ForegroundColor = (ConsoleColor)result;
                    arr[i, j] = ((ConsoleColor)result).ToString();
                    Console.WriteLine(arr[i, j]);
                }
            }
        }
    }
}
