using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.TextFiles.WordsCount
{
    class WordsCount
    {
        /// <summary>
        /// User adds words,the program counts how many times each of these words is found in file.
        /// </summary>
        public void Count(string path, params string[] words)
        {
            StreamReader reader = new StreamReader(path);
            string content = reader.ReadToEnd();
            reader.Close();

            List<string> wordList = SplitSymbols(content);
            int[] countArr = new int[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                int count = 1;
                for (int j = 0; j < wordList.Count; j++)
                {
                    if (wordList[j] == words[i])
                    {
                        countArr[i] = count++;
                    }
                }
            }

            Print(words, countArr);
        }

        private List<string> SplitSymbols(string content)
        {
            List<string> wordList = new List<string>();
            StringBuilder build = new StringBuilder();
            string word = null;
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i] == ' ' || content[i] == ',' || content[i] == '.' || content[i] == '\r' || content[i] == '\n')
                {
                    wordList.Add(word);
                    word = "";
                    build.Clear();
                    wordList.Add(content[i].ToString());
                }
                else
                {
                    word = build.Append(content[i]).ToString();
                }
            }

            return wordList;
        }

        private void Print(string[] words, int[] countArr)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"{words[i]} occurs {countArr[i]} times in file.");
            }
        }
    }
}
