using System;

namespace Lesson2_6
{
    class Program
    {
        //проверка на число
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
                string numberMonthStr = null;
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

                    if (Convert.ToInt32(numberMonthStr) > 0 && Convert.ToInt32(numberMonthStr) < 13)
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

                string nameMonth = null;
                bool isTrue = true;
                string tempMin = null;
                string tempMax = null;
                string weather = null;
                double dailyTemp;
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
                dailyTemp = Math.Round(((Convert.ToDouble(tempMax) + Convert.ToDouble(tempMin)) / 2), 2);

                switch (numberMonth)
                {
                    case 1:
                        nameMonth = "Январь";
                        if (dailyTemp > 0)
                        {
                            weather = "Дождливая зима";
                        }
                        else
                        {
                            weather = "Снежная зима";
                        }
                        break;
                    case 2:
                        nameMonth = "Февраль";
                        if (dailyTemp > 0)
                        {
                            weather = "Дождливая зима";
                        }
                        else
                        {
                            weather = "Снежная зима";
                        }
                        break;
                    case 3:
                        nameMonth = "Март";
                        if (dailyTemp > 5)
                        {
                            weather = "Ранняя весна";
                        }
                        else
                        {
                            weather = "Холодная весна";
                        }
                        break;
                    case 4:
                        nameMonth = "Апрель";
                        if (dailyTemp > 10)
                        {
                            weather = "Теплая весна";
                        }
                        else
                        {
                            weather = "Холодная весна";
                        }
                        break;
                    case 5:
                        nameMonth = "Май";
                        if (dailyTemp > 20)
                        {
                            weather = "Жаркая весна";
                        }
                        else
                        {
                            weather = "Холодная весна";
                        }
                        break;
                    case 6:
                        nameMonth = "Июнь";
                        if (dailyTemp > 25)
                        {
                            weather = "Жаркое лето";
                        }
                        else
                        {
                            weather = "Холодное лето";
                        }
                        break;
                    case 7:
                        nameMonth = "Июль";
                        if (dailyTemp > 25)
                        {
                            weather = "Жаркое лето";
                        }
                        else
                        {
                            weather = "Холодное лето";
                        }
                        break;
                    case 8:
                        nameMonth = "Август";
                        if (dailyTemp > 25)
                        {
                            weather = "Жаркое лето";
                        }
                        else
                        {
                            weather = "Холодное лето";
                        }
                        break;
                    case 9:
                        nameMonth = "Сентябрь";
                        if (dailyTemp > 20)
                        {
                            weather = "Жаркая осень";
                        }
                        else
                        {
                            weather = "Холодная осень";
                        }
                        break;
                    case 10:
                        nameMonth = "Октябрь";
                        if (dailyTemp > 10)
                        {
                            weather = "Теплая осень";
                        }
                        else
                        {
                            weather = "Холодная осень";
                        }
                        break;
                    case 11:
                        nameMonth = "Ноябрь";
                        if (dailyTemp > 5)
                        {
                            weather = "Теплая осень";
                        }
                        else
                        {
                            weather = "Холодная осень";
                        }
                        break;
                    case 12:
                        nameMonth = "Декабрь";
                        if (dailyTemp > 0)
                        {
                            weather = "Дождливая зима";
                        }
                        else
                        {
                            weather = "Снежная зима";
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Не существует месяца под таким номером");
                        break;
                }
                Console.WriteLine("Месяц: " + nameMonth + " Среднесуточная температура: " + dailyTemp);
                Console.WriteLine(weather);
                Console.WriteLine("Для продолжение введите a");
                if (Console.ReadLine() != "a")
                {
                    Environment.Exit(0);
                }

            }
        }
    }
}
