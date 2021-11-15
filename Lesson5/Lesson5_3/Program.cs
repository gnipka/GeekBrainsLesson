using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Lesson5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа от 0 до 255 через пробел");
            string str = Console.ReadLine();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                // сериализуем весь массив people
                formatter.Serialize(fs, str);

                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                Console.WriteLine((string)formatter.Deserialize(fs));
            }

        }
    }
}
