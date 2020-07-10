using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            double length;
            double width;
            string input;

            Console.WriteLine("Please enter the length of the rectangle:");
            input = Console.ReadLine();
            length = double.Parse(input);
            Console.WriteLine("Please enter the width of the rectangle:");
            input = Console.ReadLine();
            width = double.Parse(input);
            double area = length * width;
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}
