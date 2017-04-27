using System;

namespace Algorithms.Strings.Dictionary2
{
    class Dictionary2
    {
        private string[] key = new string[5];
        private string[] value = new string[5];

        public Dictionary2()
        {
            key[0] = ".NET"; value[0] = "platform for applications from Microsoft";
            key[1] = "CLR"; value[1] = "managed execution environment for .NET";
            key[2] = "namespace"; value[2] = "hierarchical organization of classes";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return $"{key[i]} - {value[i]}";
                }
                return "There aren't such a word";
            }
        }

        public void Search()
        {
            while (true)
            {
                Dictionary2 dictionary = new Dictionary2();
                string key = Console.ReadLine();
                Console.WriteLine($"{dictionary[key]}");
            }
        }
    }
}
