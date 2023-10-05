using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsius_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rn = new Random();
            int cTemp = rn.Next(1, 51);
            double fTemp = (9.0 / 5.0) * cTemp + 32;
            Console.WriteLine(cTemp + " degrees Celsius is equivalent to " + fTemp + " degrees Farenheit.");
            Console.ReadKey();
        }
    }
}
