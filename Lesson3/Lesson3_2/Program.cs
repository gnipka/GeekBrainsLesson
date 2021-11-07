using System;

namespace Lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new string[5, 2];
            while (true)
            {
                Console.WriteLine("Введите 1, чтобы посмотреть телефонный справочник");
                Console.WriteLine("Введите 2, чтобы добавить новый контакт");
                Console.WriteLine("Введите 3, чтобы удалить контакт");
                Console.WriteLine("Введите 0, чтобы выйти из программы");

                string answer = Console.ReadLine().Trim();

                switch (answer)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        if (array[0, 0] == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Телефонный справочник пуст");
                            Console.ResetColor();
                        }
                        else
                        {
                            for (int i = 0; i < 5 && array[i, 0] != null; i++)
                            {
                                Console.Write((i + 1) + "." + array[i, 0] + " " + array[i, 1]);
                                Console.WriteLine();
                            }
                        }

                        break;
                    case "2":
                        if (array[4, 0] != null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Телефонная книжка заполнена.");
                            Console.ResetColor();
                        }
                        else
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (array[i, 0] == null)
                                {
                                    Console.WriteLine("Введите имя контакта");
                                    array[i, 0] = Console.ReadLine();
                                    Console.WriteLine("Введите номер телефона или email");
                                    array[i, 1] = Console.ReadLine();
                                    break;
                                }
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("Введите номер контакта, который хотите удалить");

                        string numberContact = Console.ReadLine();
                        if (numberContact == "1" || numberContact == "2" || numberContact == "3" || numberContact == "4" || numberContact == "5")
                        {
                            array[Convert.ToInt32(numberContact) - 1, 0] = null;
                            array[Convert.ToInt32(numberContact) - 1, 1] = null;
                            for (int i = Convert.ToInt32(numberContact) - 1; i < 5 && array[Convert.ToInt32(numberContact), 0] != null; i++)
                            {
                                array[Convert.ToInt32(numberContact) - 1, 0] = array[Convert.ToInt32(numberContact), 0];
                                array[Convert.ToInt32(numberContact), 0] = null;
                                array[Convert.ToInt32(numberContact) - 1, 1] = array[Convert.ToInt32(numberContact), 1];
                                array[Convert.ToInt32(numberContact), 1] = null;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Такого контакта не существует");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
