// Decompiled with JetBrains decompiler
// Type: Lesson7.Program
// Assembly: Lesson7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9FC1546D-0C83-435D-A518-272DA6BCFEB8
// Assembly location: C:\Users\admin\Desktop\geekbrains\Lesson7Patch\Lesson7Patch.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson7
{
  internal class Program
  {
        public static int[,] SortArray(int[,] array)
        {
            for (int index1 = 0; index1 < array.GetLength(0); ++index1)
            {
                for (int index2 = 0; index2 < array.GetLength(0) - 1; ++index2)
                {
                    if (array[index2, 1] < array[index2 + 1, 1])
                    {
                        int num1 = array[index2, 1];
                        int num2 = array[index2, 0];
                        array[index2, 0] = array[index2 + 1, 0];
                        array[index2, 1] = array[index2 + 1, 1];
                        array[index2 + 1, 0] = num2;
                        array[index2 + 1, 1] = num1;
                    }
                }
            }
            return array;
        }

        public static void GetPackagedBag(
          int maxWeight,
          int[] itemsPrice,
          int[] itemsWeight,
          string[] itemsName)
        {
            int[,] array1 = new int[itemsWeight.Length, 2];
            string str = (string)null;
            int num = 0;
            for (int index = 0; index < itemsWeight.Length; ++index)
            {
                array1[index, 0] = index;
                array1[index, 1] = itemsPrice[index] * itemsWeight[index];
            }
            int[,] numArray = Program.SortArray(array1);
            for (int index = 0; index < itemsWeight.Length; ++index)
            {
                if (maxWeight - itemsWeight[numArray[index, 0]] >= 0)
                {
                    maxWeight -= itemsWeight[numArray[index, 0]];
                    str = str + numArray[index, 0].ToString() + " ";
                }
            }
            Console.WriteLine("В рюкзак вместились вещи:");
            int[] array2 = ((IEnumerable<string>)str.Trim().Split(' ')).Select<string, int>(new Func<string, int>(int.Parse)).ToArray<int>();
            for (int index = 0; index < array2.Length; ++index)
            {
                Console.WriteLine(string.Format("Наименование: {0}, Вес: {1}, Стоимость: {2}", (object)itemsName[array2[index]], (object)itemsWeight[array2[index]], (object)itemsPrice[array2[index]]));
                num += numArray[array2[index], 1];
            }
            Console.WriteLine(string.Format("Максимальная цена : {0}", (object)num));
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("0 - выйти из программы");
            Console.WriteLine("1 - решить задачу о рюкзаке");
            string str = Console.ReadLine().Trim();
            if (!(str == "0"))
            {
                if (str == "1")
                    return;
                Console.WriteLine("Введите максимальную грузоподъемность рюкзака");
                int int32_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите сколько вещей вы хотите поместить в рюкзак");
                int int32_2 = Convert.ToInt32(Console.ReadLine());
                string[] itemsName = new string[int32_2];
                int[] itemsPrice = new int[int32_2];
                int[] itemsWeight = new int[int32_2];
                for (int index = 0; index < int32_2; ++index)
                {
                    Console.WriteLine("Введите наименование вещи");
                    itemsName[index] = Console.ReadLine();
                    Console.WriteLine("Введите стоимость вещи за одну единицу размерности рюкзака");
                    itemsPrice[index] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите вес вещи");
                    itemsWeight[index] = Convert.ToInt32(Console.ReadLine());
                }
                Program.GetPackagedBag(int32_1, itemsPrice, itemsWeight, itemsName);
            }
            else
                Environment.Exit(0);
        }
    }
}
