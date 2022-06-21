using System;
using System.IO;
using System.Text;
using static System.Console;

namespace homeTask10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Text;
            int CounterString = System.IO.File.ReadAllLines("test.txt").Length;         /*Считает количество строк в тексте*/

            string filePath = "test.txt";

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                {
                    Text = sr.ReadToEnd();
                }
            }

            CounterCertainWord counterCertainWord = new CounterCertainWord(Text);     /*Считает количество заданного слова*/
            counterCertainWord.WordCounter();

            WordTextCounter wordTextCounter = new WordTextCounter(Text);
            wordTextCounter.TextCounter();                                    /*Считает сколько слов вообще*/
            wordTextCounter.Print();


            WriteLine($"Количество строк в тексте {CounterString}");
        }
    }
}
