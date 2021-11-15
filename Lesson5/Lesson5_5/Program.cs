using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Lesson5_5
{
    [Serializable]
    public class ToDo
    {
        [XmlElement("Title")]
        public string Title { get; set; }
        [XmlAttribute("IsDone")]
        public string IsDone { get; set; }
        public ToDo() { }
    }
    [Serializable]
    public class ListToDo
    {
        [XmlArray("tasks"), XmlArrayItem("task")]
        public List<ToDo> tasks { get; set; }
        public ListToDo() { }
    }
    class Program
    {
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
                Console.WriteLine("Введенное число некорректно!");
                return false;
            }
        }
        public static void SerializeToXml(ListToDo listToDo)
        {
            StringWriter stringWriterNewIsDone = new StringWriter();
            XmlSerializer serializerNewIsDone = new XmlSerializer(typeof(ListToDo));
            serializerNewIsDone.Serialize(stringWriterNewIsDone, listToDo);
            string xmlNewIsDone = stringWriterNewIsDone.ToString();
            File.WriteAllText("tasks.xml", xmlNewIsDone);
        }

        public static ListToDo DeserializeFromXml()
        {
            string xmlText = File.ReadAllText("tasks.xml");
            StringReader stringReader = new StringReader(xmlText);
            XmlSerializer serializer = new XmlSerializer(typeof(ListToDo));
            return (ListToDo)serializer.Deserialize(stringReader);
        }

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("0 - выйти из программы");
                Console.WriteLine("1 - вывести список задач");
                Console.WriteLine("2 - отметить выполненную задачу");
                Console.WriteLine("3 - добавить задачу");
                Console.WriteLine("4 - удалить задачу");
                string answer = Console.ReadLine();

                ListToDo listToDo = new ListToDo();



                switch (answer.Trim())
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        if (listToDo.tasks != null)
                        {
                            listToDo.tasks.Clear();
                        }
                        listToDo = DeserializeFromXml();
                        for (int i = 0; i < listToDo.tasks.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. { listToDo.tasks[i].IsDone} { listToDo.tasks[i].Title}");
                        }
                        break;
                    case "2":
                        if (listToDo.tasks != null)
                        {
                            listToDo.tasks.Clear();
                        }
                        listToDo = DeserializeFromXml();
                        for (int i = 0; i < listToDo.tasks.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. { listToDo.tasks[i].IsDone} { listToDo.tasks[i].Title}");
                        }
                        Console.WriteLine("Введите номер задачи, которую хотите удалить");
                        string numTask = Console.ReadLine();
                        if (IsNum(numTask))
                        {
                            if (0 <= (Convert.ToInt32(numTask) - 1) && Convert.ToInt32(numTask) < listToDo.tasks.Count)
                            {
                                listToDo.tasks[Convert.ToInt32(numTask) - 1].IsDone = "[X]";
                                SerializeToXml(listToDo);
                            }
                            else
                            {
                                Console.WriteLine("Задачи с таким номером не существует");
                            }
                        }

                        break;
                    case "3":
                        Console.WriteLine("Введите задачу");
                        string task = Console.ReadLine();
                        if (listToDo.tasks != null)
                        {
                            listToDo.tasks.Clear();
                        }
                        listToDo.tasks = new List<ToDo>();
                        ToDo toDo = new ToDo { Title = task, IsDone = "[O]" };
                        if (File.Exists("tasks.xml"))
                        {
                            listToDo = DeserializeFromXml();
                        }
                        listToDo.tasks.Add(toDo);
                        SerializeToXml(listToDo);
                        break;
                    case "4":
                        if (listToDo.tasks != null)
                        {
                            listToDo.tasks.Clear();
                        }
                        listToDo = DeserializeFromXml();
                        for (int i = 0; i < listToDo.tasks.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. { listToDo.tasks[i].IsDone} { listToDo.tasks[i].Title}");
                        }
                        Console.WriteLine("Введите номер задачи, которую хотите удалить");
                        string numDelTask = Console.ReadLine();
                        if (IsNum(numDelTask))
                        {
                            if (0 <= (Convert.ToInt32(numDelTask) - 1) && Convert.ToInt32(numDelTask) < listToDo.tasks.Count)
                            {
                                listToDo.tasks.RemoveAt(Convert.ToInt32(numDelTask) - 1);
                                SerializeToXml(listToDo);
                            }
                            else
                            {
                                Console.WriteLine("Задачи с таким номером не существует");
                            }
                        }
                        break;
                }
            }

        }
    }
}