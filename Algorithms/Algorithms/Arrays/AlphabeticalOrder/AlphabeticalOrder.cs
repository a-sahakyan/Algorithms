using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Algorithms.Arrays.AlphabeticalOrder
{
    class AlphabeticalOrder
    {
        public char[] Alphabeticaly()
        {
            Console.Write("count of chars: ");
            int count = int.Parse(Console.ReadLine());
            char[] chars = new char[count];
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write("add one character: ");
                chars[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = i + 1; j < chars.Length; j++)
                {
                    if (chars[i] > chars[j])
                    {
                        char temp = chars[j];
                        chars[j] = chars[i];
                        chars[i] = temp;
                    }
                }
            }

            string[] arr = new string[] { "please wait", "lucky guy", "patient", "wait just wait", "maybe coffee?" };
            Random rnd = new Random();

            for (int index = 0; index < arr.Length; index++)
            {
                int strIndex = rnd.Next(0, arr.Length);
                Console.Write(arr[strIndex]);
                Thread.Sleep(1500);
                ClearLastLine();
            }
            Console.WriteLine("ordering...");
            Thread.Sleep(3000);
            return chars;
        }
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}
