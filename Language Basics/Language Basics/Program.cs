using System;

namespace Language_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 30;
            string name = "James";

            Console.WriteLine("Hello World!");
            Console.WriteLine("My name is " + name + " and my age is " + age);
            Console.WriteLine("Hello World".Contains("Hello"));
            Console.WriteLine("Hello World".IndexOf("World"));
            Console.WriteLine(Math.Pow(3,2));
            //.Max will spit out which number is bigger
            Console.WriteLine(Math.Max(3, 90));

            //arrays
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[2]);

            //useing the method
            SayHi();

            Console.ReadLine();
        }

        //void is return type use int etc to return an int
        static void SayHi() 
        {
            Console.WriteLine("Hello USer");
        }
    }
}
