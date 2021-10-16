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

            Console.ReadLine();
        }
    }
}
