using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CS_Test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Day:"+DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // It's caltulating date time with your OS language
            */

            /*
            // TimeSpan time = TimeSpan.FromSeconds(13);
            TimeSpan t;
            DateTime d1, d2;
            int difference;

            d1 =Convert.ToDateTime("29.07.2004");
            d2 = Convert.ToDateTime("15.06.2024");
            t = d2- d1;
            difference = t.Days;
            Console.WriteLine(difference);
            */

            // RANDOM

            /*
            int number;
            Random r = new Random();
            number= r.Next(0,51);
            Console.WriteLine(number);
            */

            /*
            Random rn = new Random();
            int city;
            string[] cities = {"Ankara", "London", "Paris", "Berlin" };
            city = rn.Next(0, cities.Length);
            Console.WriteLine(cities[city]);
            */

            // CAPTCHA CREATING

            /*
            int d1, d2, d3, d4;
            Random rnd = new Random();
            d1 = rnd.Next(0, 10);
            d2 = rnd.Next(0, 10);
            d3 = rnd.Next(0, 10);
            d4 = rnd.Next(0, 10);
            string[] chars = { "a", "A", "b", "B", "c", "C", "d", "D", "e","E" };
            Console.WriteLine(d1 + chars[d2] + d3 + chars[d4]);
            */

            // IO LIBRARY

            /*
            // StreamWriter sw = new StreamWriter("C:\\Users\\PC\\Desktop\\abc.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\PC\Desktop\abc.txt");
            string inp = Console.ReadLine();
            sw.WriteLine(inp);
            sw.Close();
            */

            /*
            FileStream fs = new FileStream(@"C:\\Users\\PC\\Desktop\\a1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string text = sr.ReadLine();
            while (text != null)
            {
                Console.WriteLine(text);
                text = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            */

            /*
            Console.BackgroundColor= ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Hi my friends");
            */

            // MAKING TRIANGLE USING WITH MULTI-ARRAYS

            /*
            for (int i = 1; i <= 5; i++)
            {
                for (int j=1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */

            // ERROR MANAGMENT

            /*
            try
            {
                int num1, num2, final1;
                Console.Write("Number 1: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number 2: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                final1 = num1 * num2;
                Console.WriteLine("N1 * N2 = " + final1);
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Finally command is working"); // finally command is always working
            }
            */

            // LUCKY CHOOSE

            int c_choose = 0;
            Random rnd = new Random();
            int number = rnd.Next(100);

            while (c_choose != number)
            {
                Console.WriteLine("Number Enter: ");
                c_choose = Convert.ToInt32(Console.ReadLine());

                if (c_choose > number)
                {
                    Console.Write("Please Smaller ");
                }
                else if (c_choose < number)
                {
                    Console.Write("Please Larger ");
                }
                if (c_choose == number)
                {
                    Console.WriteLine("CONGRULATIONS!");
                    Console.WriteLine("Lucky Number is " + number);
                }
            }

            Console.Read();
        }
    }
}
