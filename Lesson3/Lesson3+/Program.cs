using System;

namespace Lesson3_
{
    class Program
    {
        public static void OutputArray(string[,] array)
        {
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введите 0, чтобы выйти из программы");
            Console.ResetColor();
            string[,] array = {
                {" ", "А", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И", "К"},
                {"1", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
                {"2", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
                {"3", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
                {"4", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
                {"5", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
                {"6", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
                {"7", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
                {"8", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
                {"9", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
                {"10", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
            };
            while (true)
            {
                OutputArray(array);
                Console.WriteLine("Введите позицию, где хотите расположить корабль (Пример ввода: А5).");
                string position = Console.ReadLine();
                if (position != "0")
                {
                    int index = 0;
                    for (int i = 0; i < array.GetUpperBound(1); i++)
                    {
                        if (array[0, i].Contains(position[0].ToString()))
                        {
                            index = i;
                        }
                    }
                    array[Convert.ToInt32(position[1].ToString()), index] = "X";
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
