using System;

namespace Lesson23
{
    class Program
    {
        //проверка на double
        public static bool IsNum(string str)
        {
            double num;
            bool isNum = double.TryParse(str, out num);
            if (isNum)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Введенное число некорректно!");
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Для выхода из программы введите: 00");
            while (true)
            {
                Console.WriteLine("Введите число");
                string number = Console.ReadLine();
                if (number == "00")
                {
                    Environment.Exit(0);
                }
                if (IsNum(number))
                {
                    if (Convert.ToDouble(number) % 2 == 0)
                    {
                        Console.WriteLine(number + " - четное число");
                    }
                    else
                    {
                        Console.WriteLine(number + " - нечетное число");
                    }
                }
            }

        }
    }
}
