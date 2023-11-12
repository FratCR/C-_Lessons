using System;

namespace CS_Test2
{
    public class Program
    {
        /*
        public static void writed(string word)
        {
            Console.WriteLine();
            Console.WriteLine("This is a method");
            Console.WriteLine(word);
            Console.WriteLine();
        }
        */

        /*
        public static int plus(int a, int b)
        {
            return a + b;
        }
        */



        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            writed(word);
            */

            /*
            Console.WriteLine(plus(5,15));
            Console.WriteLine("Enter number a and number b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a + b: "+ (a + b));
            */

            /*
            Cars myCar= new Cars();
            
            myCar.Mark = "Toyota";
            myCar.Model = "Corolla";
            myCar.Color = "Blue";
            myCar.Speed = 120;
            myCar.Motor = 1.6;
            
            Console.WriteLine("Mark: " + myCar.Mark);
            Console.WriteLine("Model: " + myCar.Model);
            Console.WriteLine("Color: " + myCar.Color);
            Console.WriteLine("Speed: " + myCar.Speed + " km/h");
            Console.WriteLine("Motor: " + myCar.Motor + " Motor");
            */

            /*
            Customer customer = new Customer();
            customer.Id = 00001;
            customer.Name = "Hellraiser";
            customer.Surname = "Otuzbiroglu";
            customer.Region = "Hell";

            Console.WriteLine("ID: " + customer.Id);
            Console.WriteLine("Name: " + customer.Name);
            Console.WriteLine("Surname: " + customer.Surname);
            Console.WriteLine("Region: " + customer.Region);
            */

            /*
            Customer cstm = new Customer();
            cstm.Name = Console.ReadLine();
            cstm.Surname= Console.ReadLine();
            Console.WriteLine(cstm.Name + " " + cstm.surname);
            */
            
            Parrot pr = new Parrot();
            pr.type = "Parrot";
            pr.name = "Cockatiel";
            pr.speed = 20;
            pr.color = "Yellow - Red";
            pr.weight = 1500;
            pr.makesound();

            Console.WriteLine("Parrot type is " + pr.type + ", name is "
                              + pr.name+", speed is "+ 
                              pr.speed+", weight is "+ pr.weight+ ", color is "+ pr.color);
            Console.WriteLine("Sound is "+ pr.makesound());
            Console.WriteLine();
            Crow cr = new Crow();
            Console.WriteLine("Crow sound like "+ cr.makesound());
            

            Console.Read();

        }
    }
}
