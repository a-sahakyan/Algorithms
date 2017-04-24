using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings.AlphabethicalOrder
{
    class AlphabethicalOrder
    {
        public void Order()
        {
            Console.WriteLine("Write some letters: ");
            string letters = Console.ReadLine();

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

            Console.WriteLine("sorted letters: ");
            foreach (var item in sortedLetters)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
