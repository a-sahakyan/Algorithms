using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings.ReverseWords
{
    class ReverseWords
    {
        /// <summary>
        /// Reverses the words in a given sentence without changing punctuation and spaces.
        /// </summary>
        public void Reverse(string text)
        {
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length / 2; i++)
            {
                string temp = words[i];
                words[i] = words[words.Length - i - 1];
                words[words.Length - i - 1] = temp;
            }

            Print(words);
        }

        private void Print(string[] words)
        {
            StringBuilder build = new StringBuilder();

            string result = null;
            for (int i = 0; i < words.Length; i++)
            {
                result = build.Append(words[i]).Append(" ").ToString();
            }

            Console.WriteLine(result);
        }
    }
}
