using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings.RemoveDuplicates
{
    class RemoveDuplicates
    {
        /// <summary>
        /// Replaces every sequence of identical letters in it with a single letter.
        /// </summary>
        public void Remove()
        {
            Console.WriteLine("Add some letters:");
            string letters = Console.ReadLine();
            List<char> listLetters = new List<char>();

            for (int i = 0; i < letters.Length; i++)
            {
                listLetters.Add(letters[i]);
            }

            for (int i = 0; i < listLetters.Count; i++)
            {
                for (int j = i + 1; j < listLetters.Count; j++)
                {
                    if (listLetters[i] == listLetters[j])
                    {
                        listLetters.RemoveAt(j);
                        j--;
                    }
                }
            }

            Print(listLetters);
        }

        public void Print(List<char> listLetters)
        {
            StringBuilder build = new StringBuilder();
            foreach (var item in listLetters)
            {
                build.Append(item).Append(" ");
            }

            Console.WriteLine(build);
        }
    }
}
