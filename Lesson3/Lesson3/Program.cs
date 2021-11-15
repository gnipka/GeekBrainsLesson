using System;

namespace Lesson3
{
    class Program
    {
        public static void OutputArray(double[,] array)
        {
            for (int i = 0, j = 0; i < array.GetUpperBound(0) + 1 && j < array.GetUpperBound(1) + 1; i++, j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите 1, если хотите сами заполнить массив");
                Console.WriteLine("Введите 2, чтобы вывести рандомный массив");
                Console.WriteLine("Введите 0, чтобы выйти из программы");

                string answer = Console.ReadLine().Trim();
                double[,] array;
                int countRows = 0;
                int countColumns = 0;

                switch (answer)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        Console.WriteLine("Укажите количество строк массива");
                        countRows = Convert.ToInt32(Console.ReadLine().Trim());
                        Console.WriteLine("Укажите количество столбцов массива");
                        countColumns = Convert.ToInt32(Console.ReadLine().Trim());
                        array = new double[countRows, countColumns];
                        for (int i = 0; i < countRows; i++)
                        {
                            for (int j = 0; j < countColumns; j++)
                            {
                                Console.Write($"Введите [{i + 1}][{j + 1}] элемент массива:");
                                array[i, j] = Convert.ToDouble(Console.ReadLine().Trim());
                            }
                        }
                        for (int i = 0; i < countRows; i++)
                        {
                            for (int j = 0; j < countColumns; j++)
                            {
                                Console.Write(array[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Элементы диагонали массива:");
                        OutputArray(array);
                        break;
                    case "2":
                        Random rnd = new Random();
                        Console.WriteLine("Укажите количество строк массива");
                        countRows = Convert.ToInt32(Console.ReadLine().Trim());
                        Console.WriteLine("Укажите количество столбцов массива");
                        countColumns = Convert.ToInt32(Console.ReadLine().Trim());
                        array = new double[countRows, countColumns];
                        for (int i = 0; i < countRows; i++)
                        {
                            for (int j = 0; j < countColumns; j++)
                            {
                                array[i, j] = rnd.Next(0, 99);
                                Console.Write(array[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Элементы диагонали массива:");
                        OutputArray(array);
                        break;
                }
            }
        }
    }
}
