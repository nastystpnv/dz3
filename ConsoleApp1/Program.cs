using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz3
{
    internal class Program
    {
        enum days
        {
            monday, tuesday, wednesday, thursday, friday, saturday, sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("номер 1");
            int[] a = { 2, 1, 5, 3, 9, 12, 45, 67, 9, 4 };
            for (int i = 0; i < 9; i++)
            {
                if (a[i + 1] < a[i])
                {
                    Console.WriteLine(a[i + 1]);
                    break;
                }
                Console.WriteLine("массив упорядочен");
            }

            Console.WriteLine("номер 2");
            Console.WriteLine("введите номер карты");
            string[] durak = { "шестёрка", "семерка", "восьмерка", "девятка", "десятка", "valet", "dama", "korol", "tuz" };
            try
            {
                int k = int.Parse(Console.ReadLine());
                if (k >= 6 && k <= 14) { Console.WriteLine(durak[k - 6]); }
                else
                {
                    Console.WriteLine("такой карты не существует");
                }               
            }
            catch (FormatException)
            {
                Console.WriteLine("введены некорректные данные");

            }

            Console.WriteLine("номер 3");
            Console.WriteLine("введите проффесию");
            int flag = 0;
            string[] prof = { "jabroni", "school counselor", "programmer", "bike cang member", "politician", "rapper" };
            string[] output = { "Patron Tequila", "Anything with Alcohol", "Hipster Craft Beer", "Moonshine", "Your tax dollars", "Cristal" };
            string input = Console.ReadLine().ToLower();
            for (int i = 0; i < 6; i++)
            {
                if (input == prof[i])
                {
                    Console.WriteLine(output[i]);
                    flag = 1;
                    break;

                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Beer");
            }
            Console.WriteLine("номер 4");
            Console.WriteLine("введите номер дня недели");
            days[] d = (days[])Enum.GetValues(typeof(days));
            try
            {
                int l = int.Parse(Console.ReadLine());
                if (l >= 1 && l <= 7) { Console.WriteLine(d[l - 1]); }
                else
                {
                    Console.WriteLine("такого дня недели не существует");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("введены некорректные данные");

            }
            Console.WriteLine("номер 5");
            string[] dool = { "jabroni", "Barbie doll", "school counselor", "Hello Kitty", "programmer", "Barbie doll", "Hello Kitty", "bike cang member", "politician", "rapper" };
            int doolcount = 0;
            foreach (string dools in dool)
            {
                if (dools == "Barbie doll" || dools == "Hello Kitty")
                {
                    doolcount++;
                }
            }
            Console.WriteLine("в корзине лежит {0} долс", doolcount);
            Console.ReadKey();

        }
    }
}
