using System;

namespace Lesson2
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
                return false;
            }
            else
            {
                Console.WriteLine("Введенное число некорректно!");
                return true;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                bool isTrue = true;
                string tempMin = null;
                string tempMax = null;
                while (isTrue)
                {
                    Console.WriteLine("Введите минимальную температуру за сутки");
                    tempMin = Console.ReadLine();
                    isTrue = IsNum(tempMin);
                }
                isTrue = true;
                while (isTrue)
                {
                    Console.WriteLine("Введите максимальную температуру за сутки");
                    tempMax = Console.ReadLine();
                    isTrue = IsNum(tempMax);
                }
                Console.WriteLine("Среднесуточная температура: " + (Convert.ToDouble(tempMin) + Convert.ToDouble(tempMax)) / 2);
                Console.WriteLine("Для продолжение работы введите 0");
                if(Console.ReadLine() != "0")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
