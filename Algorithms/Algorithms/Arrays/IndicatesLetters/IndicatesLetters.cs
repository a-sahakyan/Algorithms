using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays.IndicatesLetters
{
    class IndicatesLetters
    {
        /// <summary>
        /// creates an array containing all Latin letters. The user inputs a word from the console and as result the program prints to the console the indices of the letters from the word.
        /// </summary>
        public void GetIndexes()
        {
            //string[] letters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "v", "x", "y", "z" };
            string[] letters = new string[26];
            int index = 0;
            for (int i = 97; i <= 122; i++)
            {
                letters[index++] = ((char)i).ToString();
            }
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (word[i].ToString() == letters[j])
                    {
                        Console.Write($"{j} ");
                    }
                }
            }
        }
    }
}
