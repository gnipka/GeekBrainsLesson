using System;

namespace Lesson_4_
{
    class Program
    {
        public static void GetFibonacci(int count, int numFirst, int numSecond)
        {
           if(count == 0)
            {
                return;
            };
            int sum = numFirst + numSecond;
            count--;
            numFirst = numSecond;
            numSecond = sum;
            Console.Write(numSecond + " ");
            GetFibonacci(count, numFirst, numSecond);
            
        }
        public static bool IsNum(string str)
        {
            int num;
            bool isNum = int.TryParse(str, out num);
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
            Console.WriteLine("Введите 0, чтобы выйти из программы");
            while (true)
            {
                Console.WriteLine("Сколько вывсести чисел Фибоначчи?");
                string count = Console.ReadLine();
                if (count.Trim() == "0")
                {
                    Environment.Exit(0);
                }
                else
                {
                    if (IsNum(count))
                    {
                        if (Convert.ToInt32(count) == 1)
                        {
                            Console.Write("0");
                        }
                        else if (Convert.ToInt32(count) == 1)
                        {
                            Console.Write("0 1 ");
                        }
                        else
                        {
                            Console.Write("0 1 ");
                            GetFibonacci(Convert.ToInt32(count), 0, 1);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
