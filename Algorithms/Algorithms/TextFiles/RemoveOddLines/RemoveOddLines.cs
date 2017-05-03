using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.TextFiles.RemoveOddLines
{
    class RemoveOddLines
    {
        /// <summary>
        /// Deletes all the odd lines of a text file.
        /// </summary>
        public void Remove(string path)
        {
            StreamReader reader = new StreamReader(path);
            string content = reader.ReadToEnd();
            reader.Close();

            char[] symbols = { '\r', '\n' };
            string[] line = content.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
            List<string> lineList = line.ToList();
            int index = 1;
            for (int i = 0; i < lineList.Count; i++)
            {
                if (index % 2 == 1)
                {
                    lineList.RemoveAt(i);
                }
                index++;
            }

            WriteInFile(path, lineList);
        }

        private void WriteInFile(string path, List<string> lineList)
        {
            StringBuilder build = new StringBuilder();
            string result = null;
            for (int i = 0; i < lineList.Count; i++)
            {
                result = build.Append(lineList[i]).Append("\r").Append("\n").ToString();
            }

            StreamWriter writer = new StreamWriter(path);
            writer.Write(result);
            writer.Close();
            Console.WriteLine("Your file has successfully been saved.");
        }
    }
}
