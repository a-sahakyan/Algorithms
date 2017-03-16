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
        /// Найти максимальное число
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


        #region  Вывести члены  последовательности с нечетными номерами
        public void F5()
        {
            int i = int.Parse(Console.ReadLine());
            if (i > 0)
            {
                Console.WriteLine(i);
                Console.ReadLine();
                F5();
            }
        }
        #endregion

        #region Вывести нечетные числа последовательности
        public void F4()
        {
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                if (a % 2 == 1)
                {
                    Console.WriteLine(a);
                    F4();
                }
                else
                {
                    F4();
                }
            }

        }
        #endregion 

        #region Палиндром !!!!!!!!!!
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


        #region Цифры числа слева направо
        public string F2(int i)
        {
            if (i < 10)
            {
                return i.ToString();
            }
            return F2(i / 10) + " " + i % 10;

        }
        #endregion


        #region Цифры числа справа налево
        public int F1(int i)
        {
            if (i < 10)
            {
                return i;
            }
            Console.WriteLine(i % 10);
            return F1(i / 10);
        }
        #endregion

        #region Дано натуральное число N. Вычислите сумму его цифр.
        public int F(int i)
        {
            if (i < 10)
            {
                return i;
            }
            return i % 10 + F(i / 10);
        }
        #endregion

        #region LoopImitation1
        public void LoopImitation1(int i, int n)
        {
            Console.WriteLine(i);
            if (i < n & i % 2 == 0)
            {
                LoopImitation1(i + 1, n);
            }
            Console.WriteLine(i);

        }
        #endregion

        #region LoopImitation
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
        #endregion

        #region От A до B
        public string A_B(int a, int b)
        {
            return ((char)65).ToString();
        }
        #endregion

        #region Дано натуральное число n. Выведите все числа от 1 до n.
        public string From1ToN(int n)
        {
            if (n == 0) return "0";
            if (n == 1) return "1";
            return From1ToN(n - 1) + " " + n;
        }
        #endregion

        #region Factorial

        public int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        #endregion
    }
}
