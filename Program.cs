using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            Console.WriteLine("Задание 1");
            Console.WriteLine("byte    - " + byte.MaxValue + " - " + byte.MinValue);
            Console.WriteLine("sbyte   - " + sbyte.MaxValue + " - " + sbyte.MinValue);
            Console.WriteLine("short   - " + short.MaxValue + " - " + short.MinValue);
            Console.WriteLine("ushort  - " + ushort.MaxValue + " - " + ushort.MinValue);
            Console.WriteLine("int     - " + int.MaxValue + " - " + int.MinValue);
            Console.WriteLine("uint    - " + uint.MaxValue + " - " + uint.MinValue);
            Console.WriteLine("long    - " + long.MaxValue + " - " + long.MinValue);
            Console.WriteLine("ulong   - " + ulong.MaxValue + " - " + ulong.MinValue);
            Console.WriteLine("float   - " + float.MaxValue + " - " + float.MinValue);
            Console.WriteLine("double  - " + double.MaxValue + " - " + double.MinValue);
            Console.WriteLine("decimal - " + decimal.MaxValue + " - " + decimal.MinValue);
            Console.ReadKey();

            //Задание 2

            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.Write("Имя: ");
            string imya = Console.ReadLine();
            Console.Write("Город: ");
            string gorod = Console.ReadLine();
            Console.Write("Возраст: ");
            int vozrast = int.Parse(Console.ReadLine());
            Console.Write("PIN-код: ");
            string pin = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Имя: " + imya);
            Console.WriteLine("Город: " + gorod);
            Console.WriteLine("Возраст: " + vozrast);
            Console.WriteLine("PIN-код: " + pin);
            Console.ReadKey();

            //Задание 3

            Console.WriteLine();
            Console.WriteLine("Задание 3");
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            string result = "";
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                    result += char.ToLower(c);
                else if (char.IsLower(c))
                    result += char.ToUpper(c);
                else
                    result += c;
            }
            Console.WriteLine("Результат: " + result);
            Console.ReadKey();

            //Задание 4

            Console.WriteLine();
            Console.WriteLine("Задание 4");
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            string podstroka = Console.ReadLine();
            int count = 0;
            int index = 0;
            while ((index = stroka.IndexOf(podstroka, index)) != -1)
            {
                count++;
                index += podstroka.Length;
            }
            Console.WriteLine("Количество вхождений: " + count);
            Console.ReadKey();

            //Задание 5

            Console.WriteLine();
            Console.WriteLine("Задание 5");
            Console.Write("Обычная цена: ");
            int normPrice = int.Parse(Console.ReadLine());
            Console.Write("Скидка в Duty Free (%): ");
            int salePrice = int.Parse(Console.ReadLine());
            Console.Write("Стоимость отпуска: ");
            int holidayPrice = int.Parse(Console.ReadLine());
            int ekonomia = normPrice * salePrice / 100;
            int butylok = holidayPrice / ekonomia;
            Console.WriteLine("Нужно бутылок: " + butylok);
            Console.ReadKey();
        }
    }
}
