using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.TextFiles.CompareFilesRows
{
    class CompareFileRows
    {
        /// <summary>
        /// Compares two text files with the same number of rows line by line.
        /// Prints the number of equal and the number of different lines.
        /// </summary>
        public void Compare(string firstFilePath, string secondFilePath)
        {
            StreamReader firstReader = new StreamReader(firstFilePath);
            string firstContent = firstReader.ReadToEnd();
            firstReader.Close();
            StreamReader secondReader = new StreamReader(secondFilePath);
            string secondContent = secondReader.ReadToEnd();
            secondReader.Close();

            char newLine = '\n';
            string[] firstContentArr = firstContent.Split(newLine);
            string[] secondContentArr = secondContent.Split(newLine);

            IsEqualRowsLengths(firstContentArr, secondContentArr);

            IsEqualRowsContents(firstContentArr, secondContentArr);
        }

        private void IsEqualRowsLengths(string[] firstContentArr, string[] secondContentArr)
        {
            if (firstContentArr.Length == secondContentArr.Length)
            {
                Console.WriteLine("rows Lenghts are equal");
            }
            else
            {
                Console.WriteLine("rows Lenghts are not equal");
            }
            Console.WriteLine($"first file rows: {firstContentArr.Length}, second file rows: {secondContentArr.Length}");
        }

        private void IsEqualRowsContents(string[] firstContentArr, string[] secondContentArr)
        {
            int line = 1;
            if (firstContentArr.Length <= secondContentArr.Length)
            {
                for (int i = 0; i < firstContentArr.Length; i++)
                {
                    if (firstContentArr[i] == secondContentArr[i])
                    {
                        Console.WriteLine($"{line} line is equal.");
                    }
                    else
                    {
                        Console.WriteLine($"{line} line is not equal.");
                    }
                    line++;
                }
            }
            else
            {
                for (int i = 0; i < secondContentArr.Length; i++)
                {
                    if (secondContentArr[i] == firstContentArr[i])
                    {
                        Console.WriteLine($"{line} line is equal.");
                    }
                    else
                    {
                        Console.WriteLine($"{line} line is not equal.");
                    }
                    line++;
                }
            }
        }
    }
}
