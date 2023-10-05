using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centsconverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an amount in cents.");
            string input = Console.ReadLine();
            int cents = Convert.ToInt32(input);
            Console.WriteLine("Integer is " + cents);
            int dollarAmt = cents / 100;
            int centAmt = cents % 100;
            Console.WriteLine("The amount is $" + dollarAmt + "." + centAmt);
            Console.ReadKey();

        }
    }
}
