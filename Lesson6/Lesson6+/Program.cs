using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lesson6_
{
    class Program
    {
        public static void SearchWord(List<string> text)
        {
            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();

            for (int i = 0; i < text.Count; i++)
            {
                int count = text.FindAll(item => item == text[i]).Count;
                if (count > 1)
                {
                    dict.Add(text[i], count);
                    string str = text[i];
                    text.RemoveAll(item => item == str);
                }
                else
                {
                    text.Remove(text[i]);
                }
                if (text.Count == 0)
                {
                    break;
                }
                i = -1;
            }
            int counter = 0;

           if(dict.Count == 0)
            {
                Console.WriteLine("В тексте не обнаружены повторяющиеся слова");
                return;
            }

            foreach (var p in dict.OrderBy(pair => pair.Value).Reverse())
            {
                Console.WriteLine($"{p.Key} повторяется {p.Value} раз");
                counter++;
                if (counter == 10)
                {
                    break;
                }
            }
            return;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("0 - выйти из программы");
                Console.WriteLine("1 - ввести текст из файла");
                Console.WriteLine("2 - ввести текст в ручную");
                string answer = Console.ReadLine();
                switch (answer.Trim())
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        Console.WriteLine("Введите имя файла");
                        string filename = Console.ReadLine();
                        if (File.Exists(filename))
                        {
                            //var text = new List<string>();
                            var text = File.ReadAllText(filename).Split(' ').ToList();
                            SearchWord(text);
                            break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Введите текст");
                        string str = Console.ReadLine();
                        var textFromScreen = str.Split(' ').ToList();
                        SearchWord(textFromScreen);
                        break;
                }
                
            }
        }
    }
}
