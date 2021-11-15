using System;

namespace Lesson_4_3
{
    class Program
    {
        public static Season ReturnSeasonEnum(int num)
        {
            switch (num)
            {
                case 12:
                case 1:
                case 2:
                    return Season.Winter;
                case 3:
                case 4:
                case 5:
                    return Season.Spring;
                case 6:
                case 7:
                case 8:
                    return Season.Summer;
                case 9:
                case 10:
                case 11:
                    return Season.Autumn;
                default:
                    return Season.Var;
            }
        }

        public static string ReturnSeasonString(Season season)
        {
            switch (season)
            {
                case Season.Winter:
                    return "Winter";
                case Season.Spring:
                    return "Spring";
                case Season.Summer:
                    return "Summer";
                case Season.Autumn:
                    return "Autumn";
                case Season.Var:
                    return "Введите число от 1 до 12";
                default:
                    return "";
            }
        }

        public enum Season 
        {
            Winter,
            Spring,
            Summer,
            Autumn,
            Var
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
                Console.WriteLine("Введите номер месяца");
                string str = Console.ReadLine();
                if (str.Trim() == "0")
                {
                    Environment.Exit(0);
                }
                else
                {
                    if (IsNum(str))
                    {
                        Console.WriteLine(ReturnSeasonString(ReturnSeasonEnum(Convert.ToInt32(str))));
                    }
                    else
                    {
                        Console.WriteLine("Введите число от 1 до 12");
                    }
                }
            }
        }
    }
}
