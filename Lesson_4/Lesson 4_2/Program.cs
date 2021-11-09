using System;
using System.Linq;

namespace Lesson_4_2
{
    class Program
    {
        public static double ReturnSum(double[] array)
        {
            double sum = 0;
            foreach(var item in array)
            {
                sum += item;
            }
            return sum;
        }
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
                Console.WriteLine("Число введено некорректно!");
                return false;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите 00, чтобы выйти из программы");
                Console.WriteLine("Введите числа");
                string str = Console.ReadLine();
                if (str.Trim() == "00")
                {
                    Environment.Exit(0);
                }
                if (IsNum(str)) 
                {
                        var array = str.Split(' ').Select(double.Parse).ToArray();
                        Console.WriteLine("Сумма чисел: " + ReturnSum(array));
                }
            }
        }
    }
}
