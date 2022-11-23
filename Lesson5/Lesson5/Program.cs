using System;
using System.IO;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string filename;
                Console.WriteLine("1 - сохранить строку в новый файл");
                Console.WriteLine("2 - сохранить строку в существующий файл");
                Console.WriteLine("0 - выйти из программы");
                string str = Console.ReadLine();
                string strForFile;
                switch (Convert.ToInt32(str))
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Введите имя для нового файла");
                        filename = Console.ReadLine();
                        Console.WriteLine("Введите строку для записи в файл");
                        strForFile = Console.ReadLine();
                        File.AppendAllText(filename, strForFile);
                        File.AppendAllText(filename, Environment.NewLine); // перенос строки
                        Console.WriteLine("Строка сохранена в файл: " + filename);
                        break;
                    case 2:
                        Console.WriteLine("Введите имя файла");
                        filename = Console.ReadLine();
                        while (File.Exists(filename))
                        {
                            Console.WriteLine("1 - добавить строку в файл");
                            Console.WriteLine("2 - перезаписать файл");
                            str = Console.ReadLine();
                            if (str.Trim() == "1" || str.Trim() == "2")
                            {
                                if (str.Trim() == "1")
                                {
                                    Console.WriteLine("Введите строку для записи в файл");
                                    strForFile = Console.ReadLine();
                                    File.AppendAllText(filename, strForFile);
                                    File.AppendAllText(filename, Environment.NewLine); // перенос строки
                                    Console.WriteLine("Строка сохранена в файл: " + filename);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Введите строку для записи в файл");
                                    strForFile = Console.ReadLine();
                                    File.WriteAllText(filename, strForFile);
                                    Console.WriteLine("Строка сохранена в файл: " + filename);
                                    break;
                                }
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Введите корректные данные");
                        break;
                }
            }
        }
    }
}
