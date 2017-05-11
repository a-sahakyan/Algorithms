using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.TextFiles.Words
{
    class Words
    {
        /// <summary>
        /// Program deletes in the file all the words that user adds.
        /// </summary>
        public void RemoveWords(string path, params string[] words)
        {
            StreamReader reader = new StreamReader(path);
            string content = reader.ReadToEnd();
            reader.Close();

            List<string> wordList = SplitSymbols(content);

            for (int i = 0; i < wordList.Count; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (wordList[i] == words[j])
                    {
                        wordList.RemoveAt(i);
                    }
                }
            }

            WriteInFile(path, wordList);
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

        private void WriteInFile(string path, List<string> wordList)
        {
            StringBuilder build = new StringBuilder();
            string result = null;

            for (int i = 0; i < wordList.Count; i++)
            {
                result = build.Append(wordList[i]).ToString();
            }

            StreamWriter writer = new StreamWriter(path);
            writer.Write(result);
            writer.Close();
            Console.WriteLine("Your file has successfully been saved.");
        }
    }
}
