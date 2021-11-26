//using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.IO;
using System.Text.Json;
using System.Collections.Specialized;

namespace lesson8_
{
    public class Options
    {
        public const string MyOptions = "MyOptions";

        public string Hello = "Hello";
        public string Name { get; set; }
        public string Age { get; set; }
        public string TypeOfActivity { get; set; }
    }

    class Program
    {
        public static void SerializeToJson(Options myOptions)
        {
            using (FileStream fs = new FileStream("appsettings.json", FileMode.Create))
            {
                JsonSerializer.Serialize<Options>(fs, myOptions);
            }
        }
        static void Main(string[] args)
        {
            //------ Конфигурация при помощи Json ------
            //Options myOptions = new Options();
            //var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            //configuration.GetSection("MyOptions").Bind(myOptions);
            //if(myOptions.Age != "No" && myOptions.Age != "No" && myOptions.Age != "No")
            //{
            //    Console.WriteLine($"{myOptions.Hello}, {myOptions.Name}!");
            //    Console.WriteLine($"Name: {myOptions.Name}, Age: {myOptions.Age}, Type of activity: {myOptions.TypeOfActivity}");
            //}
            //else
            //{
            //    Options info = new Options();
            //    Console.WriteLine("Enter information about yourself");
            //    Console.WriteLine("Name:");
            //    info.Name = Console.ReadLine();
            //    Console.WriteLine("Age");
            //    info.Age = Console.ReadLine();
            //    Console.WriteLine("Type of activity:");
            //    info.TypeOfActivity = Console.ReadLine();
            //    SerializeToJson(info);
            //}

            string nameWrite = String.Empty;
            string ageWrite = String.Empty;
            string typeOfActivityWrite = String.Empty;
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("Name")))
            {
                Console.WriteLine("Enter information about yourself");
                Console.WriteLine("Name:");
                settings["Name"].Value = Console.ReadLine();
                Console.WriteLine("Age");
                settings["Age"].Value = Console.ReadLine();
                Console.WriteLine("Type of activity:");
                settings["TypeOfActivity"].Value = Console.ReadLine();
            }
            Console.WriteLine($"{ConfigurationManager.AppSettings.Get("Hello")}, {ConfigurationManager.AppSettings.Get("Name")}!");
            Console.WriteLine($"Name: {ConfigurationManager.AppSettings.Get("Name")}, Age: {ConfigurationManager.AppSettings.Get("Age")}, Type of activity: {ConfigurationManager.AppSettings.Get("TypeOfActivity")}");

        }
    }
}
