using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CS_Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Hello World");

            Console.Read(); // Only closed if pushed "Enter"
            */

            /*
            Console.WriteLine("***** KİMLİK *****");
            Console.WriteLine();
            Console.WriteLine("Fırat");
            Console.WriteLine("Çakır");
            Console.WriteLine("Hacettepe Üniversitesi");
            Console.WriteLine("Ankara");
            Console.WriteLine();
            Console.WriteLine("***** KİMLİK *****");

            */

            // STRING

            /*
            string city = "Ankara", town = " Etimesgut";
            Console.WriteLine(city+ town);
            */

            // rectangular area and perimeter homework:

            /*
            int firstNumber, secondNumber;
            Console.WriteLine("Enter numbers for the sides of a rectangle to calculate its area and perimeter");
            Console.WriteLine("Please enter a first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            int rect_area = firstNumber * secondNumber;
            int rect_per = (firstNumber * 2) + (secondNumber * 2);

            Console.WriteLine("Rectangular area is " + rect_area + " and rectangular perimeter is " + rect_per );
            */

            // CALCULATOR:

            /*
            int firstNumber, secondNumber, addition, substraction, multiplication, process;
            Console.WriteLine("Enter the numbers you want to process");
            Console.WriteLine("Please enter a first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please list the operations you will do from 1-4: \n1-addition \n2-subtraction \n3-multiplication \n4-division");
            process = Convert.ToInt32(Console.ReadLine());

            switch (process)
            {
                case 1:
                    addition = firstNumber + secondNumber;
                    Console.WriteLine(addition);
                    break;
                case 2:
                    substraction = firstNumber - secondNumber;
                    Console.WriteLine(substraction);
                    break;
                case 3:
                    multiplication = firstNumber * secondNumber;
                    Console.WriteLine(multiplication);
                    break;
                case 4:
                    float division = (float)firstNumber / (float)secondNumber;
                    Console.WriteLine(division);
                    break;
                default:
                    Console.WriteLine("PLEASE ENTER 1-4 AROUND NUMBER!");
                    break;
            }
            */

            // NOTE PROGRAM

            /*
            float vise, final, total, vise_note, final_note;
            Console.WriteLine("Enter your Vise and Final notes");
            Console.WriteLine("Please enter a Vise: ");
            vise = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a Final: ");
            final = Convert.ToInt32(Console.ReadLine());
            vise_note = vise * ((float)4 / 10);
            final_note = final * ((float)6 / 10);
            total = vise_note + final_note;

            Console.WriteLine("Vise Note: " + vise_note +"\nFinal Note: " + final_note + "\nTotal: " + total);

            if (total >= 50 & final >= 50){
                Console.WriteLine("You are Passed this lesson");
            }
            else
            {
                Console.WriteLine("You are failed to this lesson!");
            }
            */

            // FLOAT

            /*
            float number = 365.47f; // last f(loat) is saving us :D
            Console.WriteLine(number);
            */

            // Instead of using Convert.ToFloat to convert float, we use the Float.Parse() method
            // exmp: float.Parse(Console.ReadLine());

            // MIN MAX
            /*
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            */

            // CHATGPT USING C# AND SQL TO ASSIGN PERSONEL ID NUMBER

            /*
            using System;
            using System.Data.SqlClient;

            class Program
                    {
                        static void Main()
                        {
                            string connectionString = "Data Source=VeritabanıSunucuAdı;Initial Catalog=VeritabanıAdı;Integrated Security=True";

                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();

                                for (int i = 1; i <= 100; i++)
                                {
                                    string insertQuery = "INSERT INTO CalismaKartlari (KartNumarasi) VALUES (@KartNumarasi)";
                                    SqlCommand command = new SqlCommand(insertQuery, connection);
                                    command.Parameters.AddWithValue("@KartNumarasi", i);
                                    command.ExecuteNonQuery();
                                }
                            }

                            Console.WriteLine("Çalışma kartları veritabanına eklendi.");
                        }
                    }
            */

            // TAM BOLEN BULMA UYGULAMASI

            /*
            int sayi;
            Console.WriteLine("Enter a number: ");
            sayi = Convert.ToInt16(Console.ReadLine());
            for(int i = 1; i <= sayi; i++)
            {
                if(sayi % i == 0)
                {
                    Console.WriteLine("Divisions: " + i);
                }
            }
            */

            // HER SAAT SONUNDA 2'YE KATLANAN BAKTERILERIN 24 SAAT SONUNDAKI DURUMU

            /*
            int bakteri = 1;
            for(int i = 1; i <= 24; i++)
            {
                bakteri *= 2;
                Console.WriteLine(i+ ".Saat: " +bakteri);
            }
            */


            // Total Calculator

            /*
            int total = 0;
            for(int i = 0; i <= 10; i++)
            {
                total+= i;
                Console.WriteLine(total);
            }
            */


            // Factorized number

            /*
            Console.Write("Enter the number to be factorized: ");
            int fact = Convert.ToInt32(Console.ReadLine());
            int fl = 1;
            for (int i = 1; i < fact+1 ;i++)
            {
                fl *= i;
                // Console.WriteLine(fl);
            }
            Console.WriteLine(fl);
            */

            // Factorized number while

            /*
            Console.Write("Enter the number to be factorized: ");
            int fact = Convert.ToInt32(Console.ReadLine());
            int fl = 1; int i = 1;
            while (i < fact + 1)
            {
                fl *= i;
                // Console.WriteLine(fl);
                i++;
            }
            Console.WriteLine(fl);
            */

            // WRITED ALL VALUED INSIDE OF ARRAYS

            /*
            int[] numbers = {10, 20, 30, 40, 50, 60, 70};
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            */

            /*
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 20 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            */

            // WITH FOREACH

            /*
            int[] numbers = { 14, 28, 78, 55, 99, 43};
            int total = 0;
            foreach(int x in numbers) {
                total += x;
            }
            Console.WriteLine(total);
            */

            // ARRAY ENTERING AND SEEING

            /*
            string[] cities = new string[5];
            Console.WriteLine("You can enter 5 City: ");
            Console.WriteLine();
            for (int i = 0;i < 5;i++)
            {
                Console.WriteLine("Enter a City: ");
                cities[i] = Console.ReadLine();
            }
            for(int j= 0;j < 5;j++)
            {
                Console.WriteLine(cities[j]);
            }
            */

            



            // BILGI YARISMASI GELISTIR, PUANLI OLACAK VE HAYAL GUCUNU KULLAN
            // BANKAMATIK ARAYUZ EKRANI YAP



            Console.ReadKey();

        }
    }
}
