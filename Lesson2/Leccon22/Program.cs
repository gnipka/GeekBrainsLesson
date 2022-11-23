using System;

namespace Lesson22
{
    class Program
    {
        //проверка на число
        public static bool IsNum(string str)
        {
            int num;
            bool isNum = int.TryParse(str, out num);
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
            Console.WriteLine("Для выхода из программы введите 0");
            while (true)
            {
                string numberMonthStr = null;
                string nameMonth = null;
                int numberMonth;
                bool flag = true;
                while (true)
                {
                    while (flag)
                    {
                        Console.WriteLine("Введите номер месяца");
                        numberMonthStr = Console.ReadLine();
                        flag = IsNum(numberMonthStr);
                    }

                    if (Convert.ToInt32(numberMonthStr) >= 0 && Convert.ToInt32(numberMonthStr) < 13)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введенные данные некорректны, введите номер месяца заново.");
                        flag = true;
                    }
                }
                numberMonth = Convert.ToInt32(numberMonthStr);

                switch (numberMonth)
                {
                    case 1:
                        nameMonth = "Январь";
                        break;
                    case 2:
                        nameMonth = "Февраль";
                        break;
                    case 3:
                        nameMonth = "Март";
                        break;
                    case 4:
                        nameMonth = "Апрель";
                        break;
                    case 5:
                        nameMonth = "Май";
                        break;
                    case 6:
                        nameMonth = "Июнь";
                        break;
                    case 7:
                        nameMonth = "Июль";
                        break;
                    case 8:
                        nameMonth = "Август";
                        break;
                    case 9:
                        nameMonth = "Сентябрь";
                        break;
                    case 10:
                        nameMonth = "Октябрь";
                        break;
                    case 11:
                        nameMonth = "Ноябрь";
                        break;
                    case 12:
                        nameMonth = "Декабрь";
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Не существует месяца под таким номером");
                        break;

                }
                Console.WriteLine(nameMonth);
            }
        }
    }
}
