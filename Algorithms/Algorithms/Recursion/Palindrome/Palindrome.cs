using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion.Palindrome
{
    class Palindrome
    {
        static int i = 0;
        public bool GetPalindrome(string s)
        {
            if (s[i] == s[s.Length - 1 - i])
            {
                if (i < s.Length / 2)
                {
                    i++;
                    return GetPalindrome(s);
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
