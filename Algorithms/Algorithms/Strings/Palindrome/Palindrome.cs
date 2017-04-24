using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings.Palindrome
{
    class Palindrome
    {
        public bool IsPalindrome(string str)
        {
            bool isPalindrome = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str[str.Length - i - 1])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}
