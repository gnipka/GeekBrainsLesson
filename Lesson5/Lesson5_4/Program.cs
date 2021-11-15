using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;



namespace Lesson5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "text.txt";
            Console.WriteLine("Введите путь к дирректории");
            string workDir = @$"{Console.ReadLine()}";
            if (Directory.Exists(workDir))
            {
                File.AppendAllText(filename, "Дерево каталогов директории: " + workDir);
                File.AppendAllText(filename, Environment.NewLine);
                Console.WriteLine("С рекурсией:");
                File.AppendAllText(filename, "С рекурсией:");
                File.AppendAllText(filename, Environment.NewLine);
                string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);
                for (int i = 0; i < entries.Length; i++)
                {
                    File.AppendAllText(filename, entries[i]);
                    File.AppendAllText(filename, Environment.NewLine);
                    Console.WriteLine(entries[i]);
                }
                string[] dirs = Directory.GetFileSystemEntries(workDir, "*", SearchOption.TopDirectoryOnly);
                Console.WriteLine("Без рекурсии:");
                File.AppendAllText(filename, "Без рекурсии:");
                File.AppendAllText(filename, Environment.NewLine);
                for (int i = 0; i < dirs.Length; i++)
                {
                    File.AppendAllText(filename, dirs[i]);
                    File.AppendAllText(filename, Environment.NewLine);
                    Console.WriteLine(dirs[i]);
                }
            }
            else
            {
                Console.WriteLine("Данной дирректории не существует");
            }

        }
    }
}