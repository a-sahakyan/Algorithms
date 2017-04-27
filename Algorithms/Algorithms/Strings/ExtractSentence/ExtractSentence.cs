using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings.ExtractSentence
{
    class ExtractSentence
    {
        /// <summary>
        /// extracts from a text all sentences that contain a particular word.
        /// </summary>
        public void ExtractByWord(string word)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string[] arr = text.Split('.');
            int count = arr.Length;

            List<List<string>> sentences = new List<List<string>>();

            for (int i = 0; i < count; i++)
            {
                sentences.Add(new List<string>());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    sentences[i] = arr[i].Split(' ').ToList();
                }

            }
            bool[] containsWord = IsContain(sentences, count, word);

            Print(sentences, containsWord);
        }

        private bool[] IsContain(List<List<string>> sentences, int count, string word)
        {
            bool[] containsWord = new bool[count];

            for (int i = 0; i < sentences.Count; i++)
            {
                for (int j = 0; j < sentences[i].Count; j++)
                {
                    if (sentences[i][j] == word)
                    {
                        containsWord[i] = true;
                    }
                }
            }

            return containsWord;
        }

        private void Print(List<List<string>> sentences, bool[] containsWord)
        {
            string result = null;

            StringBuilder build = new StringBuilder();
            for (int i = 0; i < sentences.Count; i++)
            {
                if (containsWord[i])
                {
                    for (int j = 0; j < sentences[i].Count; j++)
                    {
                        if (j == sentences[i].Count - 1)
                        {
                            result = build.Append(sentences[i][j]).Append(".\n").ToString();
                        }
                        else if (sentences[i][j] != "")
                        {
                            result = build.Append(sentences[i][j]).Append(" ").ToString();
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
