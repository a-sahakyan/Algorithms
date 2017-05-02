using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.TextFiles.WriteFile
{
    class WriteFile
    {
        /// <summary>
        /// Writes the file content to another file.
        /// </summary>
        /// <param name="pathToRead">path to read file</param>
        /// <param name="pathToWrite">path to write into</param>
        public void Write(string pathToRead, string pathToWrite)
        {
            try
            {
                string content = Read(pathToRead);
                StreamWriter sw = new StreamWriter(pathToWrite);
                sw.Write(content);
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("your file has successfully been saved.");
        }

        private static string Read(string path)
        {
            string content = null;
            try
            {
                StreamReader sr = new StreamReader(path);
                content = sr.ReadToEnd();
                sr.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            return content;
        }
    }
}
