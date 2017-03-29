using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Algorithms
{

    class Arithmetic
    {
        /// <summary>
        /// Calculate Sum
        /// </summary>
        /// <returns></returns>
        public int Sum()
        {
            List<int> list = new List<int>
            {
                1,2,3,4,5,6
            };
            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }

            return sum;
        }

        /// <summary>
        /// Calculate Sum of array
        /// </summary>
        /// <returns></returns>
        public int CalculateSum()
        {
            Console.WriteLine("enter the length of the array");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter array");
                arr[i] = int.Parse(Console.ReadLine());
                sum += int.Parse(Console.ReadLine());
            }


            return sum;
        }

        /// <summary>
        /// Get Max Value
        /// </summary>
        /// <returns></returns>
        public int Max()
        {
            List<int> list = new List<int>()
            {
                1,2,3,4,5,6,29,4,7,55,55,-72,22,4
            };
            int max = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Reverse String
        /// </summary>
        public void ReverseString()
        {
            string key = Console.ReadLine();

            for (int i = key.Length - 1; i >= 0; i--)
            {
                Console.Write(key[i]);
            }
        }

        /// <summary>
        /// Check number
        /// </summary>
        public void EvenOrOdd()
        {
            while (true)
            {
                Console.WriteLine("enter number or the key to exit");
                string a = Console.ReadLine();

                if (a == "end")
                {
                    Environment.Exit(0);
                }
                if (Convert.ToInt32(a) % 2 == 0)
                {
                    Console.WriteLine("the number is even");
                }
                else
                {
                    Console.WriteLine("the number is odd");
                }
            }
        }

        /// <summary>
        /// Swap two numbers
        /// </summary>
        public void SwapNumbers()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int keepFirst = 0;
            keepFirst = firstNum;
            firstNum = secondNum;
            secondNum = keepFirst;

            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
        }

        public void MultiplicationTable()
        {
            int number = int.Parse(Console.ReadLine());
            int keepNum = number;
            int table = 10;

            for (int i = 1; i < table; i++)
            {
                number *= i;

                Console.WriteLine(number);
                number = keepNum;
            }
        }

        /// <summary>
        /// Get prime numbers
        /// </summary>
        public void PrimeNumbers()
        {
            //A prime number (or a prime) is a natural number greater than 1 
            //that has no positive divisors other than 1 and itself
            while (true)
            {
                int key = int.Parse(Console.ReadLine());
                double result = Math.Sqrt(key);

                if ((key % 2 == 0 && key != 2) || (key % 3 == 0 && key != 3) || (key % 5 == 0 && key != 5) || (key % 7 == 0 && key != 7) || (result % 1 == 0))
                {
                    Console.WriteLine($"{key} is not prime");
                }
                else
                {
                    Console.WriteLine($"{key} is prime");
                }
            }
        }

        /// <summary>
        /// Reverse array
        /// </summary>
        public void ReverseArray()
        {
            int[] arr = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //int[] arr2 = new int[10];
            //int j = 0;
            int j = 1;
            for (int i = 0; i < arr.Length / 2; i++) //  { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;

            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Get max and min values from List
        /// </summary>
        public void MaxMinValues()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 56, 4, 5, 78, 9, 6, -2 };

            int max = 0;
            int min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (max < list[i])
                {
                    max = list[i];
                }
                else if (min > list[i])
                {
                    min = list[i];
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(min);
        }

        /// <summary>
        /// Check if word is palindrome
        /// <para>A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward as forward</para>
        /// </summary>
        public void PalindromeString()
        {
            while (true)
            {
                string word = Console.ReadLine();
                bool flag = false;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == word[word.Length - i - 1])
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }

                Console.WriteLine(flag);
            }
        }

        /// <summary>
        /// First 15 Fibonacci numbers.
        /// </summary>
        public void Fibonacci()
        {
            List<int> list = new List<int>() { };
            for (int i = 0; i < 15; i++)
            {
                if (i == 0 || i == 1)
                {
                    list.Add(i);
                }
                else
                {

                    list.Add(list[i - 1] + list[i - 2]);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// The program finds those subsets whose sum is zero
        /// </summary>
        public void SubsetsSum()
        {
            int[] arr = new int[] { 3, 1, -7, 35, 22 };
            int sum = 0;
            int subsets = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                int subsetSum = 0;
                int subsetIndex = i;
                int jIndex = i + 2;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (j < arr.Length - 1)
                    {
                        sum = arr[i] + arr[jIndex++];
                    }
                    subsetSum += arr[subsetIndex++];

                    if (sum == 0 || subsetSum == 0)
                    {
                        subsets++;
                    }
                }
            }

            Console.WriteLine(subsets >= 2 ? $"matches count:{--subsets}" : "None match");
        }

        /// <summary>
        ///  checks whether a given number is prime or not.
        /// </summary>
        public void IsPrime()
        {
            while (true)
            {
                Console.Write("Enter a positive number: ");
                int num = int.Parse(Console.ReadLine());
                int divide = 2;
                bool isPrime = true;
                while (divide < num)
                {
                    if (num % divide == 0)
                    {
                        isPrime = false;
                    }
                    divide++;
                }
                Console.WriteLine($"prime: {isPrime}");
            }
        }
    }
}

