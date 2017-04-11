using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Lists.PigLatin
{
    class PigLatin
    {
        /// <summary>
        /// English is translated to Pig Latin by taking the first letter of every word, moving it to the end of the word and adding ‘ay’.
        /// <para>Pig Latin is a language game in which words in English are altered.</para>
        /// </summary>
        public void PigLatinGame()
        {
            List<string> list = new List<string>() { "smile", "pig", "latin", "eat", "happy", "duck", "too" };

            for (int i = 0; i < list.Count; i++)
            {
                bool flag = true;

                List<char> listChar = new List<char>() { };
                foreach (var item in list[i])
                {
                    listChar.Add(item);
                }
                for (int k = 0; k < listChar.Count; k++)
                {
                    if ((listChar[k] == 'a' && flag == true) || (listChar[k] == 'e' && flag == true) || (listChar[k] == 'i' && flag == true) || (listChar[k] == 'o' && flag == true) || (listChar[k] == 'u' && flag == true) || (listChar[k] == 'y' && flag == true))
                    {
                        if (k == 0)
                        {
                            Console.WriteLine($"{list[i]}way");
                            break;
                        }
                        else
                        {
                            int index = 0;
                            while (index < k)
                            {
                                listChar.Add(listChar[0]);
                                listChar.RemoveAt(0);
                                index++;

                            }
                            flag = false;
                        }
                    }

                    if (k == listChar.Count - 1)
                    {
                        for (int j = 0; j < listChar.Count; j++)
                        {
                            if (j == listChar.Count - 1)
                            {
                                Console.Write($"{listChar[j]}ay");
                            }
                            else
                            {
                                Console.Write(listChar[j]);
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
