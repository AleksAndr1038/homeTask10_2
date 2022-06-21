using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace homeTask10_1
{
    internal class CounterCertainWord
    {
        string Text;
        string word;
        int count = 0;

        public CounterCertainWord(string value)
        {
            Text = value;
        }

        public void WordCounter()
        {
            string[] textArray = Text.Split(' ', '\t', '-', '.', '\n', '1', '2');
            WriteLine("Введите слово");
            word = Convert.ToString(ReadLine());

            for (int i = 0; i < textArray.Length - 1; i++)
            {
                if (textArray[i].Equals(word))
                {
                    count++;
                }
            }

            WriteLine($"Данное слово встречается {count} раз");
        }
    }
}
