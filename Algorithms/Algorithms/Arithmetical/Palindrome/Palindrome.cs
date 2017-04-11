using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arithmetical.Palindrome
{
    class Palindrome
    {
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
    }
}
