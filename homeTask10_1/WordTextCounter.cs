using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeTask10_1
{
    internal class WordTextCounter
    {
            int counter = 0;
            string Text = string.Empty;

            Dictionary<string, int> dictionary;

            public WordTextCounter(string value)
            {
                dictionary = new Dictionary<string, int>();
                Text = value;
            }

            public void TextCounter()
            {
                string[] sub = Text.Split(' ', '\t', '-', '.', '\n', '1', '2');
                for (int i = 0; i < sub.Length - 1; i++)
                {
                    counter = 0;
                    for (int j = 0; j < sub.Length - 1; j++)
                    {
                        if (sub[i] == sub[j])
                        {
                            counter++;
                        }
                    }

                    if (counter != 0 && !dictionary.ContainsKey(sub[i]))
                    {
                        dictionary.Add(sub[i], counter);
                    }
                }
            }

            public void Print()
            {
                foreach (var item in dictionary)
                {
                    Console.WriteLine(item);
                }
            }

    }
}
