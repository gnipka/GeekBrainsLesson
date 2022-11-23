using System;

namespace Lesson25
{
    class Program
    {
        [Flags]
        public enum Weekdays
        {
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000,
        }
        static void Main(string[] args)
        {
            //Маски офисов
            Weekdays officeFirst = Weekdays.Monday | Weekdays.Tuesday | Weekdays.Wednesday | Weekdays.Thursday | Weekdays.Friday;
            Weekdays officeSecond = Weekdays.Monday | Weekdays.Tuesday | Weekdays.Friday | Weekdays.Saturday;
            Weekdays officeThird = Weekdays.Monday | Weekdays.Tuesday | Weekdays.Wednesday | Weekdays.Thursday | Weekdays.Friday | Weekdays.Saturday | Weekdays.Sunday;

            Console.WriteLine("Office №1 is open: " + officeFirst);
            Console.WriteLine("Office №2 is open: " + officeSecond);
            Console.WriteLine("Office №3 is open: " + officeThird);

        }
    }
}
