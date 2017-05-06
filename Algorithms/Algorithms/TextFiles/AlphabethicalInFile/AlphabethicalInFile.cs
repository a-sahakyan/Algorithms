using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.TextFiles.AlphabethicalInFile
{
    class AlphabethicalInFile
    {
        /// <summary>
        /// Reads a list of names from a text file, arranges them in alphabetical order.
        /// Writes them to another file. 
        /// </summary>
        public void Order(string path)
        {
            StreamReader reader = new StreamReader(path);
            string content = reader.ReadToEnd();
            reader.Close();

            List<char> charList = CleanContent(content);

            for (int i = 0; i < charList.Count; i++)
            {
                for (int j = i + 1; j < charList.Count; j++)
                {
                    if (charList[i] > charList[j])
                    {
                        char temp = charList[i];
                        charList[i] = charList[j];
                        charList[j] = temp;
                    }
                }
            }

            WriteInFile(path, charList);
        }

        private void WriteInFile(string path, List<char> sortedList)
        {
            StringBuilder buil = new StringBuilder();
            string result = null;

            for (int i = 0; i < sortedList.Count; i++)
            {
                result = buil.Append(sortedList[i]).Append("\r").Append("\n").ToString();
            }

            StreamWriter writer = new StreamWriter(path, false);
            writer.Write(result);
            writer.Close();
            Console.WriteLine("File has successfully been saved.");
        }

        private List<char> CleanContent(string content)
        {
            char[] spaces = { '\n', '\r' };
            string[] onlyChars = content.Split(spaces, StringSplitOptions.RemoveEmptyEntries);
            List<char> charList = new List<char>();

            for (int i = 0; i < onlyChars.Length; i++)
            {
                for (int j = 0; j < onlyChars[i].Length; j++)
                {
                    charList.Add(onlyChars[i][j]);
                }
            }

            return charList;
        }
    }
}
