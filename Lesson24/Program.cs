using System;

namespace Lesson24
{
    class Program
    {
        class Product
        {
            //поля класса Product
            public int article; //артикул
            public string nameProduct; //наименование продукта
            public string size; //размер
            public string color; //цвет
            public int count; //количество
            public double price; //цена
            public double vat; //НДС

            //методы класса Product
            public int GetInfo(int centerX, int numString)
            {
                Console.SetCursorPosition(centerX, numString);
                Console.WriteLine($"{article} {nameProduct} {size} {color}");
                numString++;
                Console.SetCursorPosition(centerX, numString);
                Console.WriteLine($"{count}*{price}                           ={count * price}");
                numString++;
                Console.SetCursorPosition(centerX, numString);
                Console.WriteLine($"НДС: {vat}%");
                return numString;
            }
        }
        static void Main(string[] args)
        {
            string nameShop = "H&M"; //название магазина
            string nameOrg = "ООО Эйч энд Эм Хеннес энд Мауриц"; //наименование организации
            int znkkt = 490633; //ЗН ККТ
            long fn = 9282440300780638; //ФН
            string nameСashier = "Елена Андреевна Немирова"; //ФИО кассира
            int IDСashier = 49063; // ID кассира
            int IDShop = 32065; // ID магазина
            int numСheque = 1652; // номер чека
            string date = "28.10.2021"; // дата покупки
            int numBoxOffice = 2; // номер кассы
            string time = "20:06"; // время покупки
            long numFiscalCheck = 0000421754003168; // номер фискального чека
            int positionXleft = (Console.WindowWidth / 2) - (znkkt.ToString().Length / 2) - fn.ToString().Length; // позиция крайне левая
            int numString = 0; // номер строки
            int countProduct = 0;
            string city = "Санкт-Петербург";
            string address = "ш. Петергофское, д. 47";

            Product cap = new Product { article = 0984662, nameProduct = "Шапка", size = "ONESIZE", color = "Серый", count = 2, price = 899, vat = 20 };
            countProduct++;
            Product trousers = new Product { article = 1017631, nameProduct = "Брюки", size = "36", color = "Синий", count = 1, price = 2299, vat = 20 };
            countProduct++;

            int centerX = (Console.WindowWidth / 2) - (nameShop.Length / 2);
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine(nameShop);
            numString++;
            centerX = (Console.WindowWidth / 2) - (nameOrg.Length / 2);
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine(nameOrg);
            numString++;
            centerX = (Console.WindowWidth / 2) - ("КАССОВЫЙ ЧЕК".Length / 2);
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine("КАССОВЫЙ ЧЕК");
            numString++;
            centerX = positionXleft;
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine("ЗН ККТ: " + znkkt);
            numString++;
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine("ФН: " + fn);
            numString++;
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine("КАССИР:" + nameСashier);
            numString++;
            centerX = (Console.WindowWidth / 2) - ("ПРИХОД".Length / 2);
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine("ПРИХОД");
            numString++;
            for (int i = positionXleft; i < (Console.WindowWidth / 2 - positionXleft) * 2 + positionXleft; i++)
            {
                Console.SetCursorPosition(i, numString);
                Console.Write("-");
            }
            numString++;
            centerX = positionXleft;
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine($"Кассир: {IDСashier} Магазин: {IDShop} Чек: {numСheque}");
            numString++;
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine($"Дата: {date} Касса: {numBoxOffice} Время: {time}");
            numString++;
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine($"Фискальный чек: {numFiscalCheck}");
            numString++;
            for (int i = positionXleft; i < (Console.WindowWidth / 2 - positionXleft) * 2 + positionXleft; i++)
            {
                Console.SetCursorPosition(i, numString);
                Console.Write("-");
            }
            numString++;
            numString = cap.GetInfo(centerX, numString);
            numString++;
            numString = trousers.GetInfo(centerX, numString);
            numString++;
            centerX = positionXleft;
            Console.SetCursorPosition(centerX, numString);
            Console.Write("Количество товаров: ");
            centerX = (Console.WindowWidth / 2 - positionXleft) * 2 + positionXleft - countProduct.ToString().Length;
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine(countProduct);
            numString++;
            centerX = positionXleft;
            Console.SetCursorPosition(centerX, numString);
            Console.Write("ИТОГ:");
            double sum = Math.Round((cap.price * cap.count + trousers.price * trousers.count), 2);
            centerX = (Console.WindowWidth / 2 - positionXleft) * 2 + positionXleft - sum.ToString().Length;
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine(sum);
            numString++;
            centerX = positionXleft;
            Console.SetCursorPosition(centerX, numString);
            Console.Write("Сумма НДС:");
            double sumVAT = Math.Round((((cap.vat * cap.price) / 100) * cap.count + ((trousers.vat * trousers.price) / 100) * trousers.count), 2);
            centerX = (Console.WindowWidth / 2 - positionXleft) * 2 + positionXleft - sumVAT.ToString().Length;
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine(sumVAT);
            numString++;
            centerX = (Console.WindowWidth / 2) - (city.Length / 2);
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine(city);
            numString++;
            centerX = (Console.WindowWidth / 2) - (address.Length / 2);
            Console.SetCursorPosition(centerX, numString);
            Console.WriteLine(address);
        }
    }
}
