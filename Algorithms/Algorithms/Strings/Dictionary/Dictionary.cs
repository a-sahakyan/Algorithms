using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings.Dictionary
{
    class Dictionary
    {
        /// <summary>
        /// Reads words from the console and gives an explanation.
        /// </summary>
        public void GetExplenation()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add(".NET", "platform for applications from Microsoft");
            dic.Add("CLR", "managed execution environment for .NET");
            dic.Add("namespace", "hierarchical organization of classes");

            while (true)
            {
                Console.WriteLine("enter a word to get explenation.");
                string word = Console.ReadLine();
                if (word != null)
                {
                    string result = dic.ContainsKey(word.ToUpper()) ? dic[word.ToUpper()] :
                    dic.ContainsKey(word.ToLower()) ? dic[word.ToLower()] :
                    "There is no such a word.";
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Please add a word.");
                }
            }
        }
    }
}
