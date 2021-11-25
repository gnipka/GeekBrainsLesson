using System;
using System.Diagnostics;

namespace Lesson6
{
    class Program
    {
        public static string ByteInKByte(Process process)
        {
            if(process.VirtualMemorySize64 > 1024)
            {
                return ($"{process.VirtualMemorySize64 / 1024} КБ");
            }
            return ($"{process.VirtualMemorySize64} КБ");
        }
        public static void OutputProcess(Process[] processes)
        {
            var positionX = new int[] { 0, 39, 48, 60 };
            Console.WriteLine("Имя образа                            PID      №Сеанса      Память");
            Console.WriteLine("------------------------------------- -------- ------------ ---------- ");

            foreach (var process in processes)
            {
                int positionY = Console.CursorTop + 1;
                Console.SetCursorPosition(positionX[0], positionY);
                Console.Write(process.ProcessName);
                Console.SetCursorPosition(positionX[1], positionY);
                Console.Write(process.Id);
                Console.SetCursorPosition(positionX[2], positionY);
                Console.Write(process.SessionId);
                Console.SetCursorPosition(positionX[3], positionY);
                Console.Write(ByteInKByte(process));
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("0 - выйти из программы");
                Console.WriteLine("1 - вывести все запущенные процессы");
                Console.WriteLine("2 - запустить процесс");
                Console.WriteLine("3 - завершить процесс");
                switch (Console.ReadLine().Trim())
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        Process[] processes = Process.GetProcesses();
                        OutputProcess(processes);
                        break;
                    case "3":
                        Console.WriteLine("1 - завершить процесс по имени");
                        Console.WriteLine("2 - завершить процесс по ID");

                        switch (Console.ReadLine().Trim())
                        {

                            case "1":
                                Console.WriteLine("Введите имя процесса");
                                Process[] processesDel = Process.GetProcessesByName(Console.ReadLine().Trim());
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("1 - завершить все процессы с именем " + processesDel[0].ProcessName);
                                        Console.WriteLine("2 - завершить по ID процесса");
                                        break;
                                    }
                                    catch (IndexOutOfRangeException)
                                    {
                                        Console.WriteLine("Процесса с таким именем не существует!");
                                    }
                                    Console.WriteLine("Введите имя процесса");
                                    processesDel = Process.GetProcessesByName(Console.ReadLine().Trim());
                                }
                                switch (Console.ReadLine().Trim())
                                {
                                    case "1":
                                        foreach (var process in processesDel)
                                        {
                                            process.Kill();
                                        }
                                        Console.WriteLine("Процессы завершены");
                                        break;
                                    case "2":
                                        Console.WriteLine("Введите ID процесса");
                                        Process processDelID = Process.GetProcessById(Convert.ToInt32(Console.ReadLine().Trim()));
                                        processDelID.Kill();
                                        Console.WriteLine("Процесс завершен с кодом " + processDelID.ExitCode);
                                        break;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Введите ID процесса");
                                while (true) 
                                {
                                    try
                                    {
                                        Process processDelByID = Process.GetProcessById(Convert.ToInt32(Console.ReadLine().Trim()));
                                        processDelByID.Kill();
                                        Console.WriteLine("Процесс завершен с кодом " + processDelByID.ExitCode);
                                        break;
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Процесса с таким ID не существует!");
                                    }
                                    Console.WriteLine("Введите ID процесса");
                                }
                                break;
                            default:
                                Console.WriteLine("Введены некорректные данные!");
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("1 - запустить процесс без передачи аргументов");
                        Console.WriteLine("2 - запустить процесс и передать аргументы");
                        switch (Console.ReadLine().Trim())
                        {
                            case "1":
                                while (true)
                                {
                                    Console.WriteLine("Введите имя файла процесса");
                                    try
                                    {
                                        ProcessStartInfo startInfo = new ProcessStartInfo(Console.ReadLine());
                                        Process.Start(startInfo);
                                        Console.WriteLine("Процесс запущен");
                                        break;
                                    }
                                    catch (System.ComponentModel.Win32Exception)
                                    {
                                        Console.WriteLine("Файла не существует");
                                    }
                                }
                                break;
                            case "2":
                                while (true)
                                {
                                    Console.WriteLine("Введите имя файла процесса");
                                    string nameFile = Console.ReadLine().Trim();
                                    Console.WriteLine("Введите атрибуты процесса");
                                    string attribute = Console.ReadLine().Trim();
                                    try
                                    {
                                        Process.Start(nameFile, attribute);
                                        Console.WriteLine("Процесс запущен");
                                        break;
                                    }
                                    catch (System.ComponentModel.Win32Exception)
                                    {
                                        Console.WriteLine("Файла не существует");
                                    }
                                }
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Введены некорректные данные!");
                        break;
                        
                }
            }
        }
    }
}
