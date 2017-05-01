using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.TextFiles.CompareFiles
{
    class CompareFiles
    {
        /// <summary>
        /// Program compare two files and checks whether they are same or not.
        /// </summary>
        public bool IsSame(string path, string secondPath)
        {

            bool isSame = false;
            try
            {
                StreamReader stream = new StreamReader(path);
                StreamReader stream2 = new StreamReader(secondPath);
                string content = stream.ReadToEnd();
                string secondContent = stream2.ReadToEnd();
                stream.Close();
                stream2.Close();
                isSame = CheckContent(content, secondContent);
                isSame = !isSame ? false : Compare(content, secondContent);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            return isSame;
        }

        //check if content is null or empty.
        private bool CheckContent(string content, string secondContent)
        {
            if (!string.IsNullOrEmpty(content) && !string.IsNullOrEmpty(secondContent))
                return true;

            Console.WriteLine($"there is no content.");
            return false;
        }

        // Remove all spaces from 2 files.
        private void RemoveSpaces(ref string content, ref string secondContent)
        {
            content = content.Replace(" ", string.Empty);
            secondContent = secondContent.Replace(" ", string.Empty);
        }

        //compare files.
        private bool Compare(string content, string secondContent)
        {
            RemoveSpaces(ref content, ref secondContent);
            if (content == secondContent)
                return true;

            return false;
        }
    }
}
