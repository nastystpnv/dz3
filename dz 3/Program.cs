using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov4 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("лабораторная 4.1");
            Console.WriteLine("введите день года от 1 до 365");
            DateTime data = Convert.ToDateTime("01.01.2022");
            int num = Convert.ToInt32(Console.ReadLine());
            data = data.AddDays(num - 1);
            Console.WriteLine(data.ToString("дата: d MMMM"));

            Console.WriteLine();

            Console.WriteLine("лабораторная 4.2");
            Console.WriteLine("введите день года от 1 до 365");
            DateTime date = Convert.ToDateTime("01.01.2022");
            int numm = Convert.ToInt32(Console.ReadLine());
            if (numm < 1 || numm > 365)
                Console.WriteLine("пожалуйста, введите день года от 1 до 365");
            else
            {
                date = date.AddDays(numm - 1);
                Console.WriteLine(date.ToString("дата: d MMMM"));
            }
            Console.WriteLine();


            Console.WriteLine("лабораторная домашняя работа задание 4.1");
            Console.WriteLine("введите день года от 1 до 365");
            int nuumm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите год: ");
            int year = int.Parse(Console.ReadLine());
            DateTime datee = Convert.ToDateTime("01.01.2022");
            if (nuumm < 1 || nuumm > 365)
            {
                Console.WriteLine("Пожалуйста, введите день года в диапозоне от 1 до 365");
            }
            else
            {
                datee = datee.AddDays(nuumm - 1);
                Console.WriteLine(datee.ToString("дата: d MMMM"));
            }
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine($"{year} год-високосный ");
            }
            else
            {
                Console.WriteLine($"{year} год-не високосный ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
