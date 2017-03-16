using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Arrays
    {

        private static string a = "";

        public void ArrJugged()
        {

            try
            {

                Random rnd = new Random();
                Console.WriteLine("Insert Array Rows Count");
                int length = int.Parse(Console.ReadLine());
                char[][] arrJugged = new char[length][];
                for (int i = 0; i < arrJugged.Length; i++)
                {
                    Console.WriteLine($"Insert Array {i + 1} Row's Column Count");
                    arrJugged[i] = new char[int.Parse(Console.ReadLine())];
                }
                for (int i = 0; i < arrJugged.Length; i++)
                {
                    Console.WriteLine($"\nAdd random characters in array ({i + 1} line)\n");
                    for (int j = 0; j < arrJugged[i].Length; j++)
                    {
                        arrJugged[i][j] = (char)rnd.Next((int)'A', (int)'Z');
                        Console.Write(arrJugged[i][j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                string str = null;
                int sum = 0;
                int line = 1;
                Console.WriteLine("\nResult: ");
                for (int i = 0; i < arrJugged.Length; i++)
                {
                    Console.WriteLine($"\nLine {line++}");
                    for (int j = 0; j < arrJugged[i].Length; j++)
                    {
                        foreach (var item in arrJugged[i])
                        {
                            str += item;
                            sum = arrJugged[i][j] == item ? sum + 1 : sum;
                        }
                        if (Check(arrJugged[i][j]))
                        {
                            Console.Write($"{arrJugged[i][j]} - {sum} | ");
                        }
                        sum = 0;
                    }
                    a = "";
                    Console.WriteLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("\nTry Again !!!\n");
                ArrJugged();
            }
        }

        protected bool Check(char value)
        {
            foreach (var item in a)
            {
                if (value == item)
                {
                    return false;
                }
            }
            a += value;
            return true;
        }
    }
}
