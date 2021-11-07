using System;

namespace Lesson2_
{
    class Program
    {
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
            while (true)
            {
                Console.WriteLine("Введите число:");
                string str = Console.ReadLine();
                int number = Convert.ToInt32(str);
                string numFinal = null;
                int count;

                if (IsNum(str))
                {
                    Console.WriteLine("Введите число (от 1 до  до 3999):");
                    str = Console.ReadLine();
                }
                number = Convert.ToInt32(str);
                if (number > 1 && number < 4000)
                {

                    if (number - 900 >= 0)
                    {
                        if (number - 1000 < 0)
                        {
                            numFinal += "CM";
                            number -= 900;
                        }
                        else
                        {
                            count = number / 1000;
                            for (int i = 0; i < count; i++)
                            {
                                numFinal += "M";
                                number -= 1000;
                            }
                        }
                    }
                    if (number - 400 >= 0)
                    {
                        if (number - 500 < 0)
                        {
                            numFinal += "CD";
                            number -= 400;
                        }
                        else
                        {
                            numFinal += "D";
                            number -= 500;
                        }
                    }
                    if (number - 90 >= 0)
                    {
                        if (number - 100 < 0)
                        {
                            numFinal += "XC";
                            number -= 90;
                        }
                        else
                        {
                            count = number / 100;
                            for (int i = 0; i < count; i++)
                            {
                                numFinal += "C";
                                number -= 100;
                            }
                        }
                    }
                    if (number - 40 >= 0)
                    {
                        if (number - 50 < 0)
                        {
                            numFinal += "XL";
                            number -= 40;
                        }
                        else
                        {
                            numFinal += "L";
                            number -= 50;
                        }
                    }
                    if (number - 9 >= 0)
                    {
                        if (number - 10 < 0)
                        {
                            numFinal += "IX";
                            number -= 90;
                        }
                        else
                        {
                            count = number / 10;
                            for (int i = 0; i < count; i++)
                            {
                                numFinal += "X";
                                number -= 10;
                            }
                        }
                    }
                    if (number - 4 >= 0)
                    {
                        if (number - 5 < 0)
                        {
                            numFinal += "IV";
                            number -= 4;
                        }
                        else
                        {
                            numFinal += "V";
                            number -= 5;
                        }
                    }
                    if (number > 0 && number < 4)
                    {
                        count = number;
                        for (int i = 0; i < count; i++)
                        {
                            numFinal += "I";
                            number -= 1;
                        }
                    }

                    Console.WriteLine(numFinal);
                    Console.WriteLine("Чтобы продолжить работу введите 0");
                    if (Console.ReadLine() != "0")
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Введите число в диапозоне от 1 до 3999");
                }
            }
        }
    }
}
