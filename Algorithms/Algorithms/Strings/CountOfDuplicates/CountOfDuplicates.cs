using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings.CountOfDuplicates
{
    class CountOfDuplicates
    {
        /// <summary>
        /// prints how many times letters occurs in the string.
        /// </summary>
        /// <param name="printSortedLetters">prints in alphabetical order all letters from the input string</param>
        public void FindDuplicates(bool printSortedLetters)
        {
            Console.WriteLine("Add some letters: ");
            string letters = Console.ReadLine();
            List<char> sortedLetters = AlphabethicalOrder(letters, printSortedLetters);

            List<List<char>> sortedJagged = new List<List<char>>();
            for (int i = 0; i < letters.Length; i++)
            {
                sortedJagged.Add(new List<char>());
            }

            int index = 0;
            for (int i = 0; i < sortedLetters.Count; i++)
            {
                if (sortedJagged[index].Contains(sortedLetters[i]) || i == 0)
                {
                    sortedJagged[index].Add(sortedLetters[i]);
                }
                else
                {
                    sortedJagged[++index].Add(sortedLetters[i]);
                }
            }

            Print(sortedJagged);
        }

        private List<char> AlphabethicalOrder(string letters, bool printSortedLetters)
        {
            List<char> sortedLetters = new List<char>();
            for (int i = 0; i < letters.Length; i++)
            {
                sortedLetters.Add(letters[i]);
            }

            for (int i = 0; i < sortedLetters.Count; i++)
            {
                for (int j = i + 1; j < sortedLetters.Count; j++)
                {
                    if (sortedLetters[i] > sortedLetters[j])
                    {
                        char temp = sortedLetters[i];
                        sortedLetters[i] = sortedLetters[j];
                        sortedLetters[j] = temp;
                    }

                }
            }

            if (printSortedLetters)
            {
                Console.WriteLine("sorted letters: ");
                foreach (var item in sortedLetters)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            return sortedLetters;
        }

        private void Print(List<List<char>> sortedJagged)
        {
            for (int i = 0; i < sortedJagged.Count; i++)
            {
                if (sortedJagged[i].Count != 0)
                {
                    Console.WriteLine($"{sortedJagged[i][0]} count: {sortedJagged[i].Count}");
                }
            }
        }
    }
}
