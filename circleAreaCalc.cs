using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area of a Circle Calculator.");
            Console.WriteLine("Please enter the radius of the circle.");
           string input = Console.ReadLine();
            int radius = Convert.ToInt32(input);
            double area = radius * radius * 3.14159;
            Console.WriteLine(" ");
            Console.WriteLine("The area equals " + area);
            Console.WriteLine(" ");
            Console.WriteLine("The area is calculated by squaring the radius and multiplying this by pi.");
            int radius2 = radius * radius;
            Console.WriteLine("In this instance, radius squared is equal to " + radius2);
            Console.WriteLine(radius2 + " times pi is equal to " + area);
            Console.WriteLine("Thank you for using this calculator.");
            Console.ReadKey();
        }
    }
}
