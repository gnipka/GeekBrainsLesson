using System;
using System.Linq;

namespace Lesson7
{

    //Задача о рюкзаке

    class Program
    {
        public static int[,] SortArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0) - 1; j++)
                {
                    if (array[j, 1] < array[j + 1, 1])
                    {
                        int value = array[j, 1];
                        int valueIndex = array[j, 0];
                        array[j, 0] = array[j + 1, 0];
                        array[j, 1] = array[j + 1, 1];
                        array[j + 1, 0] = valueIndex;
                        array[j + 1, 1] = value;
                    }
                }
            }
            return array;
        }
        public static void GetPackagedBag(int maxWeight, int[] itemsPrice, int[] itemsWeight, string[] itemsName)
        {
            int[,] itemsMultPriceWeight = new int[itemsWeight.Length, 2];
            string index = null;
            int maxPrice = 0;
            for (int i = 0; i < itemsWeight.Length; i++)
            {
                itemsMultPriceWeight[i, 0] = i;
                itemsMultPriceWeight[i, 1] = itemsPrice[i] * itemsWeight[i];
            }
            itemsMultPriceWeight = SortArray(itemsMultPriceWeight);
            for (int i = 0; i < itemsWeight.Length; i++)
            {
                if (maxWeight - itemsWeight[itemsMultPriceWeight[i, 0]] >= 0)
                {
                    maxWeight -= itemsWeight[itemsMultPriceWeight[i, 0]];
                    index += (itemsMultPriceWeight[i, 0].ToString() + " ");
                }
            }
            Console.WriteLine("В рюкзак вместились вещи:");

            int[] indexRes = index.Trim().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < indexRes.Length; i++)
            {
                Console.WriteLine($"Наименование: {itemsName[indexRes[i]]}, Вес: {itemsWeight[indexRes[i]]}, Стоимость: {itemsPrice[indexRes[i]]}");
                maxPrice += itemsMultPriceWeight[indexRes[i], 1];
            }
            Console.WriteLine($"Максимальная цена : {maxPrice}");
        }

        static void Main(string[] args)
        {
            string[] itemsName;
            int[] itemsPrice;
            int[] itemsWeight;
            Console.WriteLine("0 - выйти из программы");
            Console.WriteLine("1 - решить задачу о рюкзаке");
            switch (Console.ReadLine().Trim())
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("Введите максимальную грузоподъемность рюкзака");
                    int maxWeight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите сколько вещей вы хотите поместить в рюкзак");
                    int count = Convert.ToInt32(Console.ReadLine());
                    itemsName = new string[count];
                    itemsPrice = new int[count];
                    itemsWeight = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("Введите наименование вещи");
                        itemsName[i] = Console.ReadLine();
                        Console.WriteLine("Введите стоимость вещи за одну единицу размерности рюкзака");
                        itemsPrice[i] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите вес вещи");
                        itemsWeight[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    GetPackagedBag(maxWeight, itemsPrice, itemsWeight, itemsName);
                    break;
            }
        }
    }
}
