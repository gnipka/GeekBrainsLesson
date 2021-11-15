using System;

namespace Lesson_4
{
    class Program
    {
        public static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return lastName + " " + firstName + " " + patronymic;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Анна", "Гнипель", "Владимировна"));
            Console.WriteLine(GetFullName("Антон", "Гусев", "Александрович"));
            Console.WriteLine(GetFullName("Сергей", "Чумаков", "Иванович"));
            Console.WriteLine(GetFullName("Елизавета", "Шаманова", "Сергеевна"));
        }
    }
}
