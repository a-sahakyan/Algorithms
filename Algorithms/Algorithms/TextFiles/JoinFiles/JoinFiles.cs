using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.TextFiles.JoinFiles
{
    class JoinFiles
    {
        /// <summary>
        /// program that joins two text files and records the results in a third file.
        /// </summary>
        public void Join(string path, string path2, string pathToWrite)
        {
            StreamReader readFirst = new StreamReader(path);
            string firstFileContent = readFirst.ReadToEnd();
            readFirst.Close();
            StreamReader readSecond = new StreamReader(path2);
            string secondFileContent = readSecond.ReadToEnd();
            readSecond.Close();

            if (!File.Exists(pathToWrite))
            {
                File.Create(pathToWrite);
            }

            WriteFile(pathToWrite, firstFileContent, secondFileContent);
        }

        private void WriteFile(string path, string firstFileContent, string secondFileContent)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.Write(firstFileContent);
            writer.WriteLine();
            writer.Close();
            StreamWriter writer2 = new StreamWriter(path, true);
            writer2.Write(secondFileContent);
            writer2.Close();
            Console.WriteLine("Your file has successfully been saved.");
        }
    }
}
