using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.TextFiles.AddLines
{
    class AddLines
    {
        /// <summary>
        /// Reads the contents of a text file and inserts the line numbers at the beginning of each line, then rewrites the file contents.
        /// </summary>
        public void RewriteFileWithLines(string path)
        {
            if (path == null) throw new ArgumentNullException(nameof(path));
            StreamReader read = new StreamReader(path);
            string content = read.ReadToEnd();
            read.Close();

            char newLine = '\n';
            string[] splittedContent = content.Split(newLine);
            string newContent = null;
            StringBuilder build = new StringBuilder();
            for (int i = 0; i < splittedContent.Length; i++)
            {
                newContent = build.Append($"{i + 1}. ").Append(splittedContent[i]).Append("\n").ToString();
            }

            RewriteToFile(path, newContent);
        }

        private void RewriteToFile(string path, string content)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.Write(content);
            writer.Close();
            Console.WriteLine("Your file has successfully been saved.");
        }
    }
}
