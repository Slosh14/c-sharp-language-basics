using System;

namespace Language_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 30;
            string name = "James";
            //2d array
            int[,] numberGrid = {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };

            Console.WriteLine(numberGrid[1,1]);
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

            //using the method
            SayHi("Mike");
            //write method output
            Console.WriteLine(Addition(5));

            //using the switch statement
            Console.WriteLine(GetDay(1));

            //forloop
            for(int i =1; i<=5; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        //void is return type use int etc to return an int
        //parameter inside the method
        static void SayHi(string name) 
        {
            Console.WriteLine("Hello User " + name);
        }

        //return an int
        static int Addition(int num)
        {
            int result = 5 + num;
            return result;
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch(dayNum)//value to be checked
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                default:
                    dayName = "Invalid Day Name";
                    break;
            }return dayName;

        }
    }
} 
