using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Recursion
    {
        /// <summary>
        /// Get Max value
        /// </summary>
        /// <returns></returns>
        public int Max()
        {
            int i = int.Parse(Console.ReadLine());

            if (i > 0)
            {
                return Math.Max(i, Max());
            }
            return 0;
        }


        /// <summary>
        /// Get odd numbers
        /// </summary>
        public void GetOdd()
        {
            int i = int.Parse(Console.ReadLine());
            if (i > 0)
            {
                Console.WriteLine(i);
                Console.ReadLine();
                GetOdd();
            }
        }

        /// <summary>
        /// Get Odd numbers
        /// </summary>
        public void Odd()
        {
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                if (a % 2 == 1)
                {
                    Console.WriteLine(a);
                    Odd();
                }
                else
                {
                    Odd();
                }
            }

        }

        #region GetPalindrome
        static int i = 0;
        public bool Polindrom(string s)
        {

            if (s[i] == s[s.Length - 1 - i])
            {
                if (i < s.Length / 2)
                {
                    i++;
                    return Polindrom(s);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        #endregion


        /// <summary>
        /// Get numbers from left to right
        /// </summary>
        public string FromLeftToRight(int i)
        {
            if (i < 10)
            {
                return i.ToString();
            }
            return FromLeftToRight(i / 10) + " " + i % 10;

        }

        /// <summary>
        /// Get numbers from right to left
        /// </summary>
        public int FromRightToLeft(int i)
        {
            if (i < 10)
            {
                return i;
            }
            Console.WriteLine(i % 10);
            return FromRightToLeft(i / 10);
        }

        /// <summary>
        /// Calculate number
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int CalculateNumber(int i)
        {
            if (i < 10)
            {
                return i;
            }
            return i % 10 + CalculateNumber(i / 10);
        }

        public void LoopImitation(int i, int n)
        {
            if (i == n)
            {
                return;
            }
            else
            {
                //Console.WriteLine(i); 0,n-1
                LoopImitation(i + 1, n);
                Console.WriteLine(i);//n-1,0

            }
        }

        public void LoopImitation2(int i, int n)
        {
            Console.WriteLine(i);
            if (i < n & i % 2 == 0)
            {
                LoopImitation2(i + 1, n);
            }
            Console.WriteLine(i);

        }

        public string FromAToB(int a, int b)
        {
            return ((char)65).ToString();
        }

        /// <summary>
        /// Get all numbers from 1 to n.
        /// </summary>
        public string GetFromOneToN(int n)
        {
            if (n == 0) return "0";
            if (n == 1) return "1";
            return GetFromOneToN(n - 1) + " " + n;
        }

        public int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        #region Sum
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        int sum = 0;
        int k = 0;
        public int RecursionSum()
        {
            if (k < list.Count)
            {
                sum += list[k];
                k++;
                RecursionSum();
            }

            return sum;
        }
        #endregion
    }
}
