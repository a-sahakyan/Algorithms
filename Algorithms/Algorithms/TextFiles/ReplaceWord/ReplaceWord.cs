using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.TextFiles.ReplaceWord
{
    class ReplaceWord
    {
        public void Replace(string path, string firstWord, string secondWord)
        {
            StreamReader reader = new StreamReader(path);
            string content = reader.ReadToEnd();
            reader.Close();
            List<string> wordsList = new List<string>();
            SplitSymbols(content, wordsList);

            for (int i = 0; i < wordsList.Count; i++)
            {
                if (wordsList[i] == firstWord)
                {
                    wordsList.Insert(i, secondWord);
                    wordsList.Remove(firstWord);
                }
            }

            WriteInFile(path, wordsList);
        }

        private void SplitSymbols(string content, List<string> wordsList)
        {
            string word = null;
            StringBuilder build = new StringBuilder();
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i] == ',' || content[i] == ' ' || content[i] == '.' || content[i] == '\r' ||
                    content[i] == '\n' || content[i] == '!')
                {
                    wordsList.Add(word);
                    build.Clear();
                    word = "";
                    wordsList.Add(content[i].ToString());
                }
                else
                {
                    word = build.Append(content[i]).ToString();
                }
            }
        }

        private void WriteInFile(string path, List<string> wordsList)
        {
            StringBuilder build = new StringBuilder();
            string result = null;
            for (int i = 0; i < wordsList.Count; i++)
            {
                result = build.Append(wordsList[i]).ToString();
            }

            StreamWriter writer = new StreamWriter(path);
            writer.Write(result);
            writer.Close();
            Console.WriteLine("Your file has successfully been saved.");
        }
    }
}
