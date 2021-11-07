using System;

namespace Lesson3_3
{
    class Program
    {
        public static void OutputString(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите 0, чтобы выйти из программы");
            var array = new string[5, 2];
            while (true)
            {
                Console.WriteLine("Введите слово:");
                string str = Console.ReadLine();
                if (str != "0")
                {
                    OutputString(str);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
