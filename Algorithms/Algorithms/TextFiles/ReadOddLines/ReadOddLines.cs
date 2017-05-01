using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.TextFiles.ReadOddLines
{
    class ReadOddLines
    {
        /// <summary>
        /// program that reads a text file and prints its odd lines on the console.
        /// </summary>
        public void Read(string path)
        {
            try
            {
                StreamReader reader = new StreamReader(path);
                string result = null;
                int index = 1;
                StringBuilder build = new StringBuilder();
                res: result = reader.ReadLine();
                if (result != null)
                {
                    if (index % 2 == 1)
                    {
                        Console.WriteLine(build.Append(result).Append(" odd lines"));
                        build.Clear();
                    }
                    index++;
                    goto res;
                }
                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
