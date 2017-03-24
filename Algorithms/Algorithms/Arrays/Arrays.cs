using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Algorithms
{
    class Arrays
    {
        #region JuggedArrayTask
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
        #endregion

        /// <summary>
        /// Finds duplicates from chars input.
        /// </summary>
        public void QuantityOfDuplicatesJugged()
        {
            Random rnd = new Random();
            int count = 0;
            Console.WriteLine("enter quantity of jagged array");
            int n = int.Parse(Console.ReadLine());
            char[][] arr = new char[n][];

            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine("add number of elements");
                int m = int.Parse(Console.ReadLine());
                arr[i] = new char[m];
                int j = 0;
                while (arr[i].Length > j)
                {
                    for (int k = 65; k <= 90; k++)
                    {
                        int result = rnd.Next(65, 91);

                        if (j < m)
                        {
                            arr[i][j] = (char)result;
                            Console.Write(arr[i][j]);
                            j++;
                            if (j == arr[i].Length)
                            {
                                char[] duplicates = new char[j];

                                for (int p = 0; p < arr[i].Length; p++)
                                {
                                    if (!duplicates.Contains(arr[i][p]))
                                    {
                                        int index = p;
                                        count = 1;
                                        int dIndex = 0;
                                        for (int l = ++index; l < arr[i].Length; l++)
                                        {
                                            if (arr[i][p] == arr[i][l])
                                            {
                                                count++;
                                                duplicates[dIndex++] = arr[i][l];

                                            }
                                        }
                                        Console.Write($"    {arr[i][p]} count: {count}");

                                    }
                                }

                            }
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        public void QuantityOfDuplicates()
        {
            char[] arr = new char[] { 'a', 'a', 'b', 'c', 'c', 'c', 'c', 'l', 'v', 'l', 'c' };
            char[] duplicates = new char[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (!duplicates.Contains(arr[i]))
                {
                    int index = i;
                    int count = 1;
                    int dIndex = 0;
                    for (int j = ++index; j < arr.Length; j++)
                    {

                        if (arr[i] == arr[j])
                        {
                            count++;
                            duplicates[dIndex++] = arr[j];
                        }
                    }
                    Console.WriteLine($"{arr[i]} count: {count}");
                }
            }
        }

        public void JaggedColors()
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
