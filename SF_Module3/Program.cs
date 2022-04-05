using System;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            // const string MyName = "Andrew";

            // Console.WriteLine(MyName);

            // Console.WriteLine("\t Привет, мир");
            // Console.WriteLine("\t Мне 23");
            // Console.WriteLine("\t My name is \n Andrew");
            // Console.WriteLine('\u0040');
            // Console.WriteLine('\x23');

            // Console.WriteLine(true);
            // Console.WriteLine(false);

            // Console.WriteLine(5);

            // Console.WriteLine(0x0A);
            // Console.WriteLine(0b11);
            // Console.WriteLine(5.5);

            // string name = "Jane";
            // byte age = 27;
            // bool pet = true;
            // double shoe = 37.5;

            // Console.WriteLine("My name is " + name);
            // Console.WriteLine("My age is " + age);
            // Console.WriteLine("Do I have a pet? " + pet);
            // Console.WriteLine("My shoe size is " + shoe);

            // Console.WriteLine("IntMin {0} ", int.MinValue);
            // Console.WriteLine("IntMax {0} ", int.MaxValue);

            // Console.Write("What is your favourite day of week? ");
            // DaysOfWeek day = (DaysOfWeek)int.Parse(Console.ReadLine());
            // Console.WriteLine("Your favourite day is {0}", day);

            // АНКЕТА

            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your birth date: ");
            var birth = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your name is {0}, you are {1} and your birth date is {2}. Greetings!", name, age, birth);

            Console.ReadKey();
        }

        // enum DaysOfWeek : byte
        // {
        //     Monday = 1,
        //     Tuesday = 2,
        //     Wednesday = 3,
        //     Thursday = 4,
        //     Friday = 5,
        //     Saturday = 6,
        //     Sunday = 7
        // }

        // enum Semaphore
        // {
        //     Red = 100,
        //     Yellow = 200,
        //     Green = 300
        // }
    }
}